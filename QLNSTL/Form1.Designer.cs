﻿namespace QLNSTL
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(169, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "QUẢN LÝ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(539, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "NHÂN VIÊN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN CHỨC NĂNG ĐĂNG NHẬP";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(14, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Giới thiệu và hướng dẫn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(932, 676);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ NHÂN SỰ - TIỀN LƯƠNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}