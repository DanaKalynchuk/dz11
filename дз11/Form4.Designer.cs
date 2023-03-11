
namespace дз11
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Color1 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.Wigh = new System.Windows.Forms.TrackBar();
            this.Start = new System.Windows.Forms.ComboBox();
            this.End = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiferentLine = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gradient = new System.Windows.Forms.RadioButton();
            this.Hatch = new System.Windows.Forms.RadioButton();
            this.Solid = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wigh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Checked = true;
            this.Line.Location = new System.Drawing.Point(6, 26);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 24);
            this.Line.TabIndex = 1;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(69, 26);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(73, 24);
            this.Ellipse.TabIndex = 2;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(148, 26);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(96, 24);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.Rectangle);
            this.groupBox1.Controls.Add(this.Ellipse);
            this.groupBox1.Location = new System.Drawing.Point(470, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(732, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "BeckColor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(905, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "ForeColor";
            // 
            // Color1
            // 
            this.Color1.Location = new System.Drawing.Point(853, 19);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(46, 42);
            this.Color1.TabIndex = 7;
            this.Color1.UseVisualStyleBackColor = true;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color2
            // 
            this.Color2.Location = new System.Drawing.Point(1023, 23);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(46, 42);
            this.Color2.TabIndex = 8;
            this.Color2.UseVisualStyleBackColor = true;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // Wigh
            // 
            this.Wigh.Location = new System.Drawing.Point(614, 80);
            this.Wigh.Maximum = 20;
            this.Wigh.Minimum = 1;
            this.Wigh.Name = "Wigh";
            this.Wigh.Size = new System.Drawing.Size(219, 56);
            this.Wigh.TabIndex = 9;
            this.Wigh.Value = 1;
            this.Wigh.Scroll += new System.EventHandler(this.Wigh_Scroll);
            // 
            // Start
            // 
            this.Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Start.FormattingEnabled = true;
            this.Start.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Arrow Anchor"});
            this.Start.Location = new System.Drawing.Point(476, 180);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(205, 28);
            this.Start.TabIndex = 10;
            this.Start.SelectedIndexChanged += new System.EventHandler(this.Start_SelectedIndexChanged);
            // 
            // End
            // 
            this.End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.End.FormattingEnabled = true;
            this.End.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Arrow Anchor"});
            this.End.Location = new System.Drawing.Point(710, 180);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(189, 28);
            this.End.TabIndex = 11;
            this.End.SelectedIndexChanged += new System.EventHandler(this.End_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(476, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(710, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "End line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(470, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Width line";
            // 
            // DiferentLine
            // 
            this.DiferentLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiferentLine.FormattingEnabled = true;
            this.DiferentLine.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash-Dot",
            "Dash-Dot-Dot"});
            this.DiferentLine.Location = new System.Drawing.Point(918, 80);
            this.DiferentLine.Name = "DiferentLine";
            this.DiferentLine.Size = new System.Drawing.Size(151, 28);
            this.DiferentLine.TabIndex = 15;
            this.DiferentLine.SelectedIndexChanged += new System.EventHandler(this.DiferentLine_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gradient);
            this.groupBox2.Controls.Add(this.Hatch);
            this.groupBox2.Controls.Add(this.Solid);
            this.groupBox2.Location = new System.Drawing.Point(476, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush";
            // 
            // Gradient
            // 
            this.Gradient.AutoSize = true;
            this.Gradient.Location = new System.Drawing.Point(76, 26);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(87, 24);
            this.Gradient.TabIndex = 2;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            this.Gradient.CheckedChanged += new System.EventHandler(this.Gradient_CheckedChanged);
            // 
            // Hatch
            // 
            this.Hatch.AutoSize = true;
            this.Hatch.Location = new System.Drawing.Point(302, 26);
            this.Hatch.Name = "Hatch";
            this.Hatch.Size = new System.Drawing.Size(69, 24);
            this.Hatch.TabIndex = 1;
            this.Hatch.Text = "Hatch";
            this.Hatch.UseVisualStyleBackColor = true;
            this.Hatch.CheckedChanged += new System.EventHandler(this.Hatch_CheckedChanged);
            // 
            // Solid
            // 
            this.Solid.AutoSize = true;
            this.Solid.Location = new System.Drawing.Point(6, 26);
            this.Solid.Name = "Solid";
            this.Solid.Size = new System.Drawing.Size(64, 24);
            this.Solid.TabIndex = 0;
            this.Solid.Text = "Solid";
            this.Solid.UseVisualStyleBackColor = true;
            this.Solid.CheckedChanged += new System.EventHandler(this.Solid_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(476, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 45);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(722, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 45);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "ForwardDiagonal",
            "BackwardDiagonal"});
            this.comboBox1.Location = new System.Drawing.Point(552, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical ",
            "ForwardDiagonal",
            "BackwardDiagonal ",
            "Cross",
            "DiagonalCross ",
            "Percent05",
            "Percent10",
            "Percent20 ",
            "Percent25 ",
            "Percent30 ",
            "Percent40 ",
            "Percent50",
            "Percent60 ",
            "Percent70 ",
            "Percent75 ",
            "Percent80 ",
            "Percent90 ",
            "LightDownwardDiagonal ",
            "LightUpwardDiagonal ",
            "DarkDownwardDiagonal ",
            "DarkUpwardDiagonal ",
            "WideDownwardDiagonal ",
            "WideUpwardDiagonal ",
            "LightVertical ",
            "LightHorizontal ",
            "NarrowVertical ",
            "NarrowHorizontal ",
            "DarkVertical ",
            "DarkHorizontal ",
            "DashedDownwardDiagonal ",
            "DashedUpwardDiagonal ",
            "DashedHorizontal ",
            "DashedVertical ",
            "SmallConfetti ",
            "LargeConfetti ",
            "ZigZag ",
            "Wave",
            "DiagonalBrick ",
            "HorizontalBrick ",
            "Weave ",
            "Plaid ",
            "Divot ",
            "DottedGrid",
            "DottedDiamond",
            "Shingle ",
            "Trellis ",
            "Sphere",
            "SmallGrid",
            "SmallCheckerBoard ",
            "LargeCheckerBoard ",
            "OutlinedDiamond",
            "SolidDiamond "});
            this.comboBox2.Location = new System.Drawing.Point(806, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 42);
            this.button3.TabIndex = 21;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DiferentLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Wigh);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wigh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button Color2;
        private System.Windows.Forms.TrackBar Wigh;
        private System.Windows.Forms.ComboBox Start;
        private System.Windows.Forms.ComboBox End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DiferentLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Gradient;
        private System.Windows.Forms.RadioButton Hatch;
        private System.Windows.Forms.RadioButton Solid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
    }
}