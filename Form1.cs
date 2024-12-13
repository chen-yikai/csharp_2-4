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
            picture.Location = new Point(picture.Location.X, picture.Location.Y - 20); // 設定新的圖片位置
            if (picture.Location.Y + picture.Height < 0) // 如果圖片超出window上方
            {
                picture.Location = new Point(picture.Location.X, this.Height); // 將圖片移到window下方
            }
        }
        private void gotDown_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X, picture.Location.Y + 20); // 設定新的圖片位置
            if (picture.Location.Y > this.Height) // 如果圖片超出window下方
            {
                picture.Location = new Point(picture.Location.X, 0 - picture.Height); // 將圖片移到window上方
            }
        }
        private void goLeft_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X - 20, picture.Location.Y); // 設定新的圖片位置
            if (picture.Location.X + picture.Width < 0) // 如果圖片超出window左方
            {
                picture.Location = new Point(this.Width, picture.Location.Y); // 將圖片移到window右方
            }
        }
        private void goRight_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(picture.Location.X + 20, picture.Location.Y); // 設定新的圖片位置
            if (picture.Location.X > this.Width) // 如果圖片超出window右方
            {
                picture.Location = new Point(0 - picture.Width, picture.Location.Y); // 將圖片移到window左方
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(0, 0); // 將圖片移到window左上角(0,0)

        }
        private void zoomIn_Click(object sender, EventArgs e)
        {
            picture.Size = new Size(picture.Width + 10, picture.Height + 10); // 設定新的圖片大小


        }
        private void zoomOut_Click(object sender, EventArgs e)
        {
            if (picture.Size.Width > 50 || picture.Size.Height > 50) // 如果圖片大小小於50*50，不再縮小
            {
                picture.Size = new Size(picture.Width - 10, picture.Height - 10); // 縮小圖片
            }
        }
    }
}
