
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
            this.btnPen = new System.Windows.Forms.Button();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoLine = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.btnPen);
            this.topPanel.Controls.Add(this.rdoSquare);
            this.topPanel.Controls.Add(this.rdoTriangle);
            this.topPanel.Controls.Add(this.rdoLine);
            this.topPanel.Controls.Add(this.rdoCircle);
            this.topPanel.Controls.Add(this.btnSquare);
            this.topPanel.Controls.Add(this.btnTriangle);
            this.topPanel.Controls.Add(this.btnLine);
            this.topPanel.Controls.Add(this.btnCircle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(976, 72);
            this.topPanel.TabIndex = 0;
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPen.Location = new System.Drawing.Point(12, 14);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(91, 42);
            this.btnPen.TabIndex = 8;
            this.btnPen.Text = "PEN";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(861, 27);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(17, 16);
            this.rdoSquare.TabIndex = 7;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.UseVisualStyleBackColor = true;
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(659, 27);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(17, 16);
            this.rdoTriangle.TabIndex = 6;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoLine
            // 
            this.rdoLine.AutoSize = true;
            this.rdoLine.Location = new System.Drawing.Point(457, 27);
            this.rdoLine.Name = "rdoLine";
            this.rdoLine.Size = new System.Drawing.Size(17, 16);
            this.rdoLine.TabIndex = 5;
            this.rdoLine.TabStop = true;
            this.rdoLine.UseVisualStyleBackColor = true;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(255, 27);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(17, 16);
            this.rdoCircle.TabIndex = 4;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(884, 20);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(80, 30);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(682, 20);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(80, 30);
            this.btnTriangle.TabIndex = 2;
            this.btnTriangle.Text = "triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(480, 20);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 30);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(278, 20);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(80, 30);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 72);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(976, 473);
            this.centerPanel.TabIndex = 1;
            this.centerPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.centerPanel_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 545);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoLine;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

