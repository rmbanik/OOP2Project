using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDAS
{
    public partial class PatientForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        private string Gender { get; set; }

        private string MaritialStatus { get; set; }

        private string ID { get; set; }
        private string[] str;
        public PatientForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void GeneratePatientID()
        {
            this.Sql = "select * from appointmentlist order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            this.ID = dt.Rows[0]["id"].ToString();
            str = this.ID.Split('P');

            int number = Convert.ToInt32(str[1]);
            this.ID ="P" + (++number).ToString("d3");

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            try
            {
                if (rbtnMale.Checked == true)
                {
                    this.Gender = "Male";
                }
                else
                {
                    this.Gender = "Female";
                }


                if (rbtnSignle.Checked == true)
                {
                    this.MaritialStatus = "Single";
                }
                if (rbtnMarried.Checked == true)
                {
                    this.MaritialStatus = "Married";
                }
                else
                {
                    this.MaritialStatus = "Widowed";

                }



                GeneratePatientID();
                //MessageBox.Show(this.str[1]);
                //this.ID = "p101";

                string sql = "insert into dbo.signin (id,name,password,type) values('" + this.ID + "','" + this.txtName.Text + "','" + this.textBox1.Text + "','patient');";
                this.Sql = "insert into dbo.appointmentlist (id,name,gender,contactno,maritalstatus,date,type,description,time,area,age,appid) values('" + this.ID + "','" + this.txtName.Text + "','" + this.Gender + "','" + this.txtContact.Text + "','" + this.MaritialStatus + "','" + this.dtpDate.Text + "','" + this.cmboxVisitType.Text + "','" + this.ckBox.SelectedItem + "','" + this.dtpTime.Text + "','" + this.cmboxSelectArea.Text + "','" + this.txtAge.Text + "','');";

                this.Ds = Da.ExecuteQuery(this.Sql);
                this.Ds = Da.ExecuteQuery(sql);

                ;


                FormDoctorList fdl = new FormDoctorList();
                fdl.getId(ID);
                fdl.Visible = true;
                this.Visible = false;
            }
            

            
             catch(Exception exc)
            {
                MessageBox.Show("An error has occored during saving data\n"+exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                UserTypeSelect sf = new UserTypeSelect();
                sf.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!!\n" + exc.Message);
            }
        }

        
    }
}
