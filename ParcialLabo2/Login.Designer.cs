﻿namespace ParcialLabo2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            llSignUp = new LinkLabel();
            txbPassword = new TextBox();
            txbUser = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(291, 241);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 13;
            label2.Text = "¿No tienes una cuenta?";
            // 
            // llSignUp
            // 
            llSignUp.ActiveLinkColor = SystemColors.Highlight;
            llSignUp.AutoSize = true;
            llSignUp.Location = new Point(417, 241);
            llSignUp.Name = "llSignUp";
            llSignUp.Size = new Size(59, 15);
            llSignUp.TabIndex = 8;
            llSignUp.TabStop = true;
            llSignUp.Text = "Regístrate";
            llSignUp.LinkClicked += llSignUp_LinkClicked;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.ForeColor = SystemColors.WindowFrame;
            txbPassword.Location = new Point(239, 122);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(315, 20);
            txbPassword.TabIndex = 10;
            txbPassword.Text = "CONTRASEÑA";
            txbPassword.Enter += txbPassword_Enter;
            txbPassword.Leave += txbPassword_Leave;
            // 
            // txbUser
            // 
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.ForeColor = SystemColors.WindowFrame;
            txbUser.Location = new Point(239, 85);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(315, 20);
            txbUser.TabIndex = 9;
            txbUser.Text = "USUARIO";
            txbUser.Enter += txbUser_Enter;
            txbUser.Leave += txbUser_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(224, 224, 224);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.WindowFrame;
            btnLogin.Location = new Point(239, 179);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(315, 32);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(342, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 11;
            label1.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 273);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 38;
            label3.Text = "Patitas Suaves";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(206, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(620, 273);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(llSignUp);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel llSignUp;
        private TextBox txbPassword;
        public TextBox txbUser;
        private Button btnLogin;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox3;
    }
}