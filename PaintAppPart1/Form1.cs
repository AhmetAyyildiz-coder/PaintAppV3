using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintAppPart1
{
    public partial class Form1 : Form
    {
        //variables

        /// <summary>
        /// resim için kullanılacak
        /// </summary>
        Bitmap bpm;


        //ana çizim işlemlerinin olduğu sınıf burası
        Graphics graphics;

        bool isPaint; //şuan çizgi mi çiziliyor ?

        Point pointX, pointY;

        Pen defaultPen;

        /// <summary>
        /// butonlara tıklanıldığında değer atadığımız değişken
        /// </summary>
        int index;
        public Form1()
        {
            InitializeComponent();

            bpm = new Bitmap(PaintPictureBox.Width, PaintPictureBox.Height);
            graphics = Graphics.FromImage(bpm);

            graphics.Clear(Color.White);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PaintPictureBox.Image = bpm;

            defaultPen = new Pen(Color.Black, 3);
            defaultPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            defaultPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


        }
        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void PaintPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
        }

        private void PaintPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                if (index ==1)
                {//kullanıcımız kalem seçmiş demektir.
                    pointX = e.Location;
                    graphics.DrawLine(defaultPen, pointY, pointX);

                    pointY = pointX;
                }
            }
            PaintPictureBox.Refresh();
            //
        }

        private void PaintPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            pointY = e.Location;

        }

        
    }
}
