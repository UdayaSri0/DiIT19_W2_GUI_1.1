namespace W2_GUI_1._1
{
    partial class frmHome
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnClear = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblPassword.Location = new Point(358, 173);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 30);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(263, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 29);
            txtPassword.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblEmail.Location = new Point(377, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 30);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(263, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 29);
            txtEmail.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.Location = new Point(461, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 45);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnLogin.Location = new Point(263, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 45);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExit.Location = new Point(691, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 45);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Name = "frmHome";
            Text = "frmHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnClear;
        private Button btnLogin;
        private Button btnExit;
    }
}