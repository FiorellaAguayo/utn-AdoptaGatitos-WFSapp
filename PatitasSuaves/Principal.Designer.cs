﻿namespace PatitasSuaves
{
    partial class Principal
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
            panButtonSelected = new Panel();
            lblTitle = new Label();
            panButtons = new Panel();
            btnSeePets = new Button();
            btnSeeUsers = new Button();
            btnAccount = new Button();
            btnContact = new Button();
            btnBePart = new Button();
            btnDonate = new Button();
            btnProfiles = new Button();
            panLogo = new Panel();
            lblLogo = new Label();
            panButtonSelected.SuspendLayout();
            panButtons.SuspendLayout();
            panLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panButtonSelected
            // 
            panButtonSelected.BackColor = Color.DarkGray;
            panButtonSelected.Controls.Add(lblTitle);
            panButtonSelected.Dock = DockStyle.Top;
            panButtonSelected.Location = new Point(193, 0);
            panButtonSelected.Name = "panButtonSelected";
            panButtonSelected.Size = new Size(822, 94);
            panButtonSelected.TabIndex = 19;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(371, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INICIO";
            // 
            // panButtons
            // 
            panButtons.BackColor = Color.IndianRed;
            panButtons.Controls.Add(btnSeePets);
            panButtons.Controls.Add(btnSeeUsers);
            panButtons.Controls.Add(btnAccount);
            panButtons.Controls.Add(btnContact);
            panButtons.Controls.Add(btnBePart);
            panButtons.Controls.Add(btnDonate);
            panButtons.Controls.Add(btnProfiles);
            panButtons.Controls.Add(panLogo);
            panButtons.Dock = DockStyle.Left;
            panButtons.Location = new Point(0, 0);
            panButtons.Name = "panButtons";
            panButtons.Size = new Size(193, 552);
            panButtons.TabIndex = 18;
            // 
            // btnSeePets
            // 
            btnSeePets.Dock = DockStyle.Top;
            btnSeePets.FlatAppearance.BorderSize = 0;
            btnSeePets.FlatStyle = FlatStyle.Flat;
            btnSeePets.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeePets.ForeColor = Color.White;
            btnSeePets.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeePets.Location = new Point(0, 451);
            btnSeePets.Name = "btnSeePets";
            btnSeePets.Padding = new Padding(12, 0, 0, 0);
            btnSeePets.Size = new Size(193, 60);
            btnSeePets.TabIndex = 22;
            btnSeePets.Text = "  Ver mascotas";
            btnSeePets.TextAlign = ContentAlignment.MiddleLeft;
            btnSeePets.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeePets.UseVisualStyleBackColor = true;
            btnSeePets.Visible = false;
            btnSeePets.Click += btnSeePets_Click;
            // 
            // btnSeeUsers
            // 
            btnSeeUsers.Dock = DockStyle.Top;
            btnSeeUsers.FlatAppearance.BorderSize = 0;
            btnSeeUsers.FlatStyle = FlatStyle.Flat;
            btnSeeUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeeUsers.ForeColor = Color.White;
            btnSeeUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeUsers.Location = new Point(0, 391);
            btnSeeUsers.Name = "btnSeeUsers";
            btnSeeUsers.Padding = new Padding(12, 0, 0, 0);
            btnSeeUsers.Size = new Size(193, 60);
            btnSeeUsers.TabIndex = 23;
            btnSeeUsers.Text = "  Ver usuarios";
            btnSeeUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnSeeUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeeUsers.UseVisualStyleBackColor = true;
            btnSeeUsers.Visible = false;
            btnSeeUsers.Click += btnSeeUsers_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 334);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(12, 0, 0, 0);
            btnAccount.Size = new Size(193, 57);
            btnAccount.TabIndex = 21;
            btnAccount.Text = "  Tu cuenta";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnContact
            // 
            btnContact.Dock = DockStyle.Top;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnContact.ForeColor = Color.White;
            btnContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnContact.Location = new Point(0, 274);
            btnContact.Name = "btnContact";
            btnContact.Padding = new Padding(12, 0, 0, 0);
            btnContact.Size = new Size(193, 60);
            btnContact.TabIndex = 20;
            btnContact.Text = "  Contacto";
            btnContact.TextAlign = ContentAlignment.MiddleLeft;
            btnContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            // 
            // btnBePart
            // 
            btnBePart.Dock = DockStyle.Top;
            btnBePart.FlatAppearance.BorderSize = 0;
            btnBePart.FlatStyle = FlatStyle.Flat;
            btnBePart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBePart.ForeColor = Color.White;
            btnBePart.ImageAlign = ContentAlignment.MiddleLeft;
            btnBePart.Location = new Point(0, 214);
            btnBePart.Name = "btnBePart";
            btnBePart.Padding = new Padding(12, 0, 0, 0);
            btnBePart.Size = new Size(193, 60);
            btnBePart.TabIndex = 19;
            btnBePart.Text = "  ¿Querés ser parte?";
            btnBePart.TextAlign = ContentAlignment.MiddleLeft;
            btnBePart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBePart.UseVisualStyleBackColor = true;
            btnBePart.Click += btnBePart_Click;
            // 
            // btnDonate
            // 
            btnDonate.Dock = DockStyle.Top;
            btnDonate.FlatAppearance.BorderSize = 0;
            btnDonate.FlatStyle = FlatStyle.Flat;
            btnDonate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonate.ForeColor = Color.White;
            btnDonate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonate.Location = new Point(0, 154);
            btnDonate.Name = "btnDonate";
            btnDonate.Padding = new Padding(12, 0, 0, 0);
            btnDonate.Size = new Size(193, 60);
            btnDonate.TabIndex = 18;
            btnDonate.Text = "  Donar";
            btnDonate.TextAlign = ContentAlignment.MiddleLeft;
            btnDonate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += btnDonate_Click;
            // 
            // btnProfiles
            // 
            btnProfiles.Dock = DockStyle.Top;
            btnProfiles.FlatAppearance.BorderSize = 0;
            btnProfiles.FlatStyle = FlatStyle.Flat;
            btnProfiles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfiles.ForeColor = Color.White;
            btnProfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfiles.Location = new Point(0, 94);
            btnProfiles.Name = "btnProfiles";
            btnProfiles.Padding = new Padding(12, 0, 0, 0);
            btnProfiles.Size = new Size(193, 60);
            btnProfiles.TabIndex = 17;
            btnProfiles.Text = "  Perfiles";
            btnProfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnProfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfiles.UseVisualStyleBackColor = true;
            btnProfiles.Click += btnProfiles_Click;
            // 
            // panLogo
            // 
            panLogo.BackColor = Color.Salmon;
            panLogo.Controls.Add(lblLogo);
            panLogo.Dock = DockStyle.Top;
            panLogo.Location = new Point(0, 0);
            panLogo.Name = "panLogo";
            panLogo.Size = new Size(193, 94);
            panLogo.TabIndex = 15;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(51, 50);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(76, 15);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "logoEmpresa";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 552);
            Controls.Add(panButtonSelected);
            Controls.Add(panButtons);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            Resize += Principal_Resize;
            StyleChanged += Principal_StyleChanged;
            panButtonSelected.ResumeLayout(false);
            panButtonSelected.PerformLayout();
            panButtons.ResumeLayout(false);
            panLogo.ResumeLayout(false);
            panLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panButtonSelected;
        private Label lblTitle;
        private Panel panButtons;
        private Button btnSeePets;
        private Button btnSeeUsers;
        private Button btnAccount;
        private Button btnContact;
        private Button btnBePart;
        private Button btnDonate;
        private Button btnProfiles;
        private Panel panLogo;
        private Label lblLogo;
    }
}