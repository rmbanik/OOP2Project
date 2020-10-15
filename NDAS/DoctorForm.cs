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
    public partial class DoctorForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        private string Sql2 { get; set; }
        private string Gender { get; set; }

        private string MaritialStatus { get; set; }

         string[] str;
        private string ID { get; set; }

        public DoctorForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void GenerateDoctorID()
        {
            this.Sql = "select * from DoctorInformation order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            this.ID = dt.Rows[0]["id"].ToString();
            str = this.ID.Split('D');
            int number = Convert.ToInt32(str[1]);
            this.ID = "D" + (++number).ToString("d3");

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Your ID is :"+this.ID);
                GenerateDoctorID();
                this.Sql = "insert into dbo.DoctorInformation (id,name,contact,stime,etime,area,caddress,specialist) values ('"+this.ID+"','" + this.txtName.Text + "','" + this.txtContactNo.Text + "','" + this.dtmStart.Text + "','" + this.dtmEnd.Text + "','" + this.cbboxArea.Text + "','" + this.txtChamberAddress.Text + "','" + this.cbboxSpecilist.Text + "');";

                string sql = "insert into dbo.signin (id,name,password,type) values('"+this.ID+"','" + this.txtName.Text + "','" + this.txtPassword.Text + "','doctor');";


                this.Ds = Da.ExecuteQuery(this.Sql);
                this.Ds = Da.ExecuteQuery(sql);


                
                FormAppointmentList fal = new FormAppointmentList();
                fal.Visible = true;
                this.Visible = false;
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occored during saving data\n"+exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                UserTypeSelect uts = new UserTypeSelect();
                uts.Visible = true;
                this.Visible = false;
            }

            catch(Exception exc)
            {
                MessageBox.Show("An error has occored during saving data\n" + exc.Message);
            }
        }
    }
}
