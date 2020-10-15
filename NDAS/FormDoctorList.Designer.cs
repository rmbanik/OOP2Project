namespace NDAS
{
    partial class FormDoctorList
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
            this.btnBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDoctorList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvDoctorList);
            this.panel1.Controls.Add(this.Show);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 437);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("20th Century Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doctor List";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(24, 388);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(79, 25);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBooking.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBooking.Location = new System.Drawing.Point(792, 337);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(91, 30);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Location";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(299, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(193, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvDoctorList
            // 
            this.dgvDoctorList.AllowUserToAddRows = false;
            this.dgvDoctorList.AllowUserToDeleteRows = false;
            this.dgvDoctorList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.contact,
            this.area,
            this.caddress,
            this.specialist});
            this.dgvDoctorList.Location = new System.Drawing.Point(67, 118);
            this.dgvDoctorList.Name = "dgvDoctorList";
            this.dgvDoctorList.ReadOnly = true;
            this.dgvDoctorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorList.Size = new System.Drawing.Size(816, 213);
            this.dgvDoctorList.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Phone Number";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // area
            // 
            this.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Location";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // caddress
            // 
            this.caddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caddress.DataPropertyName = "caddress";
            this.caddress.HeaderText = "Address";
            this.caddress.Name = "caddress";
            this.caddress.ReadOnly = true;
            // 
            // specialist
            // 
            this.specialist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialist.DataPropertyName = "specialist";
            this.specialist.HeaderText = "Specialist";
            this.specialist.Name = "specialist";
            this.specialist.ReadOnly = true;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Show.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Show.Location = new System.Drawing.Point(808, 89);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 0;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // FormDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormDoctorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctorList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDoctorList;
        private new System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn caddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
    }
}