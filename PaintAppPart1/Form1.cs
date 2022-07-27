using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PaintAppPart1.Domain;

namespace PaintAppPart1
{
    public partial class Form1 : Form
    {
        #region variables

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
        /// bir işlem seçildiğinde bu enum kullanılmaı
        /// diğer işlemler false olmalı.
        /// </summary>
        enum selectedShapeOperation
        {
            cursor,
            trash,
            pencil
        }
        private string selectedOperation = string.Empty;
        enum selectedShape
        {
            square,
            circle,
            triangle,
            hexagon
        }
        private string selectedShapeName = string.Empty;

        
        //for draw for draw rectangle
        /// <summary>
        ///  draw rectangle for parameters
        /// </summary>
        int MoveX, MoveY,sizeX,sizeY,startPositionX, startPositionY;

        bool IsSelectShape= false;

        private List<baseShape> allShape;
        private baseShape selectedBaseShape;
        #endregion

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

            allShape = new List<baseShape>();


        }
        private void PaintPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (isPaint)
            {
                if (selectedOperation != selectedShapeOperation.pencil.ToString())
                {
                    switch (selectedShapeName)
                    {
                        case "circle":
                            baseShape shapeCircle = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                            shapeCircle.FillCircle(graphics, startPositionX, startPositionY, sizeX, sizeY);
                            break;
                        case "square":
                            Point[] squarePoints = new Point[]
                            {
                        new Point(startPositionX, startPositionY),
                        new Point(startPositionX+sizeX,startPositionY),
                        new Point(startPositionX+sizeX , startPositionY+sizeY),
                        new Point(startPositionX , startPositionY+sizeY)
                            };
                            baseShape _shape = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                            _shape.Fill(graphics, defaultPen.Color, "square", squarePoints);
                            break;
                        case "triangle":
                            Point[] mypoints = new Point[]
                            {
                        new Point(startPositionX+sizeX/2 ,startPositionY ),
                        new Point(startPositionX+sizeX,startPositionY+sizeY),
                        new Point(startPositionX,startPositionY+sizeY),
                        new Point(startPositionX+sizeX/2 ,startPositionY)
                            };
                            baseShape _shape2 = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                            _shape2.Fill(graphics, defaultPen.Color, "triangle", mypoints);

                            break;

                        case "hexagon":
                            baseShape shapeHexagon = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                            shapeHexagon.FillHexagon(graphics, startPositionX, startPositionY, sizeY);
                            break;
                        default:
                            break;
                    }
                }   
                    
                
                

            }
        }

       

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectedOperation = selectedShapeOperation.cursor.ToString();
            selectedShapeName = String.Empty;
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (selectedOperation == "cursor")
            {
                if (selectedBaseShape != null)
                {
                    selectedBaseShape.removeDraw(graphics);
                    allShape.Remove(selectedBaseShape);
                }
                
            }
            else
            {
                graphics.Clear(Color.White);
              
            }
            
            selectedOperation = selectedShapeOperation.trash.ToString();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.DefaultExt = "txt";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = JsonConvert.SerializeObject(allShape);
                File.WriteAllText(dialog.FileName,data);
                MessageBox.Show("Data kaydetme başarılı");
            }
        }

        

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                var data = File.ReadAllText(openFileDialog.FileName);
                var listData = JsonConvert.DeserializeObject<List<baseShape>>(data);
                if (listData.Count != 0)
                {
                    allShape.AddRange(listData);
                    foreach (var item in listData)
                    {
                        item.Fill(graphics, item.itemColor);
                    }
                }

            }
        }

        #region set color 
        private void btnRed_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null&& selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            defaultPen.Color = ((Button)sender).BackColor;
            if (selectedBaseShape != null && selectedOperation == "cursor")
            {
                selectedBaseShape.Fill(graphics, defaultPen.Color);
                selectedBaseShape.itemColor = defaultPen.Color;

            }
        }
        #endregion


        #region Shape Buttons Click
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            selectedShapeName = selectedShape.triangle.ToString();
            selectedOperation = String.Empty;

           
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            selectedShapeName = selectedShape.hexagon.ToString();
            selectedOperation = String.Empty;
        }

      

        private void btnCircle_Click(object sender, EventArgs e)
        {
            selectedShapeName = selectedShape.circle.ToString();
            selectedOperation = String.Empty;
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            selectedShapeName = selectedShape.square.ToString();
            selectedOperation = String.Empty;
        }
        #endregion
        
        private void btnPencil_Click(object sender, EventArgs e)
        {
            if (selectedOperation == "pencil")
            {
                selectedOperation = String.Empty;
            }
            else
            {
                selectedOperation = selectedShapeOperation.pencil.ToString();

            }
        }


        private void PaintPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedOperation == "cursor")
            {
                selectedBaseShape = allShape.FirstOrDefault(i => i.isInside(e.X, e.Y));

                //eğer seçilen yerde bir nesne varsa ;
                if (selectedBaseShape != null)
                {
                    // MessageBox.Show("Test");

                    var isSelectedItems = allShape.FindAll(i => i.isSelected == true);
                    if (isSelectedItems.Count == 0)
                    {
                        selectedBaseShape.isSelected = true;
                        graphics.FillRectangle(new SolidBrush(Color.FromArgb(140, Color.Red)), selectedBaseShape.X - 10, selectedBaseShape.Y - 10, selectedBaseShape.Width + 20, selectedBaseShape.Height + 20);
                        IsSelectShape = true;
                    }
                    else
                    {
                        //ilk olarak - önceki seçilmiş olan nesnemizi devre dışı bırakalım
                        foreach (var itemShape in isSelectedItems)
                        {
                            graphics.FillRectangle(new SolidBrush(Color.White), itemShape.X - 20, itemShape.Y - 20, itemShape.Width + 40, itemShape.Height + 40);
                            Thread.Sleep(100);
                            //itemShape.Fill(graphics, itemShape.itemColor);
                            //itemShape.Fill(graphics, defaultPen.Color ,) ??
                            //var b = itemShape;
                            //var c = 20;
                        }

                        //ardından yeni nesnemizi seçelim.
                        selectedBaseShape.isSelected = true;
                        graphics.FillRectangle(new SolidBrush(Color.FromArgb(140, Color.Red)), selectedBaseShape.X - 10, selectedBaseShape.Y - 10, selectedBaseShape.Width + 20, selectedBaseShape.Height + 20);
                        IsSelectShape = true;
                    }


                }


            }

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
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
            if (isPaint)
            {
                if (selectedOperation == "pencil")
                {//kullanıcımız kalem seçmiş demektir.
                    IsSelectShape = false;
                    pointX = e.Location;
                    graphics.DrawLine(defaultPen, pointY, pointX);

                    pointY = pointX;
                }
                else if (IsSelectShape == true)
                {
                    if (selectedBaseShape != null)
                    {
                        selectedBaseShape.removeDraw(graphics);
                        //graphics.FillRectangle(new SolidBrush(selectedBaseShape.itemColor) ,e.X, e.Y, selectedBaseShape.Width , selectedBaseShape.Height);

                        selectedBaseShape.FillWithCoordinats(graphics, e.X, e.Y);
                        
                    }
                    
                   
                    Refresh();
                     
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

            if (selectedOperation != selectedShapeOperation.pencil.ToString())
            {
                switch (selectedShapeName)
                {

                    case "circle":
                        baseShape shapeCircle = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                        shapeCircle.FillCircle(graphics, startPositionX, startPositionY, sizeX, sizeY);
                        allShape.Add(shapeCircle);
                        break;
                    case "square":
                        Point[] squarePoints = new Point[]
                        {
                        new Point(startPositionX, startPositionY),
                        new Point(startPositionX+sizeX,startPositionY),
                        new Point(startPositionX+sizeX , startPositionY+sizeY),
                        new Point(startPositionX , startPositionY+sizeY)
                        };
                        baseShape _shape = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                        _shape.Fill(graphics, defaultPen.Color, "square", squarePoints);
                        allShape.Add(_shape);
                        break;

                    case "triangle":
                        Point[] mypoints = new Point[]
                        {
                        new Point(startPositionX+sizeX/2 ,startPositionY ),
                        new Point(e.X,e.Y),
                        new Point(e.X-sizeX,e.Y),
                        new Point(startPositionX+sizeX/2 ,startPositionY)
                        };
                        baseShape _shape2 = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                        _shape2.Fill(graphics, defaultPen.Color, "triangle", mypoints);
                        allShape.Add(_shape2);

                        break;
                    case "hexagon":
                        baseShape shapeHexagon = new baseShape(defaultPen.Color, startPositionX, startPositionY, sizeX, sizeY);
                        shapeHexagon.FillHexagon(graphics, startPositionX, startPositionY, sizeY);
                        allShape.Add(shapeHexagon);
                        break;
                    default:
                        break;
                }
            }
            

        }

       

        

        
    }
}
