using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintAppPart1.Domain
{
    internal  class baseShape
    {
        private int x; //startPositionX
        private int y; //startPositionY
        private int width;
        private int height;
        public bool isSelected = false;
        public Color itemColor;
        Pen defaultPen;
        /// <summary>
        /// bu fonksiyonumuz bizim gönderilen nesnenin çizim aralığında olup olmamasını sorgular.
        /// </summary>
        /// <param name="LocationX"></param>
        /// <param name="LocationY"></param>
        /// <returns></returns>
        public  bool isInside(int LocationX, int LocationY)
        {
            bool sol; //solution
            if (LocationX >= x && LocationX <= x + width && LocationY >= y && LocationY <= y + height)
            {
                sol = true;
            }
            else
            {
                sol = false;
            }

            return sol;
        }
        public Point location
        {
            get => new Point(x, y);
            set { x = value.X; y = value.Y; }
        } 
        public Size size
        {
            get => new Size(width, height);
            set { width = value.Width; height = value.Height; }
        }
       

        public baseShape(Color color,int x, int y, int width, int height)
        {
            defaultPen = new Pen(color, 3);
            this.itemColor = color;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        

        public void removeDraw(Graphics selectedGrap)
        {
            defaultPen.Color = Color.White;
            selectedGrap.FillRectangle(new SolidBrush(Color.White), this.X - 15, this.Y - 15, this.Width + 30, this.Height + 30);
        }

        /// <summary>
        /// this overried is only circle and rectangle
        /// </summary>
        /// <param name="selectedGrap"></param>
        /// <param name="color"></param>
        public void Fill(Graphics selectedGrap , Color? color )
        {

            if (color !=null)
            {              
                    selectedGrap.FillRectangle(new SolidBrush(color.Value), X, Y, Width, Height);
            }
            else
            {
                selectedGrap.FillRectangle(new SolidBrush(defaultPen.Color), X, Y, Width, Height);

            }
        }
        public void FillCircle(Graphics grap , int x , int y , int width , int height)
        {
            grap.FillEllipse(new SolidBrush(defaultPen.Color) , x , y , width , height);
        }

        public void FillHexagon(Graphics grap , float x , float y , float radius)
        {
            Point[] coordinats = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                coordinats[i] = new Point(
                    (int)(x + radius * (float)Math.Cos(i * 60 * Math.PI / 180f)),
                    (int)(y + radius * (float)Math.Sin(i * 60 * Math.PI / 180f)));
            };

            grap.FillPolygon(new SolidBrush(defaultPen.Color), coordinats);
            
        }

        /// <summary>
        /// this overried ise only Triange and hexagon
        /// </summary>
        /// <param name="selectedGrap"></param>
        /// <param name="color"></param>
        /// <param name="shapeName"></param>
        /// <param name="coordinatList">For hexagon and triangle</param>
        public void Fill(Graphics selectedGrap, Color? color, string shapeName, Point[] coordinatList)
        {

            if (color != null)
            {

                if (shapeName == "triangle")
                {
                    selectedGrap.FillPolygon(new SolidBrush(itemColor), coordinatList);

                }
                else if (shapeName == "hexagon")
                {

                }
                else if (shapeName == "square")
                    selectedGrap.FillPolygon(new SolidBrush(itemColor), coordinatList);
                //else if(shapeName == "circle")
                //    selectedGrap.FillEllipse(new SolidBrush(defaultPen.Color),)
            }
            else
            {
                selectedGrap.FillRectangle(new SolidBrush(defaultPen.Color), X, Y, Width, Height);

            }
        }
        public void FillWithCoordinats(Graphics grap , int x , int y)
        {
            grap.FillRectangle(new SolidBrush(this.itemColor), x, y, this.Width, this.Height);
        }
       
        public int Y
        {
            //get => y;
            //set => y = value;
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get => x;
            set { x = value; }
        }
        public int Width
        {
            get =>  width;

            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Bottom => Y + Height;
        public int Right => X + Width;
        public int Top => Y;
        public int Left => X;
    }
}
