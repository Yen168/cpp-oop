namespace WorldCapitals
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.optChoice1 = new System.Windows.Forms.RadioButton();
            this.optChoice2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(89, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(33, 12);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(89, 176);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 12);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label2";
            // 
            // optChoice1
            // 
            this.optChoice1.AutoSize = true;
            this.optChoice1.Location = new System.Drawing.Point(91, 61);
            this.optChoice1.Name = "optChoice1";
            this.optChoice1.Size = new System.Drawing.Size(85, 16);
            this.optChoice1.TabIndex = 2;
            this.optChoice1.TabStop = true;
            this.optChoice1.Text = "radioButton1";
            this.optChoice1.UseVisualStyleBackColor = true;
            // 
            // optChoice2
            // 
            this.optChoice2.AutoSize = true;
            this.optChoice2.Location = new System.Drawing.Point(91, 98);
            this.optChoice2.Name = "optChoice2";
            this.optChoice2.Size = new System.Drawing.Size(85, 16);
            this.optChoice2.TabIndex = 3;
            this.optChoice2.TabStop = true;
            this.optChoice2.Text = "radioButton2";
            this.optChoice2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optChoice2);
            this.Controls.Add(this.optChoice1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.RadioButton optChoice1;
        private System.Windows.Forms.RadioButton optChoice2;
        private System.Windows.Forms.Button button1;
    }
}

