﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;


namespace Laboratory_Management_System__Capstone_Project_
{
    public partial class UpdateBorrowReturnTransaction : Form
    {
        public UpdateBorrowReturnTransaction()
        {
            InitializeComponent();
        }

        Int64 rowid;
        int id;

        private void UpdateBorrowReturnTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BorrowReturnTransaction", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvTransaction.DataSource = ds.Tables[0];
                }
                pnelUPDATE.Visible = false;

                // Populate the Apparatus Name ComboBox
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [Apparatus Name] FROM Inventory", con);
                    SqlDataReader sdataread = cmd.ExecuteReader();

                    while (sdataread.Read())
                    {
                        cbAppaName.Items.Add(sdataread.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                if (dgvTransaction.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id = int.Parse(dgvTransaction.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                pnelUPDATE.Visible = true;

                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM BorrowReturnTransaction WHERE transactionID= {id}", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        rowid = Convert.ToInt64(row[0]);

                        tbStudentName.Text = row[1].ToString();
                        tbIDNum.Text = row[2].ToString();
                        tbEmailAdd.Text = row[3].ToString();
                        tbContact.Text = row[4].ToString();
                        cbProgram.Text = row[5].ToString();
                        cbAppaName.Text = row[6].ToString();
                        dtpBorrowedDate.Text = row[7].ToString();
                        dtpDueDate.Text = row[8].ToString();
                        dtpDateReturned.Text = row[9].ToString();
                        tbRemarks.Text = row[13].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransaction.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int transactionID = Convert.ToInt32(dgvTransaction.SelectedRows[0].Cells["transactionID"].Value);
                string studentName = tbStudentName.Text;
                string idNumber = tbIDNum.Text;
                string emailAddress = tbEmailAdd.Text;
                string contactNumber = tbContact.Text;
                string program = cbProgram.Text;
                string apparatusName = cbAppaName.Text;
                string borrowDate = dtpBorrowedDate.Text;
                string dueDate = dtpDueDate.Text;
                string dateReturned = dtpDateReturned.Text;
                string remarks = tbRemarks.Text;

                int studentID, apparatusID;

                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys; integrated security=True"))
                {
                    con.Open();

                    SqlCommand cmdGetStudentID = new SqlCommand("SELECT studID FROM Students WHERE [Student_Name] = @Student_Name", con);
                    cmdGetStudentID.Parameters.AddWithValue("@Student_Name", studentName);
                    object resultStudent = cmdGetStudentID.ExecuteScalar();
                    if (resultStudent == null)
                    {
                        MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    studentID = Convert.ToInt32(resultStudent);

                    SqlCommand cmdGetApparatusID = new SqlCommand("SELECT ApparatusID FROM Inventory WHERE [Apparatus Name] = @Apparatus_Name", con);
                    cmdGetApparatusID.Parameters.AddWithValue("@Apparatus_Name", apparatusName);
                    object resultApparatus = cmdGetApparatusID.ExecuteScalar();
                    if (resultApparatus == null)
                    {
                        MessageBox.Show("Apparatus not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    apparatusID = Convert.ToInt32(resultApparatus);

                    SqlCommand cmdUpdate = new SqlCommand(
                        "UPDATE BorrowReturnTransaction SET [Student_Name] = @Student_Name, [ID_Number] = @ID_Number, [Email_Address] = @Email_Address, [Contact_Number] = @Contact_Number, [Program] = @Program, [Apparatus_Name] = @Apparatus_Name, [Borrow_Date] = @Borrow_Date, [Due_Date] = @Due_Date, [Date_Returned] = @Date_Returned, [Remarks] = @Remarks, [studID] = @StudentID, [ApparatusID] = @ApparatusID WHERE transactionID = @TransactionID", con);
                    cmdUpdate.Parameters.AddWithValue("@Student_Name", studentName);
                    cmdUpdate.Parameters.AddWithValue("@ID_Number", idNumber);
                    cmdUpdate.Parameters.AddWithValue("@Email_Address", emailAddress);
                    cmdUpdate.Parameters.AddWithValue("@Contact_Number", contactNumber);
                    cmdUpdate.Parameters.AddWithValue("@Program", program);
                    cmdUpdate.Parameters.AddWithValue("@Apparatus_Name", apparatusName);
                    cmdUpdate.Parameters.AddWithValue("@Borrow_Date", borrowDate);
                    cmdUpdate.Parameters.AddWithValue("@Due_Date", dueDate);
                    cmdUpdate.Parameters.AddWithValue("@Date_Returned", dateReturned);
                    cmdUpdate.Parameters.AddWithValue("@Remarks", remarks);
                    cmdUpdate.Parameters.AddWithValue("@StudentID", studentID);
                    cmdUpdate.Parameters.AddWithValue("@ApparatusID", apparatusID);
                    cmdUpdate.Parameters.AddWithValue("@TransactionID", transactionID);

                    cmdUpdate.ExecuteNonQuery();
                }

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBorrowReturnTransaction_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("The Data will be deleted\n\nPlease click on the RETURN button to update the Apparatus List. Confirm?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                    {
                        SqlCommand cmd = new SqlCommand($"DELETE FROM BorrowReturnTransaction WHERE transactionID = {rowid}", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBorrowReturnTransaction_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    if (!string.IsNullOrEmpty(tbSearch.Text))
                    {
                        cmd.CommandText = "SELECT * FROM BorrowReturnTransaction WHERE [Student_Name] LIKE @SearchText + '%' OR [ID_Number] LIKE @SearchText + '%' " +
                                          "OR [Email_Address] LIKE @SearchText + '%' OR [Contact_Number] LIKE @SearchText + '%' OR [Program] LIKE @SearchText + '%' " +
                                          "OR [Apparatus_Name] LIKE @SearchText + '%' OR [Borrow_Date] LIKE @SearchText + '%' OR [Due_Date] LIKE @SearchText + '%' " +
                                          "OR [Date_Returned] LIKE @SearchText + '%' OR [Remarks] LIKE @SearchText + '%'";
                        cmd.Parameters.AddWithValue("@SearchText", tbSearch.Text.Trim());
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM BorrowReturnTransaction";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvTransaction.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pnelUPDATE.Visible = false;
            tbSearch.Clear();
        }



        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the license context for EPPlus
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (SqlConnection con = new SqlConnection("data source = LAPTOP-4KSPM38V; database = LabManagSys;integrated security=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BorrowReturnTransaction", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        using (ExcelPackage pck = new ExcelPackage())
                        {
                            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("BorrowReturnTransaction");

                            // Load the DataTable into the sheet, starting from cell A1
                            ws.Cells["A1"].LoadFromDataTable(dt, true);

                            // Format the header for columns
                            using (ExcelRange rng = ws.Cells["A1:XFD1"])
                            {
                                rng.Style.Font.Bold = true;
                                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));
                                rng.Style.Font.Color.SetColor(Color.White);
                            }

                            // Auto-fit columns
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            // Create a SaveFileDialog to choose the location and file name
                            using (SaveFileDialog sfd = new SaveFileDialog())
                            {
                                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                                sfd.Title = "Save an Excel File";

                                if (sfd.ShowDialog() == DialogResult.OK)
                                {
                                    // Save the file to the selected location
                                    File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());

                                    MessageBox.Show($"Data has been successfully exported to {sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}