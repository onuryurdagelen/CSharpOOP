﻿
namespace HospitalManagementAndAppointmentAutomationSystems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBtnLogin = new System.Windows.Forms.Button();
            this.checkForgotPassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRedirectRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(170, 154);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.PlaceholderText = "Enter identity";
            this.txtLoginID.Size = new System.Drawing.Size(206, 33);
            this.txtLoginID.TabIndex = 2;
            this.txtLoginID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(170, 226);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PlaceholderText = "Enter password";
            this.txtPasswordLogin.Size = new System.Drawing.Size(206, 33);
            this.txtPasswordLogin.TabIndex = 3;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 109);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome To The Hospital Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(25, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 146);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBtnLogin
            // 
            this.txtBtnLogin.Location = new System.Drawing.Point(194, 288);
            this.txtBtnLogin.Name = "txtBtnLogin";
            this.txtBtnLogin.Size = new System.Drawing.Size(133, 46);
            this.txtBtnLogin.TabIndex = 0;
            this.txtBtnLogin.Text = "Login";
            this.txtBtnLogin.UseVisualStyleBackColor = true;
            // 
            // checkForgotPassword
            // 
            this.checkForgotPassword.AutoSize = true;
            this.checkForgotPassword.Location = new System.Drawing.Point(424, 230);
            this.checkForgotPassword.Name = "checkForgotPassword";
            this.checkForgotPassword.Size = new System.Drawing.Size(179, 29);
            this.checkForgotPassword.TabIndex = 6;
            this.checkForgotPassword.Text = "Forgot Password?";
            this.checkForgotPassword.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "You don\'t have any account yet?";
            // 
            // btnRedirectRegister
            // 
            this.btnRedirectRegister.Location = new System.Drawing.Point(468, 333);
            this.btnRedirectRegister.Name = "btnRedirectRegister";
            this.btnRedirectRegister.Size = new System.Drawing.Size(192, 46);
            this.btnRedirectRegister.TabIndex = 8;
            this.btnRedirectRegister.Text = "Go To Register Form";
            this.btnRedirectRegister.UseVisualStyleBackColor = true;
            this.btnRedirectRegister.Click += new System.EventHandler(this.btnRedirectRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 575);
            this.Controls.Add(this.btnRedirectRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkForgotPassword);
            this.Controls.Add(this.txtBtnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "User Login Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtBtnLogin;
        private System.Windows.Forms.CheckBox checkForgotPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRedirectRegister;
    }
}

