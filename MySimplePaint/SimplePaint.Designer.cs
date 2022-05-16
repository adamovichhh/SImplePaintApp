
namespace MySimplePaint
{
    partial class myPaintForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regularPolygonButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.brokenLineButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.paintingButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topsNumberLabel = new System.Windows.Forms.Label();
            this.topsNumberTrackBar = new System.Windows.Forms.TrackBar();
            this.penWidthLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.deserealizeButton = new System.Windows.Forms.Button();
            this.serealizeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.penColorButton = new System.Windows.Forms.Button();
            this.penWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.isFeelCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topsNumberTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(83, 3);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1076, 614);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.regularPolygonButton);
            this.panel1.Controls.Add(this.lineButton);
            this.panel1.Controls.Add(this.brokenLineButton);
            this.panel1.Controls.Add(this.polygonButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.ellipseButton);
            this.panel1.Controls.Add(this.paintingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 620);
            this.panel1.TabIndex = 10;
            // 
            // regularPolygonButton
            // 
            this.regularPolygonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regularPolygonButton.FlatAppearance.BorderSize = 0;
            this.regularPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularPolygonButton.Image = global::MySimplePaint.Properties.Resources.regularPolygonImg;
            this.regularPolygonButton.Location = new System.Drawing.Point(10, 550);
            this.regularPolygonButton.Margin = new System.Windows.Forms.Padding(0);
            this.regularPolygonButton.Name = "regularPolygonButton";
            this.regularPolygonButton.Size = new System.Drawing.Size(60, 60);
            this.regularPolygonButton.TabIndex = 6;
            this.regularPolygonButton.UseVisualStyleBackColor = true;
            this.regularPolygonButton.Click += new System.EventHandler(this.regularPolygonButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Image = global::MySimplePaint.Properties.Resources.lineImg;
            this.lineButton.Location = new System.Drawing.Point(10, 100);
            this.lineButton.Margin = new System.Windows.Forms.Padding(0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(60, 60);
            this.lineButton.TabIndex = 5;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // brokenLineButton
            // 
            this.brokenLineButton.FlatAppearance.BorderSize = 0;
            this.brokenLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brokenLineButton.Image = global::MySimplePaint.Properties.Resources.brokenLineImg;
            this.brokenLineButton.Location = new System.Drawing.Point(10, 190);
            this.brokenLineButton.Margin = new System.Windows.Forms.Padding(0);
            this.brokenLineButton.Name = "brokenLineButton";
            this.brokenLineButton.Size = new System.Drawing.Size(60, 60);
            this.brokenLineButton.TabIndex = 4;
            this.brokenLineButton.UseVisualStyleBackColor = true;
            this.brokenLineButton.Click += new System.EventHandler(this.brokenLineButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.FlatAppearance.BorderSize = 0;
            this.polygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygonButton.Image = global::MySimplePaint.Properties.Resources.polygonImg;
            this.polygonButton.Location = new System.Drawing.Point(10, 460);
            this.polygonButton.Margin = new System.Windows.Forms.Padding(0);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(60, 60);
            this.polygonButton.TabIndex = 3;
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Image = global::MySimplePaint.Properties.Resources.rectangleImg;
            this.rectangleButton.Location = new System.Drawing.Point(10, 370);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(60, 60);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.BackColor = System.Drawing.Color.White;
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ellipseButton.FlatAppearance.BorderSize = 0;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.ForeColor = System.Drawing.Color.Black;
            this.ellipseButton.Image = global::MySimplePaint.Properties.Resources.circleImg;
            this.ellipseButton.Location = new System.Drawing.Point(10, 280);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(60, 60);
            this.ellipseButton.TabIndex = 1;
            this.ellipseButton.UseVisualStyleBackColor = false;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // paintingButton
            // 
            this.paintingButton.FlatAppearance.BorderSize = 0;
            this.paintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paintingButton.Image = global::MySimplePaint.Properties.Resources.paintingImg;
            this.paintingButton.Location = new System.Drawing.Point(10, 10);
            this.paintingButton.Margin = new System.Windows.Forms.Padding(0);
            this.paintingButton.Name = "paintingButton";
            this.paintingButton.Size = new System.Drawing.Size(60, 60);
            this.paintingButton.TabIndex = 0;
            this.paintingButton.UseVisualStyleBackColor = true;
            this.paintingButton.Click += new System.EventHandler(this.paintingButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.topsNumberLabel);
            this.panel2.Controls.Add(this.topsNumberTrackBar);
            this.panel2.Controls.Add(this.penWidthLabel);
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.removeButton);
            this.panel2.Controls.Add(this.brushColorButton);
            this.panel2.Controls.Add(this.deserealizeButton);
            this.panel2.Controls.Add(this.serealizeButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.penColorButton);
            this.panel2.Controls.Add(this.penWidthTrackBar);
            this.panel2.Controls.Add(this.isFeelCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 620);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(76, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Brush";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(20, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(40, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Colors";
            // 
            // topsNumberLabel
            // 
            this.topsNumberLabel.AutoSize = true;
            this.topsNumberLabel.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topsNumberLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.topsNumberLabel.Location = new System.Drawing.Point(2, 181);
            this.topsNumberLabel.Name = "topsNumberLabel";
            this.topsNumberLabel.Size = new System.Drawing.Size(130, 17);
            this.topsNumberLabel.TabIndex = 17;
            this.topsNumberLabel.Text = "Tops number : 3";
            // 
            // topsNumberTrackBar
            // 
            this.topsNumberTrackBar.Enabled = false;
            this.topsNumberTrackBar.LargeChange = 1;
            this.topsNumberTrackBar.Location = new System.Drawing.Point(8, 146);
            this.topsNumberTrackBar.Maximum = 20;
            this.topsNumberTrackBar.Minimum = 3;
            this.topsNumberTrackBar.Name = "topsNumberTrackBar";
            this.topsNumberTrackBar.Size = new System.Drawing.Size(122, 56);
            this.topsNumberTrackBar.TabIndex = 16;
            this.topsNumberTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.topsNumberTrackBar.Value = 3;
            this.topsNumberTrackBar.Scroll += new System.EventHandler(this.topsNumberTrackBar_Scroll);
            // 
            // penWidthLabel
            // 
            this.penWidthLabel.AutoSize = true;
            this.penWidthLabel.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.penWidthLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.penWidthLabel.Location = new System.Drawing.Point(15, 105);
            this.penWidthLabel.Name = "penWidthLabel";
            this.penWidthLabel.Size = new System.Drawing.Size(109, 17);
            this.penWidthLabel.TabIndex = 15;
            this.penWidthLabel.Text = "Pen width : 3";
            // 
            // returnButton
            // 
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Image = global::MySimplePaint.Properties.Resources.returnImg;
            this.returnButton.Location = new System.Drawing.Point(73, 370);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(60, 60);
            this.returnButton.TabIndex = 14;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::MySimplePaint.Properties.Resources.removeImg;
            this.removeButton.Location = new System.Drawing.Point(7, 370);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(60, 60);
            this.removeButton.TabIndex = 13;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // brushColorButton
            // 
            this.brushColorButton.BackColor = System.Drawing.Color.White;
            this.brushColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushColorButton.ForeColor = System.Drawing.Color.Black;
            this.brushColorButton.Location = new System.Drawing.Point(77, 265);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(50, 50);
            this.brushColorButton.TabIndex = 10;
            this.brushColorButton.UseVisualStyleBackColor = false;
            this.brushColorButton.Click += new System.EventHandler(this.brushColorButton_Click);
            // 
            // deserealizeButton
            // 
            this.deserealizeButton.FlatAppearance.BorderSize = 0;
            this.deserealizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deserealizeButton.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deserealizeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.deserealizeButton.Location = new System.Drawing.Point(8, 555);
            this.deserealizeButton.Name = "deserealizeButton";
            this.deserealizeButton.Size = new System.Drawing.Size(124, 34);
            this.deserealizeButton.TabIndex = 9;
            this.deserealizeButton.Text = "Deserealize";
            this.deserealizeButton.UseVisualStyleBackColor = true;
            this.deserealizeButton.Click += new System.EventHandler(this.deserealizeButton_Click);
            // 
            // serealizeButton
            // 
            this.serealizeButton.FlatAppearance.BorderSize = 0;
            this.serealizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serealizeButton.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serealizeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.serealizeButton.Location = new System.Drawing.Point(8, 515);
            this.serealizeButton.Name = "serealizeButton";
            this.serealizeButton.Size = new System.Drawing.Size(124, 34);
            this.serealizeButton.TabIndex = 6;
            this.serealizeButton.Text = "Serealize";
            this.serealizeButton.UseVisualStyleBackColor = true;
            this.serealizeButton.Click += new System.EventHandler(this.serealizeButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MySimplePaint.Properties.Resources.clearImg;
            this.button2.Location = new System.Drawing.Point(40, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // penColorButton
            // 
            this.penColorButton.BackColor = System.Drawing.Color.Black;
            this.penColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penColorButton.Location = new System.Drawing.Point(13, 265);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(50, 50);
            this.penColorButton.TabIndex = 3;
            this.penColorButton.UseVisualStyleBackColor = false;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // penWidthTrackBar
            // 
            this.penWidthTrackBar.LargeChange = 1;
            this.penWidthTrackBar.Location = new System.Drawing.Point(9, 70);
            this.penWidthTrackBar.Maximum = 20;
            this.penWidthTrackBar.Minimum = 1;
            this.penWidthTrackBar.Name = "penWidthTrackBar";
            this.penWidthTrackBar.Size = new System.Drawing.Size(122, 56);
            this.penWidthTrackBar.TabIndex = 1;
            this.penWidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.penWidthTrackBar.Value = 3;
            this.penWidthTrackBar.Scroll += new System.EventHandler(this.penWidthTrackBar_Scroll);
            // 
            // isFeelCheckBox
            // 
            this.isFeelCheckBox.AutoSize = true;
            this.isFeelCheckBox.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isFeelCheckBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.isFeelCheckBox.Location = new System.Drawing.Point(20, 25);
            this.isFeelCheckBox.Name = "isFeelCheckBox";
            this.isFeelCheckBox.Size = new System.Drawing.Size(100, 25);
            this.isFeelCheckBox.TabIndex = 0;
            this.isFeelCheckBox.Text = "is Feel?";
            this.isFeelCheckBox.UseVisualStyleBackColor = true;
            this.isFeelCheckBox.CheckedChanged += new System.EventHandler(this.isFeelChechBox_CheckedChanged);
            // 
            // myPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1302, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "myPaintForm";
            this.Text = "SimlePaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topsNumberTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button brokenLineButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button paintingButton;
        private System.Windows.Forms.Button regularPolygonButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deserealizeButton;
        private System.Windows.Forms.Button serealizeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.TrackBar penWidthTrackBar;
        private System.Windows.Forms.CheckBox isFeelCheckBox;
        private System.Windows.Forms.Button brushColorButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label penWidthLabel;
        private System.Windows.Forms.Label topsNumberLabel;
        private System.Windows.Forms.TrackBar topsNumberTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

