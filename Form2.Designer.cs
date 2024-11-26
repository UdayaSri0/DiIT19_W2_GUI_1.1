namespace W2_GUI_1._1
{
    partial class Form2
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
            btnExit = new Button();
            lblStuId = new Label();
            txtStuName = new TextBox();
            txtStuID = new TextBox();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtConNo = new TextBox();
            txtStuAge = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 37);
            btnExit.TabIndex = 20;
            btnExit.Text = "Log out";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStuId
            // 
            lblStuId.AutoSize = true;
            lblStuId.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblStuId.Location = new Point(99, 65);
            lblStuId.Name = "lblStuId";
            lblStuId.Size = new Size(112, 30);
            lblStuId.TabIndex = 19;
            lblStuId.Text = "Sudent ID";
            // 
            // txtStuName
            // 
            txtStuName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStuName.Location = new Point(289, 142);
            txtStuName.Name = "txtStuName";
            txtStuName.Size = new Size(336, 29);
            txtStuName.TabIndex = 18;
            // 
            // txtStuID
            // 
            txtStuID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStuID.Location = new Point(289, 66);
            txtStuID.Name = "txtStuID";
            txtStuID.Size = new Size(336, 29);
            txtStuID.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.Location = new Point(690, 369);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 31);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(99, 141);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 21;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(99, 293);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 25;
            label2.Text = "Contact No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.Location = new Point(99, 217);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 24;
            label3.Text = "Student Age";
            // 
            // txtConNo
            // 
            txtConNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtConNo.Location = new Point(289, 294);
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(336, 29);
            txtConNo.TabIndex = 23;
            // 
            // txtStuAge
            // 
            txtStuAge.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStuAge.Location = new Point(289, 218);
            txtStuAge.Name = "txtStuAge";
            txtStuAge.Size = new Size(336, 29);
            txtStuAge.TabIndex = 22;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnInsert.Location = new Point(682, 136);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(97, 45);
            btnInsert.TabIndex = 26;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(682, 212);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 45);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(682, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 45);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(682, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 45);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 423);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(755, 212);
            dataGridView1.TabIndex = 30;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 647);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtConNo);
            Controls.Add(txtStuAge);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(lblStuId);
            Controls.Add(txtStuName);
            Controls.Add(txtStuID);
            Controls.Add(btnClear);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label lblStuId;
        private TextBox txtStuName;
        private TextBox txtStuID;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtConNo;
        private TextBox txtStuAge;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}