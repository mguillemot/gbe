using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Antlr.Runtime;
using Gbe.Engine;
using Gbe.Engine.GearLibrary;
using Gbe.Engine.Executor.Rules;
using Gbe.Script;
using Gbe.Script.Executor;
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
        private readonly Queue<DateTime> m_lastFrames = new Queue<DateTime>(100);
        private Engine.Gbe m_gbe;
        private DateTime m_lastPreparation;
        private bool m_up, m_down, m_left, m_right;
        private bool m_running;
        private Thread m_sdlThread;
        private Surface m_surface;
        private Surface m_window;
        private CompiledGbs m_script;
        private GbsExecutor m_scriptExecutor;

        public Viewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_window = Video.SetVideoMode(440, 520, false, false, false, true, true);
            Video.WindowCaption = "GBE Viewer";

            SdlDotNet.Core.Events.Fps = 60; // m_gbe.Fps;
            SdlDotNet.Core.Events.Tick += OnTick;
            //SdlDotNet.Core.Events.Quit += OnQuit;

            m_surface = new Surface(m_window.Width, m_window.Height);

            m_gbe = new Engine.Gbe();
            m_lastPreparation = DateTime.Now;
            m_gbe.Context.GameArea = new Rectangle(0, 0, 240, 320);
            var player = new PlayerGear(m_gbe.GenerateId()) {Position = new Point2(100, 300), Speed = 150};
            //var enemy = new EnemyClassdef(m_gbe.GenerateId()) {Position = new Point2(120, 10)};
            m_gbe.AddPlayer(player);
            //m_gbe.AddGear(enemy);
            //m_gbe.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, 0.3f), 2f));
            //m_gbe.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, -0.3f), 2f));
            //m_gbe.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, 0.8f), 2f));
            //m_gbe.Executor.AddRule(enemy, new PeriodicRule(new FireAtPlayerRule(300, -0.8f), 2f));


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
            m_script = gbs.Compile();
            Console.WriteLine("Compiled? {0}", m_script != null);
            if (m_script != null)
            {
                m_scriptExecutor = m_script.Run(m_gbe, "TestLevel");
            }

            m_sdlThread = new Thread(SdlDotNet.Core.Events.Run)
                             {
                                 IsBackground = true,
                                 Name = "SDL.NET",
                                 Priority = ThreadPriority.Normal
                             };
            m_sdlThread.Start();
            m_running = true;
        }

        private void OnTick(object sender, TickEventArgs e)
        {
            PrepareNextFrame();
            m_surface.Fill(Color.Black);
            m_surface.Draw(new Box(new Point(100, 100), new Size(240, 320)), Color.Red);
            foreach (var entity in m_gbe.Gears)
            {
                if (entity.HasProperty(GearProperties.POSITION))
                {
                    var position = GearProperties.GetPosition(entity);
                    var center = new Point((int) Math.Round(100 + position.X), (int) Math.Round(100 + position.Y));
                    IPrimitive shape;
                    var color = DefaultBackColor;
                    string animation = null;
                    if (entity.HasProperty(GearProperties.ANIMATION))
                    {
                        animation = GearProperties.GetAnimation(entity);
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
                            var positions = GearProperties.GetTrainee(entity);
                            int nPoints = (positions.Count >= 20) ? 20 : positions.Count;
                            int c = nPoints;
                            for (int i = Math.Max(0, positions.Count - 20); i < positions.Count; i++)
                            {
                                shape = new Circle(new Point(positions[i].RoundX + 100, positions[i].RoundY + 100), 3);
                                color = Color.FromArgb(255 - 8*c, 255 - 8*c, 0);
                                m_surface.Draw(shape, color, false, true);
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
                        m_surface.Draw(shape, color, false, true);
                    }
                }
            }
            m_window.Blit(m_surface);
            m_window.Update();
            if (m_running)
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
            if (m_left)
            {
                m_gbe.Executor.AddRule(m_gbe.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_LEFT)));
            }
            if (m_right)
            {
                m_gbe.Executor.AddRule(m_gbe.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_RIGHT)));
            }
            if (m_up)
            {
                m_gbe.Executor.AddRule(m_gbe.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_UP)));
            }
            if (m_down)
            {
                m_gbe.Executor.AddRule(m_gbe.GetPlayer().Id,
                                         new ExecuteOnceRule(new LinearTrajectoryRule(MathHelper.ANGLE_DOWN)));
            }
            m_gbe.Update((float) (DateTime.Now - m_lastPreparation).TotalSeconds);
            m_lastPreparation = DateTime.Now;
        }

        private void UpdateStats()
        {
            if (m_lastFrames.Count == 100)
            {
                m_lastFrames.Dequeue();
            }
            m_lastFrames.Enqueue(DateTime.Now);
            double fps = m_lastFrames.Count/(DateTime.Now - m_lastFrames.Peek()).TotalSeconds;
            txtNumberOfEntities.Text = m_gbe.Gears.Count.ToString();
            txtNumberOfRules.Text = m_gbe.Executor.RulesCount.ToString();
            txtFPS.Text = fps.ToString("#0.00");
            txtCurrentFrame.Text = m_gbe.Context.CurrentFrame.ToString();
            txtElapsedTime.Text = m_gbe.Context.TotalElapsedSeconds.ToString("####0.00");
        }

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_left = true;
                    break;
                case Keys.Right:
                    m_right = true;
                    break;
                case Keys.Down:
                    m_down = true;
                    break;
                case Keys.Up:
                    m_up = true;
                    break;
            }
        }

        private void Viewer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_left = false;
                    break;
                case Keys.Right:
                    m_right = false;
                    break;
                case Keys.Down:
                    m_down = false;
                    break;
                case Keys.Up:
                    m_up = false;
                    break;
                case Keys.Escape:
                    m_running = false;
                    Close();
                    break;
            }
        }
    }
}