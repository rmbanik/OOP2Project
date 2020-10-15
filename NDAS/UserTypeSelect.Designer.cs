namespace NDAS
{
    partial class UserTypeSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnPatient = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(289, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 151);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("20th Century Font", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.rbtnPatient);
            this.panel2.Location = new System.Drawing.Point(114, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 45);
            this.panel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(9, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 15);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Doctor";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnDoctor);
            // 
            // rbtnPatient
            // 
            this.rbtnPatient.AutoSize = true;
            this.rbtnPatient.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPatient.Location = new System.Drawing.Point(111, 14);
            this.rbtnPatient.Name = "rbtnPatient";
            this.rbtnPatient.Size = new System.Drawing.Size(74, 15);
            this.rbtnPatient.TabIndex = 1;
            this.rbtnPatient.TabStop = true;
            this.rbtnPatient.Text = "Patient";
            this.rbtnPatient.UseVisualStyleBackColor = true;
            this.rbtnPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Patient_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("20th Century Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "UserTypeSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserTypeSelect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnPatient;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnBack;
    }
}