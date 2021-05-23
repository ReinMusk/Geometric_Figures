
namespace NaPare
{
    partial class frmMain
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoLine = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.topPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.txtSize);
            this.topPanel.Controls.Add(this.Label);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.btnColor);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.rdoSquare);
            this.topPanel.Controls.Add(this.rdoTriangle);
            this.topPanel.Controls.Add(this.rdoLine);
            this.topPanel.Controls.Add(this.rdoCircle);
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(976, 86);
            this.topPanel.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(491, 61);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 17;
            this.txtSize.Text = "1";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(523, 30);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 17);
            this.Label.TabIndex = 16;
            this.Label.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(638, 58);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(25, 25);
            this.btnColor.TabIndex = 14;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Square";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(844, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Triangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Circle";
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(928, 50);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(17, 16);
            this.rdoSquare.TabIndex = 7;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.UseVisualStyleBackColor = true;
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(866, 50);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(17, 16);
            this.rdoTriangle.TabIndex = 6;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoLine
            // 
            this.rdoLine.AutoSize = true;
            this.rdoLine.Location = new System.Drawing.Point(814, 50);
            this.rdoLine.Name = "rdoLine";
            this.rdoLine.Size = new System.Drawing.Size(17, 16);
            this.rdoLine.TabIndex = 5;
            this.rdoLine.TabStop = true;
            this.rdoLine.UseVisualStyleBackColor = true;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(767, 50);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(17, 16);
            this.rdoCircle.TabIndex = 4;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 86);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(976, 459);
            this.centerPanel.TabIndex = 1;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            this.centerPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.centerPanel_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 545);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoLine;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label Label;
    }
}

