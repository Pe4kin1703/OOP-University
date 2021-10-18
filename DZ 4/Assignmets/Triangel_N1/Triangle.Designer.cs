
namespace Triangel_N1
{
    partial class TriangleForm
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
            this.aSideBox = new System.Windows.Forms.TextBox();
            this.bSideBox = new System.Windows.Forms.TextBox();
            this.cSideBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.CreateTriangleLabel = new System.Windows.Forms.Label();
            this.CreateTriangleButton = new System.Windows.Forms.Button();
            this.PerimemtrButton = new System.Windows.Forms.Button();
            this.PerimetrLabel = new System.Windows.Forms.Label();
            this.FindSquareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SquarLabel = new System.Windows.Forms.Label();
            this.A_AngleTextBox = new System.Windows.Forms.TextBox();
            this.B_AngleTextBox = new System.Windows.Forms.TextBox();
            this.C_AngleTextBox = new System.Windows.Forms.TextBox();
            this.CalculateAnglesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SideNameTextBox = new System.Windows.Forms.TextBox();
            this.SideNameLabel = new System.Windows.Forms.Label();
            this.NewSideValueTextBox = new System.Windows.Forms.TextBox();
            this.NewSideValueLabel = new System.Windows.Forms.Label();
            this.ChangeSideValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aSideBox
            // 
            this.aSideBox.Location = new System.Drawing.Point(47, 57);
            this.aSideBox.Name = "aSideBox";
            this.aSideBox.Size = new System.Drawing.Size(125, 27);
            this.aSideBox.TabIndex = 0;
            this.aSideBox.TextChanged += new System.EventHandler(this.aSideBox_TextChanged);
            // 
            // bSideBox
            // 
            this.bSideBox.Location = new System.Drawing.Point(47, 100);
            this.bSideBox.Name = "bSideBox";
            this.bSideBox.Size = new System.Drawing.Size(125, 27);
            this.bSideBox.TabIndex = 1;
            this.bSideBox.TextChanged += new System.EventHandler(this.bSideBox_TextChanged);
            // 
            // cSideBox
            // 
            this.cSideBox.Location = new System.Drawing.Point(47, 145);
            this.cSideBox.Name = "cSideBox";
            this.cSideBox.Size = new System.Drawing.Size(125, 27);
            this.cSideBox.TabIndex = 2;
            this.cSideBox.TextChanged += new System.EventHandler(this.cSideBoxe_TextChanged);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(13, 58);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(20, 20);
            this.aLabel.TabIndex = 3;
            this.aLabel.Text = "a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(12, 107);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(21, 20);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(13, 152);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(19, 20);
            this.cLabel.TabIndex = 5;
            this.cLabel.Text = "c:";
            // 
            // CreateTriangleLabel
            // 
            this.CreateTriangleLabel.AutoSize = true;
            this.CreateTriangleLabel.Location = new System.Drawing.Point(47, 34);
            this.CreateTriangleLabel.Name = "CreateTriangleLabel";
            this.CreateTriangleLabel.Size = new System.Drawing.Size(110, 20);
            this.CreateTriangleLabel.TabIndex = 6;
            this.CreateTriangleLabel.Text = "Create triangle:";
            // 
            // CreateTriangleButton
            // 
            this.CreateTriangleButton.Location = new System.Drawing.Point(35, 191);
            this.CreateTriangleButton.Name = "CreateTriangleButton";
            this.CreateTriangleButton.Size = new System.Drawing.Size(148, 29);
            this.CreateTriangleButton.TabIndex = 7;
            this.CreateTriangleButton.Text = "CreateTriangle";
            this.CreateTriangleButton.UseVisualStyleBackColor = true;
            this.CreateTriangleButton.Click += new System.EventHandler(this.CreateTriangleButton_Click);
            // 
            // PerimemtrButton
            // 
            this.PerimemtrButton.Location = new System.Drawing.Point(35, 306);
            this.PerimemtrButton.Name = "PerimemtrButton";
            this.PerimemtrButton.Size = new System.Drawing.Size(173, 29);
            this.PerimemtrButton.TabIndex = 8;
            this.PerimemtrButton.Text = "Find Perimetr";
            this.PerimemtrButton.UseVisualStyleBackColor = true;
            this.PerimemtrButton.Click += new System.EventHandler(this.PerimemtrButton_Click);
            // 
            // PerimetrLabel
            // 
            this.PerimetrLabel.AutoSize = true;
            this.PerimetrLabel.Location = new System.Drawing.Point(35, 347);
            this.PerimetrLabel.Name = "PerimetrLabel";
            this.PerimetrLabel.Size = new System.Drawing.Size(0, 20);
            this.PerimetrLabel.TabIndex = 9;
            // 
            // FindSquareButton
            // 
            this.FindSquareButton.Location = new System.Drawing.Point(266, 306);
            this.FindSquareButton.Name = "FindSquareButton";
            this.FindSquareButton.Size = new System.Drawing.Size(352, 29);
            this.FindSquareButton.TabIndex = 10;
            this.FindSquareButton.Text = "Find square (only for equilateral triangle)";
            this.FindSquareButton.UseVisualStyleBackColor = true;
            this.FindSquareButton.Click += new System.EventHandler(this.FindSquareButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 11;
            // 
            // SquarLabel
            // 
            this.SquarLabel.AutoSize = true;
            this.SquarLabel.Location = new System.Drawing.Point(266, 347);
            this.SquarLabel.Name = "SquarLabel";
            this.SquarLabel.Size = new System.Drawing.Size(0, 20);
            this.SquarLabel.TabIndex = 12;
            // 
            // A_AngleTextBox
            // 
            this.A_AngleTextBox.Location = new System.Drawing.Point(332, 58);
            this.A_AngleTextBox.Name = "A_AngleTextBox";
            this.A_AngleTextBox.Size = new System.Drawing.Size(125, 27);
            this.A_AngleTextBox.TabIndex = 13;
            this.A_AngleTextBox.TextChanged += new System.EventHandler(this.A_AngleTextBox_TextChanged);
            // 
            // B_AngleTextBox
            // 
            this.B_AngleTextBox.Location = new System.Drawing.Point(332, 107);
            this.B_AngleTextBox.Name = "B_AngleTextBox";
            this.B_AngleTextBox.Size = new System.Drawing.Size(125, 27);
            this.B_AngleTextBox.TabIndex = 14;
            // 
            // C_AngleTextBox
            // 
            this.C_AngleTextBox.Location = new System.Drawing.Point(332, 152);
            this.C_AngleTextBox.Name = "C_AngleTextBox";
            this.C_AngleTextBox.Size = new System.Drawing.Size(125, 27);
            this.C_AngleTextBox.TabIndex = 15;
            // 
            // CalculateAnglesButton
            // 
            this.CalculateAnglesButton.Location = new System.Drawing.Point(316, 191);
            this.CalculateAnglesButton.Name = "CalculateAnglesButton";
            this.CalculateAnglesButton.Size = new System.Drawing.Size(157, 28);
            this.CalculateAnglesButton.TabIndex = 16;
            this.CalculateAnglesButton.Text = "Calculate angles";
            this.CalculateAnglesButton.UseVisualStyleBackColor = true;
            this.CalculateAnglesButton.Click += new System.EventHandler(this.CalculateAnglesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "C:";
            // 
            // SideNameTextBox
            // 
            this.SideNameTextBox.Location = new System.Drawing.Point(670, 64);
            this.SideNameTextBox.Name = "SideNameTextBox";
            this.SideNameTextBox.Size = new System.Drawing.Size(130, 27);
            this.SideNameTextBox.TabIndex = 20;
            // 
            // SideNameLabel
            // 
            this.SideNameLabel.AutoSize = true;
            this.SideNameLabel.Location = new System.Drawing.Point(518, 71);
            this.SideNameLabel.Name = "SideNameLabel";
            this.SideNameLabel.Size = new System.Drawing.Size(146, 20);
            this.SideNameLabel.TabIndex = 21;
            this.SideNameLabel.Text = "Side name (a, b or c)";
            // 
            // NewSideValueTextBox
            // 
            this.NewSideValueTextBox.Location = new System.Drawing.Point(670, 107);
            this.NewSideValueTextBox.Name = "NewSideValueTextBox";
            this.NewSideValueTextBox.Size = new System.Drawing.Size(130, 27);
            this.NewSideValueTextBox.TabIndex = 22;
            // 
            // NewSideValueLabel
            // 
            this.NewSideValueLabel.AutoSize = true;
            this.NewSideValueLabel.Location = new System.Drawing.Point(586, 114);
            this.NewSideValueLabel.Name = "NewSideValueLabel";
            this.NewSideValueLabel.Size = new System.Drawing.Size(78, 20);
            this.NewSideValueLabel.TabIndex = 23;
            this.NewSideValueLabel.Text = "New value";
            // 
            // ChangeSideValueButton
            // 
            this.ChangeSideValueButton.Location = new System.Drawing.Point(671, 155);
            this.ChangeSideValueButton.Name = "ChangeSideValueButton";
            this.ChangeSideValueButton.Size = new System.Drawing.Size(129, 35);
            this.ChangeSideValueButton.TabIndex = 24;
            this.ChangeSideValueButton.Text = "Change";
            this.ChangeSideValueButton.UseVisualStyleBackColor = true;
            this.ChangeSideValueButton.Click += new System.EventHandler(this.ChangeSideValueButton_Click);
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 583);
            this.Controls.Add(this.ChangeSideValueButton);
            this.Controls.Add(this.NewSideValueLabel);
            this.Controls.Add(this.NewSideValueTextBox);
            this.Controls.Add(this.SideNameLabel);
            this.Controls.Add(this.SideNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateAnglesButton);
            this.Controls.Add(this.C_AngleTextBox);
            this.Controls.Add(this.B_AngleTextBox);
            this.Controls.Add(this.A_AngleTextBox);
            this.Controls.Add(this.SquarLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindSquareButton);
            this.Controls.Add(this.PerimetrLabel);
            this.Controls.Add(this.PerimemtrButton);
            this.Controls.Add(this.CreateTriangleButton);
            this.Controls.Add(this.CreateTriangleLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.cSideBox);
            this.Controls.Add(this.bSideBox);
            this.Controls.Add(this.aSideBox);
            this.Name = "TriangleForm";
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.Triangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aSideBox;
        private System.Windows.Forms.TextBox bSideBox;
        private System.Windows.Forms.TextBox cSideBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label CreateTriangleLabel;
        private System.Windows.Forms.Button CreateTriangleButton;
        private System.Windows.Forms.Button PerimemtrButton;
        private System.Windows.Forms.Label PerimetrLabel;
        private System.Windows.Forms.Button FindSquareButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SquarLabel;
        private System.Windows.Forms.TextBox A_AngleTextBox;
        private System.Windows.Forms.TextBox B_AngleTextBox;
        private System.Windows.Forms.TextBox C_AngleTextBox;
        private System.Windows.Forms.Button CalculateAnglesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SideNameTextBox;
        private System.Windows.Forms.Label SideNameLabel;
        private System.Windows.Forms.TextBox NewSideValueTextBox;
        private System.Windows.Forms.Label NewSideValueLabel;
        private System.Windows.Forms.Button ChangeSideValueButton;
    }
}

