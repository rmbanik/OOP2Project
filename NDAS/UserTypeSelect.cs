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
    public partial class UserTypeSelect : Form
    {
        public UserTypeSelect()
        {
            InitializeComponent();
            this.radioButton1.Checked = false;
            this.rbtnPatient.Checked = false;
           
        }

        private void rbtnDoctor(object sender, MouseEventArgs e)
        {
            try
            {
                DoctorForm df = new DoctorForm();
                df.Visible = true;
                this.Visible = false;
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored\n" + exc.Message);
            }
        }

        private void Patient_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                PatientForm pf = new PatientForm();
                pf.Visible = true;
                this.Visible = false;
            }

            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored \n" + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                FormLogin fl = new FormLogin();
                fl.Visible = true;
                this.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occored \n" + exc.Message);
            }
        }
    }
}
