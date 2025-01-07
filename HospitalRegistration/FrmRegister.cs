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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Tbl_Patients(PatientName,PatientSurname,PatientCitizenID,PatientPhone,PatientPass,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", cnc.connection());
            com.Parameters.AddWithValue("@p1", txtName.Text);
            com.Parameters.AddWithValue("@p2", txtSurname.Text);
            com.Parameters.AddWithValue("@p3", mTxtID.Text);
            com.Parameters.AddWithValue("@p4", mTxtPhone.Text);
            com.Parameters.AddWithValue("@p5", txtPass.Text);
            com.Parameters.AddWithValue("@p6", cmbGender.Text);
            com.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Registration Success! Your Password: " + txtPass.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
