namespace JARVIS
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
            this.lbltext1 = new System.Windows.Forms.Label();
            this.lbltext2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext1.Location = new System.Drawing.Point(12, 9);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(64, 25);
            this.lbltext1.TabIndex = 0;
            this.lbltext1.Text = "YOU:";
            // 
            // lbltext2
            // 
            this.lbltext2.AutoSize = true;
            this.lbltext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext2.Location = new System.Drawing.Point(12, 58);
            this.lbltext2.Name = "lbltext2";
            this.lbltext2.Size = new System.Drawing.Size(91, 25);
            this.lbltext2.TabIndex = 1;
            this.lbltext2.Text = "JARVIS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 361);
            this.Controls.Add(this.lbltext2);
            this.Controls.Add(this.lbltext1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.Label lbltext2;
    }
}

