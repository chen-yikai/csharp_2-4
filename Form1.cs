using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goTop_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X, picture.Location.Y - 20);
            if (picture.Location.Y + picture.Height < 0)
            {
                picture.Location = new Point(picture.Location.X, this.Height);
            }
        }

        private void gotDown_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X, picture.Location.Y + 20);
            if (picture.Location.Y > this.Height)
            {
                picture.Location = new Point(picture.Location.X, 0 - picture.Height);
            }
        }

        private void goLeft_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X-20, picture.Location.Y);
            if (picture.Location.X + picture.Width < 0)
            {
                picture.Location = new Point(this.Width,picture.Location.Y);
            }
        }

        private void goRight_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X+20, picture.Location.Y );
            if (picture.Location.X > this.Width)
            {
                picture.Location = new Point(0-picture.Width, picture.Location.Y);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(0,0);

        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            picture.Size = new Size(picture.Width+10, picture.Height +10);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            picture.Size = new Size(picture.Width - 10, picture.Height - 10);
        }
    }
}
