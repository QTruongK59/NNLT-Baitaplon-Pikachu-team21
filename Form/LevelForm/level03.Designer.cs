﻿namespace Pikachu_team21
{
    partial class level03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level03));
            this.pnLevel3 = new System.Windows.Forms.Panel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pnLevel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLevel3
            // 
            this.pnLevel3.BackColor = System.Drawing.Color.Transparent;
            this.pnLevel3.Controls.Add(this.lblLevel);
            this.pnLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLevel3.Location = new System.Drawing.Point(0, 0);
            this.pnLevel3.Name = "pnLevel3";
            this.pnLevel3.Size = new System.Drawing.Size(1124, 690);
            this.pnLevel3.TabIndex = 0;
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLevel.Image = ((System.Drawing.Image)(resources.GetObject("lblLevel.Image")));
            this.lblLevel.Location = new System.Drawing.Point(404, 168);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(315, 334);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "Lv3";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 690);
            this.Controls.Add(this.pnLevel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "level03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.pnLevel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLevel3;
        private System.Windows.Forms.Label lblLevel;
    }
}