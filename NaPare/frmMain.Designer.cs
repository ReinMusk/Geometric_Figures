
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
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
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
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(726, 21);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(80, 30);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(544, 21);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(80, 30);
            this.btnTriangle.TabIndex = 2;
            this.btnTriangle.Text = "triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(349, 21);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 30);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(168, 21);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
    }
}

