﻿namespace Laboratory_Management_System__Capstone_Project_
{
    partial class UpdateBorrowReturnTransaction
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.pnelUPDATE = new System.Windows.Forms.Panel();
            this.cbAppaName = new System.Windows.Forms.ComboBox();
            this.lnklblClear = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.tbEmailAdd = new System.Windows.Forms.TextBox();
            this.tbIDNum = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.pnelUPDATE.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(57, 99);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(1334, 439);
            this.dgvTransaction.TabIndex = 0;
            this.dgvTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnelUPDATE
            // 
            this.pnelUPDATE.Controls.Add(this.btnExportToExcel);
            this.pnelUPDATE.Controls.Add(this.cbAppaName);
            this.pnelUPDATE.Controls.Add(this.lnklblClear);
            this.pnelUPDATE.Controls.Add(this.btnDelete);
            this.pnelUPDATE.Controls.Add(this.btnUpdate);
            this.pnelUPDATE.Controls.Add(this.tbRemarks);
            this.pnelUPDATE.Controls.Add(this.cbProgram);
            this.pnelUPDATE.Controls.Add(this.tbContact);
            this.pnelUPDATE.Controls.Add(this.dtpDueDate);
            this.pnelUPDATE.Controls.Add(this.dtpBorrowedDate);
            this.pnelUPDATE.Controls.Add(this.dtpDateReturned);
            this.pnelUPDATE.Controls.Add(this.tbEmailAdd);
            this.pnelUPDATE.Controls.Add(this.tbIDNum);
            this.pnelUPDATE.Controls.Add(this.tbStudentName);
            this.pnelUPDATE.Controls.Add(this.label10);
            this.pnelUPDATE.Controls.Add(this.label9);
            this.pnelUPDATE.Controls.Add(this.label8);
            this.pnelUPDATE.Controls.Add(this.label7);
            this.pnelUPDATE.Controls.Add(this.label6);
            this.pnelUPDATE.Controls.Add(this.label5);
            this.pnelUPDATE.Controls.Add(this.label4);
            this.pnelUPDATE.Controls.Add(this.label3);
            this.pnelUPDATE.Controls.Add(this.label2);
            this.pnelUPDATE.Controls.Add(this.label1);
            this.pnelUPDATE.Location = new System.Drawing.Point(0, 631);
            this.pnelUPDATE.Name = "pnelUPDATE";
            this.pnelUPDATE.Size = new System.Drawing.Size(1446, 416);
            this.pnelUPDATE.TabIndex = 1;
    
            // 
            // cbAppaName
            // 
            this.cbAppaName.FormattingEnabled = true;
            this.cbAppaName.Location = new System.Drawing.Point(142, 284);
            this.cbAppaName.Name = "cbAppaName";
            this.cbAppaName.Size = new System.Drawing.Size(211, 24);
            this.cbAppaName.TabIndex = 23;
            // 
            // lnklblClear
            // 
            this.lnklblClear.AutoSize = true;
            this.lnklblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblClear.Location = new System.Drawing.Point(564, 357);
            this.lnklblClear.Name = "lnklblClear";
            this.lnklblClear.Size = new System.Drawing.Size(116, 22);
            this.lnklblClear.TabIndex = 22;
            this.lnklblClear.TabStop = true;
            this.lnklblClear.Text = "CLEAR ALL";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1013, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 46);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(825, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 45);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(816, 171);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(445, 137);
            this.tbRemarks.TabIndex = 19;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(142, 222);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(142, 24);
            this.cbProgram.TabIndex = 18;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(142, 176);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(211, 22);
            this.tbContact.TabIndex = 16;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(835, 68);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(211, 22);
            this.dtpDueDate.TabIndex = 15;
            // 
            // dtpBorrowedDate
            // 
            this.dtpBorrowedDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowedDate.Location = new System.Drawing.Point(835, 19);
            this.dtpBorrowedDate.Name = "dtpBorrowedDate";
            this.dtpBorrowedDate.Size = new System.Drawing.Size(211, 22);
            this.dtpBorrowedDate.TabIndex = 14;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReturned.Location = new System.Drawing.Point(835, 114);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(211, 22);
            this.dtpDateReturned.TabIndex = 13;
            // 
            // tbEmailAdd
            // 
            this.tbEmailAdd.Location = new System.Drawing.Point(142, 121);
            this.tbEmailAdd.Name = "tbEmailAdd";
            this.tbEmailAdd.Size = new System.Drawing.Size(211, 22);
            this.tbEmailAdd.TabIndex = 12;
            // 
            // tbIDNum
            // 
            this.tbIDNum.Location = new System.Drawing.Point(142, 75);
            this.tbIDNum.Name = "tbIDNum";
            this.tbIDNum.Size = new System.Drawing.Size(211, 22);
            this.tbIDNum.TabIndex = 11;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(142, 23);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(211, 22);
            this.tbStudentName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(745, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Remarks:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Apparatus Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Returned:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Due Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Borrow Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Program:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(568, 572);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(324, 22);
            this.tbSearch.TabIndex = 24;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(511, 575);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 16);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Search:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(898, 563);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 40);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(1201, 348);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(182, 46);
            this.btnExportToExcel.TabIndex = 24;
            this.btnExportToExcel.Text = "EXPORT";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // UpdateBorrowReturnTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1444, 1101);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pnelUPDATE);
            this.Controls.Add(this.dgvTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBorrowReturnTransaction";
            this.Text = "Updating the Borrow-Return Transaction";
            this.Load += new System.EventHandler(this.UpdateBorrowReturnTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.pnelUPDATE.ResumeLayout(false);
            this.pnelUPDATE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Panel pnelUPDATE;
        private System.Windows.Forms.TextBox tbEmailAdd;
        private System.Windows.Forms.TextBox tbIDNum;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.DateTimePicker dtpBorrowedDate;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel lnklblClear;
        private System.Windows.Forms.ComboBox cbAppaName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}