﻿namespace NgopiSek_Desktop_App_V2.Views.Controls
{
    partial class UCRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Register = new Panel();
            textConfirmPassword = new TextBox();
            textPassword = new TextBox();
            textBox1 = new TextBox();
            comboRole = new ComboBox();
            textPasskey = new TextBox();
            textUsername = new TextBox();
            textName = new TextBox();
            btnRegister = new Button();
            pressLogin = new Label();
            label1 = new Label();
            Register.SuspendLayout();
            SuspendLayout();
            // 
            // Register
            // 
            Register.BackgroundImage = Properties.Resources.Register_Form;
            Register.BackgroundImageLayout = ImageLayout.Zoom;
            Register.Controls.Add(textConfirmPassword);
            Register.Controls.Add(textPassword);
            Register.Controls.Add(textBox1);
            Register.Controls.Add(comboRole);
            Register.Controls.Add(textPasskey);
            Register.Controls.Add(textUsername);
            Register.Controls.Add(textName);
            Register.Location = new Point(209, 112);
            Register.Name = "Register";
            Register.Size = new Size(719, 784);
            Register.TabIndex = 0;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BackColor = Color.FromArgb(247, 250, 252);
            textConfirmPassword.BorderStyle = BorderStyle.None;
            textConfirmPassword.Cursor = Cursors.IBeam;
            textConfirmPassword.Font = new Font("Poppins", 12F);
            textConfirmPassword.ForeColor = Color.FromArgb(53, 53, 53);
            textConfirmPassword.Location = new Point(54, 499);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(607, 36);
            textConfirmPassword.TabIndex = 7;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(247, 250, 252);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Font = new Font("Poppins", 12F);
            textPassword.ForeColor = Color.FromArgb(53, 53, 53);
            textPassword.Location = new Point(54, 381);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(607, 36);
            textPassword.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 250, 252);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Poppins", 12F);
            textBox1.ForeColor = Color.FromArgb(53, 53, 53);
            textBox1.Location = new Point(56, 374);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(607, 36);
            textBox1.TabIndex = 6;
            // 
            // comboRole
            // 
            comboRole.BackColor = Color.FromArgb(247, 250, 252);
            comboRole.Cursor = Cursors.Hand;
            comboRole.FlatStyle = FlatStyle.Flat;
            comboRole.Font = new Font("Poppins", 12F);
            comboRole.ForeColor = Color.FromArgb(53, 53, 53);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(55, 610);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(606, 50);
            comboRole.TabIndex = 5;
            // 
            // textPasskey
            // 
            textPasskey.BackColor = Color.FromArgb(247, 250, 252);
            textPasskey.BorderStyle = BorderStyle.None;
            textPasskey.Cursor = Cursors.IBeam;
            textPasskey.Font = new Font("Poppins", 12F);
            textPasskey.ForeColor = Color.FromArgb(53, 53, 53);
            textPasskey.Location = new Point(54, 731);
            textPasskey.Name = "textPasskey";
            textPasskey.Size = new Size(607, 36);
            textPasskey.TabIndex = 4;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(247, 250, 252);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("Poppins", 12F);
            textUsername.ForeColor = Color.FromArgb(53, 53, 53);
            textUsername.Location = new Point(55, 270);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(607, 36);
            textUsername.TabIndex = 1;
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(247, 250, 252);
            textName.BorderStyle = BorderStyle.None;
            textName.Cursor = Cursors.IBeam;
            textName.Font = new Font("Poppins", 12F);
            textName.ForeColor = Color.FromArgb(53, 53, 53);
            textName.Location = new Point(55, 162);
            textName.Name = "textName";
            textName.Size = new Size(607, 36);
            textName.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 145, 83);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(249, 946);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(651, 60);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // pressLogin
            // 
            pressLogin.AutoSize = true;
            pressLogin.Cursor = Cursors.Hand;
            pressLogin.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pressLogin.Location = new Point(629, 1021);
            pressLogin.Name = "pressLogin";
            pressLogin.Size = new Size(67, 31);
            pressLogin.TabIndex = 2;
            pressLogin.Text = "Login";
            pressLogin.Click += pressLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Gilroy-Medium", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(423, 1024);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 4;
            label1.Text = "Sudah memiliki akun? ";
            // 
            // UCRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pressLogin);
            Controls.Add(btnRegister);
            Controls.Add(Register);
            Name = "UCRegister";
            Size = new Size(1147, 1166);
            Register.ResumeLayout(false);
            Register.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Register;
        private Button btnRegister;
        private Label pressLogin;
        private TextBox textName;
        private ComboBox comboRole;
        private TextBox textPasskey;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textUsername;
        private TextBox textConfirmPassword;
        private TextBox textPassword;
        private TextBox textBox1;
        private Label label1;
    }
}
