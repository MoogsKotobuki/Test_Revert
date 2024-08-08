﻿namespace Laboratory_Management_System__Capstone_Project_
{
    partial class TransactionDetails
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
            this.dgvBorrowDetails = new System.Windows.Forms.DataGridView();
            this.dgvReturnDetails = new System.Windows.Forms.DataGridView();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvViolationRecords = new System.Windows.Forms.DataGridView();
            this.lblViolation = new System.Windows.Forms.Label();
            this.cmbViewOptions = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblApparatus = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolationRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowDetails
            // 
            this.dgvBorrowDetails.AllowUserToOrderColumns = true;
            this.dgvBorrowDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowDetails.Location = new System.Drawing.Point(155, 278);
            this.dgvBorrowDetails.Name = "dgvBorrowDetails";
            this.dgvBorrowDetails.RowHeadersWidth = 51;
            this.dgvBorrowDetails.RowTemplate.Height = 24;
            this.dgvBorrowDetails.Size = new System.Drawing.Size(1327, 324);
            this.dgvBorrowDetails.TabIndex = 0;
            // 
            // dgvReturnDetails
            // 
            this.dgvReturnDetails.AllowUserToOrderColumns = true;
            this.dgvReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnDetails.Location = new System.Drawing.Point(155, 303);
            this.dgvReturnDetails.Name = "dgvReturnDetails";
            this.dgvReturnDetails.RowHeadersWidth = 51;
            this.dgvReturnDetails.RowTemplate.Height = 24;
            this.dgvReturnDetails.Size = new System.Drawing.Size(1327, 364);
            this.dgvReturnDetails.TabIndex = 1;
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.Location = new System.Drawing.Point(749, 250);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(231, 25);
            this.lblBorrow.TabIndex = 2;
            this.lblBorrow.Text = "Borrowed Apparatuses";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(749, 275);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(227, 25);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "Returned Apparatuses";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1527, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvViolationRecords
            // 
            this.dgvViolationRecords.AllowUserToOrderColumns = true;
            this.dgvViolationRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViolationRecords.Location = new System.Drawing.Point(155, 336);
            this.dgvViolationRecords.Name = "dgvViolationRecords";
            this.dgvViolationRecords.RowHeadersWidth = 51;
            this.dgvViolationRecords.RowTemplate.Height = 24;
            this.dgvViolationRecords.Size = new System.Drawing.Size(1327, 374);
            this.dgvViolationRecords.TabIndex = 40;
            // 
            // lblViolation
            // 
            this.lblViolation.AutoSize = true;
            this.lblViolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViolation.Location = new System.Drawing.Point(774, 299);
            this.lblViolation.Name = "lblViolation";
            this.lblViolation.Size = new System.Drawing.Size(181, 25);
            this.lblViolation.TabIndex = 41;
            this.lblViolation.Text = "Violation Records";
            // 
            // cmbViewOptions
            // 
            this.cmbViewOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewOptions.FormattingEnabled = true;
            this.cmbViewOptions.Location = new System.Drawing.Point(388, 213);
            this.cmbViewOptions.Name = "cmbViewOptions";
            this.cmbViewOptions.Size = new System.Drawing.Size(235, 33);
            this.cmbViewOptions.TabIndex = 42;
            this.cmbViewOptions.SelectedIndexChanged += new System.EventHandler(this.cmbViewOptions_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1276, 185);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(206, 36);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblApparatus
            // 
            this.lblApparatus.AutoSize = true;
            this.lblApparatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApparatus.Location = new System.Drawing.Point(750, 327);
            this.lblApparatus.Name = "lblApparatus";
            this.lblApparatus.Size = new System.Drawing.Size(279, 25);
            this.lblApparatus.TabIndex = 44;
            this.lblApparatus.Text = "Laboratory Inventory Report";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(155, 352);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(1327, 374);
            this.dgvInventory.TabIndex = 45;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(749, 362);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(316, 25);
            this.lblStudents.TabIndex = 46;
            this.lblStudents.Text = "Registered Laboratory Students";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(419, 390);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1000, 374);
            this.dgvStudents.TabIndex = 47;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(1276, 227);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(206, 45);
            this.btnPrintAll.TabIndex = 48;
            this.btnPrintAll.Text = "PRINT ALL RECORDS";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Check Record Details:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1276, 143);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(206, 36);
            this.btnExport.TabIndex = 50;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1276, 101);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(206, 36);
            this.btnImport.TabIndex = 51;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1593, 1102);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblApparatus);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbViewOptions);
            this.Controls.Add(this.lblViolation);
            this.Controls.Add(this.dgvViolationRecords);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblBorrow);
            this.Controls.Add(this.dgvReturnDetails);
            this.Controls.Add(this.dgvBorrowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details and Report Summary of Transactions";
            this.Load += new System.EventHandler(this.TransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolationRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowDetails;
        private System.Windows.Forms.DataGridView dgvReturnDetails;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvViolationRecords;
        private System.Windows.Forms.Label lblViolation;
        private System.Windows.Forms.ComboBox cmbViewOptions;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblApparatus;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}