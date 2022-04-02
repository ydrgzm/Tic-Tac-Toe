
namespace TicTacToe
{
    partial class MainForm
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
            this.playControl = new MaterialSkin.Controls.MaterialTabControl();
            this.startPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new MaterialSkin.Controls.MaterialButton();
            this.highScoreBtn = new MaterialSkin.Controls.MaterialButton();
            this.playBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.playPage = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.cell22 = new System.Windows.Forms.PictureBox();
            this.cell21 = new System.Windows.Forms.PictureBox();
            this.cell12 = new System.Windows.Forms.PictureBox();
            this.cell20 = new System.Windows.Forms.PictureBox();
            this.cell11 = new System.Windows.Forms.PictureBox();
            this.cell10 = new System.Windows.Forms.PictureBox();
            this.cell02 = new System.Windows.Forms.PictureBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cell01 = new System.Windows.Forms.PictureBox();
            this.cell00 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.p1Lbl = new System.Windows.Forms.Panel();
            this.p2Lbl = new System.Windows.Forms.Panel();
            this.playControl.SuspendLayout();
            this.startPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.playPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cell22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playControl
            // 
            this.playControl.Controls.Add(this.startPage);
            this.playControl.Controls.Add(this.playPage);
            this.playControl.Depth = 0;
            this.playControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playControl.Location = new System.Drawing.Point(3, 64);
            this.playControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.playControl.Multiline = true;
            this.playControl.Name = "playControl";
            this.playControl.SelectedIndex = 0;
            this.playControl.Size = new System.Drawing.Size(356, 431);
            this.playControl.TabIndex = 0;
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.panel1);
            this.startPage.Location = new System.Drawing.Point(4, 22);
            this.startPage.Name = "startPage";
            this.startPage.Padding = new System.Windows.Forms.Padding(3);
            this.startPage.Size = new System.Drawing.Size(348, 405);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Start Page";
            this.startPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.highScoreBtn);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 399);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.Location = new System.Drawing.Point(344, 371);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 17);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Version 1.0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.icons8_tic_tac_toe_80px;
            this.pictureBox1.Location = new System.Drawing.Point(93, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitBtn.Depth = 0;
            this.exitBtn.HighEmphasis = true;
            this.exitBtn.Icon = null;
            this.exitBtn.Location = new System.Drawing.Point(146, 269);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitBtn.Size = new System.Drawing.Size(64, 36);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitBtn.UseAccentColor = false;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // highScoreBtn
            // 
            this.highScoreBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.highScoreBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.highScoreBtn.Depth = 0;
            this.highScoreBtn.HighEmphasis = true;
            this.highScoreBtn.Icon = null;
            this.highScoreBtn.Location = new System.Drawing.Point(125, 221);
            this.highScoreBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.highScoreBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.highScoreBtn.Name = "highScoreBtn";
            this.highScoreBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.highScoreBtn.Size = new System.Drawing.Size(107, 36);
            this.highScoreBtn.TabIndex = 1;
            this.highScoreBtn.Text = "High Score";
            this.highScoreBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.highScoreBtn.UseAccentColor = false;
            this.highScoreBtn.UseVisualStyleBackColor = true;
            this.highScoreBtn.Click += new System.EventHandler(this.highScoreBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.playBtn.Depth = 0;
            this.playBtn.HighEmphasis = true;
            this.playBtn.Icon = null;
            this.playBtn.Location = new System.Drawing.Point(146, 173);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.playBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.playBtn.Name = "playBtn";
            this.playBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.playBtn.Size = new System.Drawing.Size(64, 36);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.playBtn.UseAccentColor = false;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(13, 371);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 17);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Welcome Back";
            // 
            // playPage
            // 
            this.playPage.Controls.Add(this.p2Lbl);
            this.playPage.Controls.Add(this.p1Lbl);
            this.playPage.Controls.Add(this.materialLabel6);
            this.playPage.Controls.Add(this.materialLabel5);
            this.playPage.Controls.Add(this.materialButton1);
            this.playPage.Controls.Add(this.panel2);
            this.playPage.Controls.Add(this.pictureBox3);
            this.playPage.Controls.Add(this.pictureBox2);
            this.playPage.Controls.Add(this.materialLabel3);
            this.playPage.Controls.Add(this.materialLabel2);
            this.playPage.Location = new System.Drawing.Point(4, 22);
            this.playPage.Name = "playPage";
            this.playPage.Padding = new System.Windows.Forms.Padding(3);
            this.playPage.Size = new System.Drawing.Size(348, 405);
            this.playPage.TabIndex = 1;
            this.playPage.Text = "Play Page";
            this.playPage.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(266, 355);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Back";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.materialDivider4);
            this.panel2.Controls.Add(this.materialDivider3);
            this.panel2.Controls.Add(this.materialDivider2);
            this.panel2.Controls.Add(this.cell22);
            this.panel2.Controls.Add(this.cell21);
            this.panel2.Controls.Add(this.cell12);
            this.panel2.Controls.Add(this.cell20);
            this.panel2.Controls.Add(this.cell11);
            this.panel2.Controls.Add(this.cell10);
            this.panel2.Controls.Add(this.cell02);
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.cell01);
            this.panel2.Controls.Add(this.cell00);
            this.panel2.Location = new System.Drawing.Point(18, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 269);
            this.panel2.TabIndex = 3;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(204, 4);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(15, 259);
            this.materialDivider4.TabIndex = 4;
            this.materialDivider4.Text = "materialDivider3";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(93, 5);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(15, 259);
            this.materialDivider3.TabIndex = 4;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(3, 174);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(306, 14);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // cell22
            // 
            this.cell22.Location = new System.Drawing.Point(224, 193);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(84, 70);
            this.cell22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell22.TabIndex = 2;
            this.cell22.TabStop = false;
            this.cell22.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell21
            // 
            this.cell21.Location = new System.Drawing.Point(114, 193);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(84, 70);
            this.cell21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell21.TabIndex = 2;
            this.cell21.TabStop = false;
            this.cell21.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell12
            // 
            this.cell12.Location = new System.Drawing.Point(224, 97);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(84, 70);
            this.cell12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell12.TabIndex = 2;
            this.cell12.TabStop = false;
            this.cell12.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell20
            // 
            this.cell20.Location = new System.Drawing.Point(3, 194);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(84, 70);
            this.cell20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell20.TabIndex = 2;
            this.cell20.TabStop = false;
            this.cell20.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell11
            // 
            this.cell11.Location = new System.Drawing.Point(114, 97);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(84, 70);
            this.cell11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell11.TabIndex = 2;
            this.cell11.TabStop = false;
            this.cell11.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell10
            // 
            this.cell10.Location = new System.Drawing.Point(3, 98);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(84, 70);
            this.cell10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell10.TabIndex = 2;
            this.cell10.TabStop = false;
            this.cell10.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell02
            // 
            this.cell02.Location = new System.Drawing.Point(224, 4);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(84, 70);
            this.cell02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell02.TabIndex = 2;
            this.cell02.TabStop = false;
            this.cell02.Click += new System.EventHandler(this.cell1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(3, 79);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(306, 14);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cell01
            // 
            this.cell01.Location = new System.Drawing.Point(114, 4);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(84, 70);
            this.cell01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell01.TabIndex = 2;
            this.cell01.TabStop = false;
            this.cell01.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell00
            // 
            this.cell00.Location = new System.Drawing.Point(3, 5);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(84, 70);
            this.cell00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cell00.TabIndex = 2;
            this.cell00.TabStop = false;
            this.cell00.Click += new System.EventHandler(this.cell1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TicTacToe.Properties.Resources.icons8_cross_mark_72px;
            this.pictureBox3.Location = new System.Drawing.Point(292, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.icons8_circle_72px;
            this.pictureBox2.Location = new System.Drawing.Point(111, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(188, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 29);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Player 2: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(7, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 29);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Player 1: ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(18, 343);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(58, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Player 1";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 371);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(58, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Player 2";
            // 
            // p1Lbl
            // 
            this.p1Lbl.BackColor = System.Drawing.Color.Green;
            this.p1Lbl.Location = new System.Drawing.Point(87, 343);
            this.p1Lbl.Name = "p1Lbl";
            this.p1Lbl.Size = new System.Drawing.Size(18, 19);
            this.p1Lbl.TabIndex = 6;
            // 
            // p2Lbl
            // 
            this.p2Lbl.BackColor = System.Drawing.Color.White;
            this.p2Lbl.Location = new System.Drawing.Point(88, 371);
            this.p2Lbl.Name = "p2Lbl";
            this.p2Lbl.Size = new System.Drawing.Size(17, 19);
            this.p2Lbl.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 498);
            this.Controls.Add(this.playControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.playControl.ResumeLayout(false);
            this.startPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.playPage.ResumeLayout(false);
            this.playPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cell22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl playControl;
        private System.Windows.Forms.TabPage startPage;
        private System.Windows.Forms.TabPage playPage;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton exitBtn;
        private MaterialSkin.Controls.MaterialButton highScoreBtn;
        private MaterialSkin.Controls.MaterialButton playBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.PictureBox cell22;
        private System.Windows.Forms.PictureBox cell21;
        private System.Windows.Forms.PictureBox cell12;
        private System.Windows.Forms.PictureBox cell20;
        private System.Windows.Forms.PictureBox cell11;
        private System.Windows.Forms.PictureBox cell10;
        private System.Windows.Forms.PictureBox cell02;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox cell01;
        private System.Windows.Forms.PictureBox cell00;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel p2Lbl;
        private System.Windows.Forms.Panel p1Lbl;
    }
}

