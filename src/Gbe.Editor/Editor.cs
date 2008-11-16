using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SdlDotNet.Core;
using SdlDotNet.Graphics;
using SdlDotNet.Graphics.Primitives;
using Color=System.Drawing.Color;

namespace Gbe.Editor
{
    public partial class Editor : Form
    {
        // Affichage
        private Thread m_sdlThread;
        private Surface m_surface;

        // Données de l'éditeur
        private readonly List<KeyPoint> m_trajectoryPoints = new List<KeyPoint>();
        private KeyPoint m_hoverPoint;
        private KeyPoint m_selectedPoint;

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, System.EventArgs e)
        {
            SdlDotNet.Core.Events.Fps = 60;
            SdlDotNet.Core.Events.Tick += OnTick;

            m_surface = new Surface(editorSurface.Width, editorSurface.Height);

            m_sdlThread = new Thread(SdlDotNet.Core.Events.Run)
            {
                IsBackground = true,
                Name = "SDL.NET",
                Priority = ThreadPriority.Normal
            };
            m_sdlThread.Start();
        }

        private void OnTick(object sender, TickEventArgs e)
        {
            m_surface.Fill(Color.Black);
            m_surface.Draw(new Box(new Point(100, 100), new Size(240, 320)), Color.Red);

            lock (m_trajectoryPoints)
            {
                foreach (var point in m_trajectoryPoints)
                {
                    var line1 = new Line(new Point(point.Point.RoundX, point.Point.RoundY - 5), new Point(point.Point.RoundX, point.Point.RoundY + 5));
                    var line2 = new Line(new Point(point.Point.RoundX - 5, point.Point.RoundY), new Point(point.Point.RoundX + 5, point.Point.RoundY));
                    m_surface.Draw(line1, Color.Green);
                    m_surface.Draw(line2, Color.Green);
                    if (point.Selected)
                    {
                        var circle = new Circle(new Point(point.Point.RoundX, point.Point.RoundY), 6);
                        m_surface.Draw(circle, Color.Red);
                    }
                    else if (point.Hover)
                    {
                        var circle = new Circle(new Point(point.Point.RoundX, point.Point.RoundY), 5);
                        m_surface.Draw(circle, Color.Green);
                    }
                }
            }

            editorSurface.Blit(m_surface);
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            lock (m_trajectoryPoints)
            {
                m_trajectoryPoints.Clear();
                listPoints.Items.Clear();
            }
        }

        private void editorSurface_MouseUp(object sender, MouseEventArgs e)
        {
            lock (m_trajectoryPoints)
            {
                if (m_hoverPoint != null)
                {
                    // Select point
                    setSelected(m_hoverPoint);
                }
                else
                {
                    // Insert new point
                    var newPoint = new KeyPoint(e.X, e.Y) {Selected = true};
                    m_trajectoryPoints.Add(newPoint);
                    listPoints.Items.Add(newPoint);
                    setSelected(newPoint);
                }
            }
        }

        private void editorSurface_MouseMove(object sender, MouseEventArgs e)
        {
            lock (m_trajectoryPoints)
            {
                resetHover();
                float nearestDistance = float.MaxValue;
                foreach (var point in m_trajectoryPoints)
                {
                    float dx = point.Point.X - e.X;
                    float dy = point.Point.Y - e.Y;
                    float distance = dx*dx + dy*dy;
                    if (distance < 25 && distance < nearestDistance)
                    {
                        nearestDistance = distance;
                        setHover(point);
                    }
                }
            }
        }

        private void resetHover()
        {
            if (m_hoverPoint != null)
            {
                m_hoverPoint.Hover = false;
                m_hoverPoint = null;
            }
        }

        private void setHover(KeyPoint point)
        {
            resetHover();
            m_hoverPoint = point;
            m_hoverPoint.Hover = true;
        }

        private void resetSelected()
        {
            if (m_selectedPoint != null)
            {
                m_selectedPoint.Selected = false;
                m_selectedPoint = null;
            }
        }

        private void setSelected(KeyPoint point)
        {
            resetSelected();
            m_selectedPoint = point;
            m_selectedPoint.Selected = true;
            listPoints.SelectedItem = m_selectedPoint;
        }

        private void listPoints_MouseMove(object sender, MouseEventArgs e)
        {
            resetHover();
            int index = listPoints.IndexFromPoint(e.X, e.Y);
            if (index != -1)
            {
                setHover((KeyPoint)listPoints.Items[index]);
            }
        }

        private void listPoints_SelectedValueChanged(object sender, System.EventArgs e)
        {
            setSelected((KeyPoint)listPoints.SelectedItem);
        }
    }
}
