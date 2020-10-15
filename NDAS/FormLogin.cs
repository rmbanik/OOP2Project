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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string id = this.txtId.Text;



                string sql = @"select * from signin where id = '" + this.txtId.Text + "' and password = '" + this.txtPassword.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                string name = ds.Tables[0].Rows[0]["name"].ToString();




                if (ds.Tables[0].Rows[0]["type"].ToString() == "patient")
                {
                    //MessageBox.Show(id);
                    FormDoctorList fap = new FormDoctorList();
                    fap.getId(id);
                    fap.Visible = true;
                    this.Visible = false;
                }

                if (ds.Tables[0].Rows[0]["type"].ToString() == "doctor")
                {
                    //MessageBox.Show(name);
                    FormAppointmentList fal = new FormAppointmentList();
                    fal.GetName(name);
                    fal.Visible = true;
                    this.Visible = false;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in login \n" + exc.Message);
            }

        }

        private void btnRegi_Click(object sender, EventArgs e)
        {
            try
            {
                UserTypeSelect uts = new UserTypeSelect();
                uts.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored!\n" + exc.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!\n" + exc.Message);
            }
        }
    }
}
