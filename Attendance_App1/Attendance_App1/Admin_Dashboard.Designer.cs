﻿namespace Attendance_App1
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.lbl_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Lecturer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(1058, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(86, 24);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Rasheed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1095, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1150, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Lecturer);
            this.panel2.Location = new System.Drawing.Point(532, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 228);
            this.panel2.TabIndex = 6;
            // 
            // btn_Lecturer
            // 
            this.btn_Lecturer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Lecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Lecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lecturer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lecturer.Image")));
            this.btn_Lecturer.Location = new System.Drawing.Point(0, 0);
            this.btn_Lecturer.Name = "btn_Lecturer";
            this.btn_Lecturer.Size = new System.Drawing.Size(247, 226);
            this.btn_Lecturer.TabIndex = 1;
            this.btn_Lecturer.Text = "Lecturer";
            this.btn_Lecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Lecturer.UseVisualStyleBackColor = false;
            this.btn_Lecturer.Click += new System.EventHandler(this.btn_Lecturer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_student);
            this.panel3.Location = new System.Drawing.Point(873, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 228);
            this.panel3.TabIndex = 6;
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Image = ((System.Drawing.Image)(resources.GetObject("btn_student.Image")));
            this.btn_student.Location = new System.Drawing.Point(0, -1);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(247, 226);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "Student";
            this.btn_student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_attendance.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_attendance.FlatAppearance.BorderSize = 20;
            this.btn_attendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance.Image")));
            this.btn_attendance.Location = new System.Drawing.Point(2, -1);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(247, 226);
            this.btn_attendance.TabIndex = 0;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_attendance);
            this.panel1.Location = new System.Drawing.Point(192, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 228);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1260, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaximizeBox = false;
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Lecturer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Panel panel1;
    }
}