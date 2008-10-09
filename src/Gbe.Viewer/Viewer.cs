using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Antlr.Runtime;
using Gbe.Engine;
using Gbe.Engine.Entities;
using Gbe.Engine.Executor.Rules;
using Gbe.Script;
using SdlDotNet.Core;
using SdlDotNet.Graphics;
using SdlDotNet.Graphics.Primitives;
using Color=System.Drawing.Color;
using Rectangle=Gbe.Engine.Rectangle;

namespace Gbe.Viewer
{
    public delegate void UpdateFunction();

    public partial class Viewer : Form
    {
        private readonly Queue<DateTime> _lastFrames = new Queue<DateTime>(100);
        private bool _down;
        private Engine.Engine _engine;
        private DateTime _lastPreparation;
        private bool _left, _right;
        private bool _running;
        private Thread _sdlThread;
        private Surface _surface;
        private bool _up;
        private Surface _window;

        public Viewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _window = Video.SetVideoMode(440, 520, false, false, false, true, true);
            Video.WindowCaption = "GBE Viewer";

            SdlDotNet.Core.Events.Fps = 60; // _engine.Fps;
            SdlDotNet.Core.Events.Tick += OnTick;
            //SdlDotNet.Core.Events.Quit += OnQuit;

            _surface = new Surface(_window.Width, _window.Height);

            _engine = new Engine.Engine();
            _lastPreparation = DateTime.Now;
            _engine.Context.GameArea = new Rectangle(0, 0, 240, 320);
            var player = new PlayerEntity(_engine.GenerateId()) {Position = new Point2(100, 300), Speed = 150};
            //var enemy = new EnemyClassdef(_engine.GenerateId()) {Position = new Point2(120, 10)};
            _engine.AddPlayer(player);
            //_engine.AddEntity(enemy);
            //_engine.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, 0.3f), 2f));
            //_engine.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, -0.3f), 2f));
            //_engine.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, 0.8f), 2f));
            //_engine.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, -0.8f), 2f));


            var lexer = new GbsLexer(new ANTLRFileStream("../../src/Gbe.Viewer/script.txt"));
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new GbsParser(tokenStream);
            var gbs = parser.gbs().s;
            Console.WriteLine("Ok. " + gbs.Entities.Count + " entities found:");
            foreach (var entity in gbs.Entities)
            {
                Console.WriteLine("{0} className={1} subEntities={2} triggers={3}", entity.GetType(), entity.ClassName,
                                  entity.SubEntities != null ? entity.SubEntities.Count.ToString() : "null",
                                  entity.Triggers != null ? entity.Triggers.Count.ToString() : "null");
            }
            var compiledGbs = gbs.Compile();
            Console.WriteLine("Compiled? {0}", compiledGbs != null);
            if (compiledGbs != null)
            {
                compiledGbs.Run(_engine, "TestLevel");
            }

            _sdlThread = new Thread(SdlDotNet.Core.Events.Run)
                             {
                                 IsBackground = true,
                                 Name = "SDL.NET",
                                 Priority = ThreadPriority.Normal
                             };
            _sdlThread.Start();
            _running = true;
        }

        private void OnTick(object sender, TickEventArgs e)
        {
            PrepareNextFrame();
            _surface.Fill(Color.Black);
            _surface.Draw(new Box(new Point(100, 100), new Size(240, 320)), Color.Red);
            foreach (var entity in _engine.Entities)
            {
                if (entity.HasProperty(EntityProperties.POSITION))
                {
                    var position = EntityProperties.GetPosition(entity);
                    var center = new Point((int) Math.Round(100 + position.X), (int) Math.Round(100 + position.Y));
                    IPrimitive shape;
                    var color = DefaultBackColor;
                    string animation = null;
                    if (entity.HasProperty(EntityProperties.ANIMATION))
                    {
                        animation = EntityProperties.GetAnimation(entity);
                    }
                    switch (animation)
                    {
                        case "triangle":
                            shape = new Polygon(
                                new[] {(short) (center.X + 5), (short) (center.X - 5), (short) center.X},
                                new[] {(short) (center.Y + 5), (short) (center.Y + 5), (short) (center.Y - 5)});
                            color = Color.Green;
                            break;
                        case "box":
                            Point cornerA = center;
                            cornerA.Offset(-5, -5);
                            Point cornerB = center;
                            cornerB.Offset(5, 5);
                            shape = new Box(cornerA, cornerB);
                            color = Color.Blue;
                            break;
                        case "trainee":
                            var positions = EntityProperties.GetTrainee(entity);
                            int nPoints = (positions.Count >= 20) ? 20 : positions.Count;
                            int c = nPoints;
                            for (int i = Math.Max(0, positions.Count - 20); i < positions.Count; i++)
                            {
                                shape = new Circle(new Point(positions[i].RoundX + 100, positions[i].RoundY + 100), 3);
                                color = Color.FromArgb(255 - 8*c, 255 - 8*c, 0);
                                _surface.Draw(shape, color, false, true);
                                c--;
                            }
                            shape = null;
                            break;
                        default:
                            shape = new Circle(center, 3);
                            color = Color.Pink;
                            break;
                    }
                    if (shape != null)
                    {
                        _surface.Draw(shape, color, false, true);
                    }
                }
            }
            _window.Blit(_surface);
            _window.Update();
            if (_running)
            {
                try
                {
                    Invoke(new UpdateFunction(UpdateStats));
                }
                catch (ObjectDisposedException)
                {
                    // Does nothing
                }
                catch (InvalidOperationException)
                {
                    // Does nothing either
                }
            }
        }

        private void PrepareNextFrame()
        {
            if (_left)
            {
                _engine.Executor.AddRule(_engine.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_LEFT)));
            }
            if (_right)
            {
                _engine.Executor.AddRule(_engine.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_RIGHT)));
            }
            if (_up)
            {
                _engine.Executor.AddRule(_engine.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_UP)));
            }
            if (_down)
            {
                _engine.Executor.AddRule(_engine.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_DOWN)));
            }
            _engine.Update((float) (DateTime.Now - _lastPreparation).TotalSeconds);
            _lastPreparation = DateTime.Now;
        }

        private void UpdateStats()
        {
            if (_lastFrames.Count == 100)
            {
                _lastFrames.Dequeue();
            }
            _lastFrames.Enqueue(DateTime.Now);
            double fps = _lastFrames.Count/(DateTime.Now - _lastFrames.Peek()).TotalSeconds;
            txtNumberOfEntities.Text = _engine.Entities.Count.ToString();
            txtNumberOfRules.Text = _engine.Executor.RulesCount.ToString();
            txtFPS.Text = fps.ToString("#0.00");
            txtCurrentFrame.Text = _engine.Context.CurrentFrame.ToString();
            txtElapsedTime.Text = _engine.Context.TotalElapsedSeconds.ToString("####0.00");
        }

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _left = true;
                    break;
                case Keys.Right:
                    _right = true;
                    break;
                case Keys.Down:
                    _down = true;
                    break;
                case Keys.Up:
                    _up = true;
                    break;
            }
        }

        private void Viewer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _left = false;
                    break;
                case Keys.Right:
                    _right = false;
                    break;
                case Keys.Down:
                    _down = false;
                    break;
                case Keys.Up:
                    _up = false;
                    break;
                case Keys.Escape:
                    _running = false;
                    Close();
                    break;
            }
        }
    }
}