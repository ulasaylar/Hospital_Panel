using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalRegistration
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister fr = new FrmRegister();
            fr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * From Tbl_Patients Where PatientCitizenID=@p1 and PatientPass=@p2",cnc.connection());
            com.Parameters.AddWithValue("@p1",mTxtID.Text);
            com.Parameters.AddWithValue("@p2",txtPass.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read()) 
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.tc = mTxtID.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Citizen ID Or Password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            cnc.connection().Close();
        }
    }
}
