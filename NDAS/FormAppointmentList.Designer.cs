namespace NDAS
{
    partial class FormAppointmentList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowList = new System.Windows.Forms.Button();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.appoinmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnShowList);
            this.panel1.Controls.Add(this.dgvPatientList);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 436);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("20th Century Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Appointment List";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Patients ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(306, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Delete";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(143, 184);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(121, 22);
            this.txtAutoSearch.TabIndex = 5;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Info;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(863, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(96, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowList.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowList.Location = new System.Drawing.Point(822, 172);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(106, 34);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "Show List >>";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AllowUserToAddRows = false;
            this.dgvPatientList.AllowUserToDeleteRows = false;
            this.dgvPatientList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appoinmentid,
            this.name,
            this.gender,
            this.contactno,
            this.maritalstatus,
            this.date,
            this.type,
            this.description});
            this.dgvPatientList.Location = new System.Drawing.Point(3, 212);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientList.Size = new System.Drawing.Size(956, 236);
            this.dgvPatientList.TabIndex = 0;
            // 
            // appoinmentid
            // 
            this.appoinmentid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appoinmentid.DataPropertyName = "id";
            this.appoinmentid.HeaderText = "Appoinment ID";
            this.appoinmentid.Name = "appoinmentid";
            this.appoinmentid.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Patient Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // contactno
            // 
            this.contactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactno.DataPropertyName = "contactno";
            this.contactno.HeaderText = "Contact Number";
            this.contactno.Name = "contactno";
            this.contactno.ReadOnly = true;
            // 
            // maritalstatus
            // 
            this.maritalstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maritalstatus.DataPropertyName = "maritalstatus";
            this.maritalstatus.HeaderText = "Marital status";
            this.maritalstatus.Name = "maritalstatus";
            this.maritalstatus.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Appoinment Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Category";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // FormAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormAppointmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAppointmentList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn appoinmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
    }
}