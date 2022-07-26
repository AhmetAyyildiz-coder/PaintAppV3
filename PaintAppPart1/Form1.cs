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


        //for draw for draw rectangle
        /// <summary>
        ///  draw rectangle for parameters
        /// </summary>
        int MoveX, MoveY,sizeX,sizeY,startPositionX, startPositionY;

        private void PaintPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (isPaint)
            {
                if (index == 3)
                {
                    //graphics.FillEllipse(new SolidBrush(Color.Black), startPositionX, startPositionY, sizeX, sizeY);
                    graphics.DrawEllipse(defaultPen, startPositionX, startPositionY, sizeX, sizeY);

                }
                if (index ==2)
                {
                    graphics.DrawRectangle(defaultPen, startPositionX, startPositionY, sizeX, sizeY);
                }
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

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
        private void PaintPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            pointY = e.Location;

            //for draw rectangle
            startPositionX = e.X;
            startPositionY = e.Y;
        }

        private void PaintPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                if (index == 1)
                {//kullanıcımız kalem seçmiş demektir.
                    pointX = e.Location;
                    graphics.DrawLine(defaultPen, pointY, pointX);

                    pointY = pointX;
                }
            }
            PaintPictureBox.Refresh();

            //for draw rectangle
            MoveX = e.X; //mouse x ekseninde ne kadar hareket ettirilmiş 
            MoveY = e.Y; //mosue y ekseninde ne kadar hareket ettirilmiş
            sizeX = e.X - startPositionX;
            sizeY = e.Y - startPositionY;
            //
        }
        private void PaintPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;

            //for draw rectangle
            sizeX = MoveX - startPositionX;
            sizeY = MoveY - startPositionY;
            if (index == 3)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), startPositionX, startPositionY, sizeX, sizeY);
            }
            if (index ==2)
            {
                graphics.FillRectangle(new SolidBrush(Color.Black), startPositionX, startPositionY, sizeX, sizeY);
            }
             
        }

       

        

        
    }
}
