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
    public partial class FormDoctorList : Form
    {

        private string ID { get; set; }

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public FormDoctorList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            

            this.DPopularGridView();
        }
        

        public void getId(string id)
        {
            this.ID = id;
        }

        

      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           try
            {
                Sql = "select * from DoctorInformation where area like '" + this.txtSearch.Text + "%';";
                this.DPopularGridView(Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in search \n" + exc.Message);
            }

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("id" + this.ID);
                string name = this.dgvDoctorList.CurrentRow.Cells["name"].Value.ToString();

                this.Sql = @"update dbo.appointmentlist	
                        set dnam = '" + name + "' where id = '" + this.ID + "';";
                this.Ds = this.Da.ExecuteQuery(Sql);

                MessageBox.Show("An Appointment request has sent to Dr." + name);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in booking \n" + exc.Message);
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                FormLogin fl = new FormLogin();
                fl.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in logout \n" + exc.Message);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                this.DPopularGridView(Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in showing data \n" + exc.Message);
            }
        }

        void DPopularGridView(string Sql = "select * from DoctorInformation;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(Sql);

                this.dgvDoctorList.AutoGenerateColumns = false;
                this.dgvDoctorList.DataSource = this.Ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored \n" + exc.Message);
            }
        }
    }
}
