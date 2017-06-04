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
        public Form1()
        {
            InitializeComponent();
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

        private void Draw(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            Graphics = e.Graphics;
        }
    }
}
