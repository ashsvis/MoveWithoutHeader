using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveWithoutHeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tsbMaximize.Visible = false;
            tsbNormal.Visible = true;
        }

        private void tsbNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            tsbNormal.Visible = false;
            tsbMaximize.Visible = true;
        }

        private void tsbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point first;
        private bool draging = false;

        private void flpCaption_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && 
                e.Button == MouseButtons.Left)
            {
                first = e.Location;
                draging = true;
            }
        }

        private void flpCaption_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                var dx = e.Location.X - first.X;
                var dy = e.Location.Y - first.Y;
                var location = this.Location;
                location.Offset(dx, dy);
                this.Location = location;
            }
        }

        private void flpCaption_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }
    }
}
