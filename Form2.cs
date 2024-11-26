using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace W2_GUI_1._1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DarkStar;Initial Catalog=DiIT19SMS;Integrated Security=True;Encrypt=False";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            this.Hide();
            frmHome.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                string studentID = txtStuID.Text.Trim();

                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Please enter Student ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Students WHERE StudentID = @StudentID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StudentID", studentID);

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                txtStuName.Text = reader["StudentName"].ToString();
                                txtStuAge.Text = reader["StudentAge"].ToString();
                                txtConNo.Text = reader["ContactNo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Student not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtStuName.Text.Trim();
            string age = txtStuAge.Text.Trim();
            string contactNo = txtConNo.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(contactNo))
            {
                MessageBox.Show("Please fill all fields to insert a record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (StudentName, StudentAge, ContactNo) VALUES (@Name, @Age, @ContactNo)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Student record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtStuID.Text.Trim();
            string name = txtStuName.Text.Trim();
            string age = txtStuAge.Text.Trim();
            string contactNo = txtConNo.Text.Trim();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(contactNo))
            {
                MessageBox.Show("Please fill all fields to update a record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Students SET StudentName = @Name, StudentAge = @Age, ContactNo = @ContactNo WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Student not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStuID.Text.Trim();

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter Student ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Student not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearFields()
        {
            txtStuID.Clear();
            txtStuName.Clear();
            txtStuAge.Clear();
            txtConNo.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
