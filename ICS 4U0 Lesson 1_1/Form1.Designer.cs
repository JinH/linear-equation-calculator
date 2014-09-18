namespace ICS_4U0_Lesson_1_1
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
            this.components = new System.ComponentModel.Container();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.txtPoint1x = new System.Windows.Forms.TextBox();
            this.txtPoint1y = new System.Windows.Forms.TextBox();
            this.txtPoint2x = new System.Windows.Forms.TextBox();
            this.txtPoint2y = new System.Windows.Forms.TextBox();
            this.lblMisc2 = new System.Windows.Forms.Label();
            this.lblMisc1 = new System.Windows.Forms.Label();
            this.lblMisc3 = new System.Windows.Forms.Label();
            this.lblMisc4 = new System.Windows.Forms.Label();
            this.lblMisc6 = new System.Windows.Forms.Label();
            this.lblMisc5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLinearEquation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLineLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ttPoint1x = new System.Windows.Forms.ToolTip(this.components);
            this.ttPoint1y = new System.Windows.Forms.ToolTip(this.components);
            this.ttPoint2x = new System.Windows.Forms.ToolTip(this.components);
            this.ttPoint2y = new System.Windows.Forms.ToolTip(this.components);
            this.ttCalculate = new System.Windows.Forms.ToolTip(this.components);
            this.ttClear = new System.Windows.Forms.ToolTip(this.components);
            this.rttLinear = new System.Windows.Forms.RichTextBox();
            this.rttMidpoint = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Location = new System.Drawing.Point(38, 52);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(43, 13);
            this.lblPoint1.TabIndex = 0;
            this.lblPoint1.Text = "Point 1 ";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Location = new System.Drawing.Point(38, 97);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(43, 13);
            this.lblPoint2.TabIndex = 1;
            this.lblPoint2.Text = "Point 2 ";
            // 
            // txtPoint1x
            // 
            this.txtPoint1x.Location = new System.Drawing.Point(182, 45);
            this.txtPoint1x.Name = "txtPoint1x";
            this.txtPoint1x.Size = new System.Drawing.Size(48, 20);
            this.txtPoint1x.TabIndex = 0;
            this.ttPoint1x.SetToolTip(this.txtPoint1x, "Enter the x value of the first point.");
            // 
            // txtPoint1y
            // 
            this.txtPoint1y.Location = new System.Drawing.Point(252, 45);
            this.txtPoint1y.Name = "txtPoint1y";
            this.txtPoint1y.Size = new System.Drawing.Size(48, 20);
            this.txtPoint1y.TabIndex = 1;
            this.ttPoint1y.SetToolTip(this.txtPoint1y, "Enter the y value of the first point.");
            // 
            // txtPoint2x
            // 
            this.txtPoint2x.Location = new System.Drawing.Point(182, 90);
            this.txtPoint2x.Name = "txtPoint2x";
            this.txtPoint2x.Size = new System.Drawing.Size(48, 20);
            this.txtPoint2x.TabIndex = 2;
            this.ttPoint2x.SetToolTip(this.txtPoint2x, "Enter the x value of the second point.");
            // 
            // txtPoint2y
            // 
            this.txtPoint2y.Location = new System.Drawing.Point(252, 90);
            this.txtPoint2y.Name = "txtPoint2y";
            this.txtPoint2y.Size = new System.Drawing.Size(48, 20);
            this.txtPoint2y.TabIndex = 3;
            this.ttPoint2y.SetToolTip(this.txtPoint2y, "Enter the y value of the second point.");
            // 
            // lblMisc2
            // 
            this.lblMisc2.AutoSize = true;
            this.lblMisc2.Location = new System.Drawing.Point(236, 52);
            this.lblMisc2.Name = "lblMisc2";
            this.lblMisc2.Size = new System.Drawing.Size(10, 13);
            this.lblMisc2.TabIndex = 6;
            this.lblMisc2.Text = ",";
            // 
            // lblMisc1
            // 
            this.lblMisc1.AutoSize = true;
            this.lblMisc1.Location = new System.Drawing.Point(166, 52);
            this.lblMisc1.Name = "lblMisc1";
            this.lblMisc1.Size = new System.Drawing.Size(10, 13);
            this.lblMisc1.TabIndex = 7;
            this.lblMisc1.Text = "(";
            // 
            // lblMisc3
            // 
            this.lblMisc3.AutoSize = true;
            this.lblMisc3.Location = new System.Drawing.Point(306, 52);
            this.lblMisc3.Name = "lblMisc3";
            this.lblMisc3.Size = new System.Drawing.Size(10, 13);
            this.lblMisc3.TabIndex = 8;
            this.lblMisc3.Text = ")";
            // 
            // lblMisc4
            // 
            this.lblMisc4.AutoSize = true;
            this.lblMisc4.Location = new System.Drawing.Point(166, 97);
            this.lblMisc4.Name = "lblMisc4";
            this.lblMisc4.Size = new System.Drawing.Size(10, 13);
            this.lblMisc4.TabIndex = 9;
            this.lblMisc4.Text = "(";
            // 
            // lblMisc6
            // 
            this.lblMisc6.AutoSize = true;
            this.lblMisc6.Location = new System.Drawing.Point(306, 97);
            this.lblMisc6.Name = "lblMisc6";
            this.lblMisc6.Size = new System.Drawing.Size(10, 13);
            this.lblMisc6.TabIndex = 10;
            this.lblMisc6.Text = ")";
            // 
            // lblMisc5
            // 
            this.lblMisc5.AutoSize = true;
            this.lblMisc5.Location = new System.Drawing.Point(236, 97);
            this.lblMisc5.Name = "lblMisc5";
            this.lblMisc5.Size = new System.Drawing.Size(10, 13);
            this.lblMisc5.TabIndex = 11;
            this.lblMisc5.Text = ",";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // lblLinearEquation
            // 
            this.lblLinearEquation.AutoSize = true;
            this.lblLinearEquation.Location = new System.Drawing.Point(38, 201);
            this.lblLinearEquation.Name = "lblLinearEquation";
            this.lblLinearEquation.Size = new System.Drawing.Size(84, 13);
            this.lblLinearEquation.TabIndex = 13;
            this.lblLinearEquation.Text = "Linear Equation ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Line Segment Length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Midpoint Coordinate";
            // 
            // txtLineLength
            // 
            this.txtLineLength.Location = new System.Drawing.Point(152, 273);
            this.txtLineLength.Name = "txtLineLength";
            this.txtLineLength.Size = new System.Drawing.Size(164, 20);
            this.txtLineLength.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(41, 127);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(275, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.ttCalculate.SetToolTip(this.btnCalculate, "Click to calculate the properties of the line segment shown below.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(275, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.ttClear.SetToolTip(this.btnClear, "Click to clear all. ");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ttPoint1x
            // 
            this.ttPoint1x.IsBalloon = true;
            // 
            // ttPoint1y
            // 
            this.ttPoint1y.IsBalloon = true;
            // 
            // ttPoint2x
            // 
            this.ttPoint2x.IsBalloon = true;
            // 
            // ttPoint2y
            // 
            this.ttPoint2y.IsBalloon = true;
            // 
            // ttCalculate
            // 
            this.ttCalculate.IsBalloon = true;
            // 
            // ttClear
            // 
            this.ttClear.IsBalloon = true;
            // 
            // rttLinear
            // 
            this.rttLinear.Location = new System.Drawing.Point(152, 203);
            this.rttLinear.Name = "rttLinear";
            this.rttLinear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rttLinear.Size = new System.Drawing.Size(164, 64);
            this.rttLinear.TabIndex = 19;
            this.rttLinear.Text = "";
            // 
            // rttMidpoint
            // 
            this.rttMidpoint.Location = new System.Drawing.Point(152, 306);
            this.rttMidpoint.Name = "rttMidpoint";
            this.rttMidpoint.Size = new System.Drawing.Size(164, 48);
            this.rttMidpoint.TabIndex = 21;
            this.rttMidpoint.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 397);
            this.Controls.Add(this.rttMidpoint);
            this.Controls.Add(this.rttLinear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLineLength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLinearEquation);
            this.Controls.Add(this.lblMisc5);
            this.Controls.Add(this.lblMisc6);
            this.Controls.Add(this.lblMisc4);
            this.Controls.Add(this.lblMisc3);
            this.Controls.Add(this.lblMisc1);
            this.Controls.Add(this.lblMisc2);
            this.Controls.Add(this.txtPoint2y);
            this.Controls.Add(this.txtPoint2x);
            this.Controls.Add(this.txtPoint1y);
            this.Controls.Add(this.txtPoint1x);
            this.Controls.Add(this.lblPoint2);
            this.Controls.Add(this.lblPoint1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear Equation Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.TextBox txtPoint1x;
        private System.Windows.Forms.TextBox txtPoint1y;
        private System.Windows.Forms.TextBox txtPoint2x;
        private System.Windows.Forms.TextBox txtPoint2y;
        private System.Windows.Forms.Label lblMisc2;
        private System.Windows.Forms.Label lblMisc1;
        private System.Windows.Forms.Label lblMisc3;
        private System.Windows.Forms.Label lblMisc4;
        private System.Windows.Forms.Label lblMisc6;
        private System.Windows.Forms.Label lblMisc5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblLinearEquation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLineLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip ttPoint1x;
        private System.Windows.Forms.ToolTip ttPoint1y;
        private System.Windows.Forms.ToolTip ttPoint2x;
        private System.Windows.Forms.ToolTip ttPoint2y;
        private System.Windows.Forms.ToolTip ttCalculate;
        private System.Windows.Forms.ToolTip ttClear;
        private System.Windows.Forms.RichTextBox rttLinear;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rttMidpoint;
    }
}

