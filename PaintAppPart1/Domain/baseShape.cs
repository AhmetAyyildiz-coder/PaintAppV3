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
            selectedGrap.DrawRectangle(defaultPen, this.X-20,this.Y-20 , width+40 , height+40 );
        }

        public void Fill(Graphics selectedGrap , Color? color)
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
