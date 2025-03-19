using Laba5.Objeckt.Objects;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
namespace Laba5.Objeckt
{
    public partial class Form1 : Form
    {
        List<BaseObject> objects = new();
        Player player;
        Marker marker;
        Circle circle;
        Random rnd = new Random();
        int point = 0;
        public Form1()
        {
            InitializeComponent();
            circle = new Circle(pbMain.Width / 3, pbMain.Height / 3, 0);
            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);

            player.OnOverlap += (p, obj) =>
            {
                txtLog.Text = $"[{DateTime.Now:HH:mm:ss:ff}] Игрок пересекся с {obj}\n" + txtLog.Text;
            };

            player.OnCircleOverlap += (m) =>
            {
                txtBoxPoint.Clear();
                objects.Remove(m);
                circle = null;
                point++; 
                string str = "Очки: " + point;
                txtBoxPoint.Text = str;
                circle = new Circle(rnd.Next(40, pbMain.Width - 41), rnd.Next(40, pbMain.Height - 41), 0);
                objects.Add(circle);
            };

            player.OnMarkerOverlap += (m) =>
            {
                objects.Remove(m);
                marker = null;
            };

            marker = new Marker(pbMain.Width / 2 + 50, pbMain.Height / 2 + 50, 0);

            objects.Add(circle);
            objects.Add(marker);
            objects.Add(player);
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            updatePlayer();

            foreach (var obj in objects.ToList())
            {
                if (obj != player && player.Overlaps(obj, g))
                {
                    player.Overlap(obj); 
                }
            }
            foreach (var obj in objects.ToList())
            {
                g.Transform = obj.GetTransform();
                obj.Render(g);
                if (obj is Circle && (circle.RemoveCircle()==true))
                {
                    objects.Remove(circle); 
                    circle = new Circle(rnd.Next(40, pbMain.Width -41), rnd.Next(40, pbMain.Height - 41), 0); 
                    objects.Add(circle); 
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbMain.Invalidate();
        }

        private void PbMain(object sender, MouseEventArgs e)
        {
            if (marker == null)
            {
                marker = new Marker(0, 0, 0);
                objects.Add(marker);
            }
            marker.X = e.X;
            marker.Y = e.Y;
        }

        private void updatePlayer()
        {
            if (marker != null)
            {
                float dx = marker.X - player.X;
                float dy = marker.Y - player.Y;

                float length = MathF.Sqrt(dx * dx + dy * dy);
                dx /= length;
                dy /= length;

                player.vX += dx * 0.5f;
                player.vY += dy * 0.5f;
                player.Angle = 90 - MathF.Atan2(player.vX, player.vY) * 180 / MathF.PI;
            }

            player.vX += -player.vX * 0.1f;
            player.vY += -player.vY * 0.1f;
            player.X += player.vX;
            player.Y += player.vY;
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }
    }
}