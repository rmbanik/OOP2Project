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
    public partial class FormAppointmentList : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        private string NAME { get; set; }
        public FormAppointmentList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
           //this.PopularGridView();
        }

        public void GetName(string name)
        {
            this.NAME = name;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from dbo.appointmentlist where date = '" + this.dtpDate.Text + "' and dnam = '" + this.NAME + "';";
                this.PopularGridView(this.Sql);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in Showing List \n" + exc.Message);
            }

        }

        void PopularGridView(string Sql )
        {

            try
            {
                this.Ds = this.Da.ExecuteQuery(Sql);

                this.dgvPatientList.AutoGenerateColumns = false;
                this.dgvPatientList.DataSource = this.Ds.Tables[0];

            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored \n" + exc.Message);
            }
        }

        

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from appointmentlist where id like '" + this.txtAutoSearch.Text + "%' ;";
                this.PopularGridView(this.Sql);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in auto search \n" + exc.Message);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from appointmentlist where date = '" + this.dtpDate.Text + "' and dnam = '" + this.NAME + "' ;";
                this.PopularGridView(this.Sql);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in date \n" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          try
            {
                string id = this.dgvPatientList.CurrentRow.Cells[0].Value.ToString();

                this.Sql = @"delete from dbo.appointmentlist
                            where id = '" + id + "';";

                this.Ds = this.Da.ExecuteQuery(Sql);
                //this.PopularGridView();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored in deleting the data \n" + exc.Message);
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
                MessageBox.Show("An Error Occored in Log Out \n" + exc.Message);
            }
        }
    }
}
