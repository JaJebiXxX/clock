using System.Numerics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        
        float sx, sy, mx, my, hx, hy; 

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DateTime dt = DateTime.Now;
            sx = (float)Math.Sin(dt.Second / 30f * Math.PI) * 160;
            sy = (float)Math.Cos(dt.Second / 30f * Math.PI) * 160;
            mx = (float)Math.Sin(dt.Minute / 30f * Math.PI) * 120;
            my = (float)Math.Cos(dt.Minute / 30f * Math.PI) * 120;
            hx = (float)Math.Sin(dt.Hour / 6f * Math.PI) * 80;
            hy = (float)Math.Cos(dt.Hour / 6f * Math.PI) * 80;
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, 400, 400);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 200, 200, 200+sx, 200+sy*-1);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 200, 200, 200+mx, 200+my*-1);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 200, 200, 200+hx, 200+hy*-1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zegar.Invalidate();
        }
        
    }
}
