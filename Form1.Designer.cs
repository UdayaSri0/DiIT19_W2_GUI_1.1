namespace W2_GUI_1._1
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
            lblName = new Label();
            btnTot = new Button();
            txtName = new TextBox();
            btnClear = new Button();
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.Location = new Point(249, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnTot
            // 
            btnTot.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btnTot.Location = new Point(270, 370);
            btnTot.Name = "btnTot";
            btnTot.Size = new Size(76, 45);
            btnTot.TabIndex = 1;
            btnTot.Text = "+";
            btnTot.UseVisualStyleBackColor = true;
            btnTot.Click += btnTot_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtName.Location = new Point(249, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 29);
            txtName.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.Location = new Point(468, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 45);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNum1.Location = new Point(249, 162);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(316, 29);
            txtNum1.TabIndex = 4;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNum1.Location = new Point(249, 123);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(80, 21);
            lblNum1.TabIndex = 5;
            lblNum1.Text = "Number 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNum2.Location = new Point(249, 215);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(83, 21);
            lblNum2.TabIndex = 7;
            lblNum2.Text = "Number 2";
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNum2.Location = new Point(249, 254);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(316, 29);
            txtNum2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Controls.Add(btnClear);
            Controls.Add(txtName);
            Controls.Add(btnTot);
            Controls.Add(lblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnTot;
        private TextBox txtName;
        private Button btnClear;
        private TextBox txtNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum2;
    }
}
