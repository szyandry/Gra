using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
        
 
    {
        public static bool START = true;
        bool up, left;
            Sprite[] sprites = new Sprite[10];

        public Form1()
        {
            InitializeComponent();
        }
        public void loadSprite(string file , int num , int x , int y)
        {
            sprites[num] = new Sprite(file , x , y);
        }
        public void loadSprite(string file, int num, int x, int y, int w , int h)
        {
            sprites[num] = new Sprite(file, x, y , w, h);
        }
        public void SetupGame()
        {

        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.Font = new Font("Snap ITC", 42);
        }
        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.Font = new Font("Snap ITC", 36);

        }

        private void lblStart_MouseEnter(object sender, EventArgs e)
        {
            lblStart.Font = new Font("Snap ITC", 42);
        }
        private void lblStart_MouseLeave(object sender, EventArgs e)
        {
            lblStart.Font = new Font("Snap ITC",36);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Czas_Tick(object sender, EventArgs e)
        {
            if (START)
                this.Refresh();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Czas.Start();
            START = true;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics g= e.Graphics;
            foreach (Sprite s in sprites)
            {
                if (s != null)
                {
                    if (s.Show == true)
                        g.DrawImage(s.CurrentSprite, new Rectangle(s._x, s._y, s._width, s._height));
                }
            }
        }
    }
}
