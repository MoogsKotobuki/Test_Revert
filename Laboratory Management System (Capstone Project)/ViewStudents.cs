﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Laboratory_Management_System__Capstone_Project_
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        //SEARCH TEXTBOX FOR THE STUDENTS
        private void tbStudentSearch_TextChanged(object sender, EventArgs e)
        {
            // Update the search icon and label visibility based on input
            if (tbStudentSearch.Text != "")
            {
                Image searchImage = Image.FromFile("C:/Users/Kyoto/source/repos/Laboratory Management System (Capstone Project)/Images/img/search1.gif");
                pictureBox1.Image = searchImage;
                label1.Visible = false;

                // Perform the search
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Students WHERE ID_Number LIKE @SearchText + '%' OR Student_Name LIKE @SearchText + '%'";

                    cmd.Parameters.AddWithValue("@SearchText", tbStudentSearch.Text);

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();

                    try
                    {
                        con.Open();
                        DA.Fill(DS);

                        // Check if the dataset is empty
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            dgvStudentsInformation.DataSource = DS.Tables[0];
                        }
                        else
                        {
                            dgvStudentsInformation.DataSource = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                Image defaultImage = Image.FromFile("C:/Users/Kyoto/source/repos/Laboratory Management System (Capstone Project)/Images/img/search.gif");
                pictureBox1.Image = defaultImage;
                label1.Visible = true;

                // Load all student data when the search box is empty
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Students";

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();

                    try
                    {
                        con.Open();
                        DA.Fill(DS);

                        // Check if the dataset is empty
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            dgvStudentsInformation.DataSource = DS.Tables[0];
                        }
                        else
                        {
                            dgvStudentsInformation.DataSource = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            // Ensure the connection string is correct and accessible
            string connectionString = "data source = LAPTOP-4KSPM38V; database = LabManagSys; integrated security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Define the SQL command
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);

                    // Set up the data adapter and associate it with the command
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    // Create a DataSet to hold the data
                    DataSet DS = new DataSet();

                    // Fill the DataSet with data from the database
                    DA.Fill(DS);

                    // Bind the data to the DataGridView
                    dgvStudentsInformation.DataSource = DS.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        
        int ID;
        Int64 rowid;
        private void dgvStudentsInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell and row are within the valid range
            if (e.RowIndex >= 0 && dgvStudentsInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Acquire the data that will match the Primary Key of the table
                ID = int.Parse(dgvStudentsInformation.Rows[e.RowIndex].Cells[0].Value.ToString());

                panel2.Visible = true;

                // Define the connection string
                string connectionString = "data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Define the SQL command
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE studID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    // Set up the data adapter with the command
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    // To hold the data
                    DataSet DS = new DataSet();

                    try
                    {
                        con.Open();
                        // Fill the DataSet with data from the database
                        DA.Fill(DS);

                        // Check if the query returned any results
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            // Extract data from the first row
                            rowid = Int64.Parse(DS.Tables[0].Rows[0]["studID"].ToString());
                            tbStudentName.Text = DS.Tables[0].Rows[0]["Student_Name"].ToString();
                            tbIDNum.Text = DS.Tables[0].Rows[0]["ID_Number"].ToString();
                            tbEmail.Text = DS.Tables[0].Rows[0]["Email_Address"].ToString();
                            tbContactNum.Text = DS.Tables[0].Rows[0]["Contact_No"].ToString();
                            cbProgram.Text = DS.Tables[0].Rows[0]["Program"].ToString();
                            cbDept.Text = DS.Tables[0].Rows[0]["Department"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String studname = tbStudentName.Text;
            String idnum = tbIDNum.Text;
            String email = tbEmail.Text;
            Int64 contactnum;

            if (!Int64.TryParse(tbContactNum.Text, out contactnum))
            {
                MessageBox.Show("Invalid contact number.");
                return;
            }

            String program = cbProgram.Text;
            String department = cbDept.Text;

            if (MessageBox.Show("Student's Information will now be updated.\n" +
                "\nDo you wish to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE Students SET Student_Name = @StudentName, ID_Number = @IDNumber, Email_Address = @Email, Contact_No = @ContactNumber, Program = @Program, Department = @Department WHERE studID = @RowID";

                    cmd.Parameters.AddWithValue("@StudentName", studname);
                    cmd.Parameters.AddWithValue("@IDNumber", idnum);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactnum);
                    cmd.Parameters.AddWithValue("@Program", program);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@RowID", rowid);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No student found with the specified ID.");
                        }

                        // Refresh the data grid view with the updated data
                        ViewStudentInformation_Load(this, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        //add more restrictions




    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The selected student's information will now be deleted.\n" +
     "\nDo you wish to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "DELETE FROM Students WHERE studID = @RowID";
                    cmd.Parameters.AddWithValue("@RowID", rowid);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No student found with the specified ID.");
                        }

                        // Refresh the data grid view with the updated data
                        ViewStudentInformation_Load(this, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbStudentSearch.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbStudentName.Clear();
            tbIDNum.Clear();
            tbEmail.Clear();
            tbContactNum.Clear();
            cbProgram.SelectedIndex = -1;
            cbDept.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved changes will be lost\nDo you want to go back to the Dashboard?"
               , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                //Sets back to 0 to prevent restriction from occuring
                Dashboard.formRestrict = 0;

            }
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
