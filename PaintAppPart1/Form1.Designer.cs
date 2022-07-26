namespace PaintAppPart1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.PaintPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1143, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 722);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.btnSaveFile);
            this.groupBox4.Controls.Add(this.btnOpenFile);
            this.groupBox4.Location = new System.Drawing.Point(6, 598);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 103);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya İşlemleri";
            // 
            // button17
            // 
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(152, 21);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(69, 69);
            this.button17.TabIndex = 0;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackgroundImage = global::PaintAppPart1.Properties.Resources.saveIcon;
            this.btnSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFile.Location = new System.Drawing.Point(81, 21);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(69, 69);
            this.btnSaveFile.TabIndex = 0;
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::PaintAppPart1.Properties.Resources.fileIcon;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Location = new System.Drawing.Point(6, 21);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 69);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPencil);
            this.groupBox3.Controls.Add(this.btnTrash);
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Location = new System.Drawing.Point(6, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 103);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şekil İşlemler";
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = global::PaintAppPart1.Properties.Resources.PencilIcon;
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPencil.Location = new System.Drawing.Point(152, 21);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(69, 69);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.BackgroundImage = global::PaintAppPart1.Properties.Resources.TrashPng;
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrash.Location = new System.Drawing.Point(81, 21);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(69, 69);
            this.btnTrash.TabIndex = 0;
            this.btnTrash.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::PaintAppPart1.Properties.Resources.cursor_icon;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Location = new System.Drawing.Point(6, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(69, 69);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWhite);
            this.groupBox2.Controls.Add(this.btnBrown);
            this.groupBox2.Controls.Add(this.btnYellow);
            this.groupBox2.Controls.Add(this.btnBlack);
            this.groupBox2.Controls.Add(this.btnPurple);
            this.groupBox2.Controls.Add(this.btnGreen);
            this.groupBox2.Controls.Add(this.btnOrange);
            this.groupBox2.Controls.Add(this.btnBlue);
            this.groupBox2.Controls.Add(this.btnRed);
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 252);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Seçimi";
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(161, 171);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(69, 69);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = false;
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.Location = new System.Drawing.Point(86, 171);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(69, 69);
            this.btnBrown.TabIndex = 0;
            this.btnBrown.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(161, 96);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(69, 69);
            this.btnYellow.TabIndex = 0;
            this.btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(86, 96);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(69, 69);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(11, 171);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(69, 69);
            this.btnPurple.TabIndex = 0;
            this.btnPurple.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(158, 21);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(69, 69);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(11, 96);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(69, 69);
            this.btnOrange.TabIndex = 0;
            this.btnOrange.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(83, 21);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(69, 69);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(8, 21);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(69, 69);
            this.btnRed.TabIndex = 0;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSquare);
            this.groupBox1.Controls.Add(this.btnCircle);
            this.groupBox1.Controls.Add(this.btnHexagon);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizim Şekli";
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = global::PaintAppPart1.Properties.Resources.Square_icon;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Location = new System.Drawing.Point(6, 21);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(109, 85);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = global::PaintAppPart1.Properties.Resources.Circle_icon;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Location = new System.Drawing.Point(121, 21);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(109, 85);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.BackgroundImage = global::PaintAppPart1.Properties.Resources.hexagon_icon;
            this.btnHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHexagon.Location = new System.Drawing.Point(121, 112);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(109, 85);
            this.btnHexagon.TabIndex = 0;
            this.btnHexagon.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackgroundImage = global::PaintAppPart1.Properties.Resources.Triangle_icon;
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangle.Location = new System.Drawing.Point(6, 112);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(109, 85);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // PaintPictureBox
            // 
            this.PaintPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PaintPictureBox.Name = "PaintPictureBox";
            this.PaintPictureBox.Size = new System.Drawing.Size(1137, 722);
            this.PaintPictureBox.TabIndex = 1;
            this.PaintPictureBox.TabStop = false;
            this.PaintPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPictureBox_Paint);
            this.PaintPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseDown);
            this.PaintPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseMove);
            this.PaintPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintPictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 722);
            this.Controls.Add(this.PaintPictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaintPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.PictureBox PaintPictureBox;
    }
}

