﻿namespace BR2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lisa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fir)).BeginInit();
            this.SuspendLayout();
            // 
            // lisa
            // 
            this.lisa.Image = ((System.Drawing.Image)(resources.GetObject("lisa.Image")));
            this.lisa.Location = new System.Drawing.Point(24, 77);
            this.lisa.Name = "lisa";
            this.lisa.Size = new System.Drawing.Size(73, 75);
            this.lisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lisa.TabIndex = 0;
            this.lisa.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fir
            // 
            this.fir.Image = ((System.Drawing.Image)(resources.GetObject("fir.Image")));
            this.fir.Location = new System.Drawing.Point(103, 127);
            this.fir.Name = "fir";
            this.fir.Size = new System.Drawing.Size(26, 25);
            this.fir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fir.TabIndex = 1;
            this.fir.TabStop = false;
            this.fir.Visible = false;
            this.fir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 238);
            this.Controls.Add(this.fir);
            this.Controls.Add(this.lisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.lisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lisa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox fir;
    }
}

