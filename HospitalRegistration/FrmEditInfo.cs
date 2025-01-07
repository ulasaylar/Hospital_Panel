using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalRegistration
{
    public partial class FrmEditInfo : Form
    {
        public FrmEditInfo()
        {
            InitializeComponent();
        }
        public string citID;
        sqlConnection cnc = new sqlConnection();
        private void FrmEditInfo_Load(object sender, EventArgs e)
        {
            mTxtID.Text = citID;
            SqlCommand com = new SqlCommand("Select * From Tbl_Patients where PatientCitizenID=@p1", cnc.connection());
            com.Parameters.AddWithValue("@p1", citID);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mTxtPhone.Text = dr[4].ToString();
                txtPass.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            cnc.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand("Update Tbl_Patients set PatientName=@p1,PatientSurname=@p2,PatientPhone=@p3,PatientPass=@p4,PatientGender=@p5 where PatientCitizenID=@p6",cnc.connection());
            com2.Parameters.AddWithValue("@p1",txtName.Text);        
            com2.Parameters.AddWithValue("@p2",txtSurname.Text);        
            com2.Parameters.AddWithValue("@p3",mTxtPhone.Text);        
            com2.Parameters.AddWithValue("@p4",txtPass.Text);        
            com2.Parameters.AddWithValue("@p5",cmbGender.Text);        
            com2.Parameters.AddWithValue("@p6",mTxtID.Text);
            com2.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Your information has been updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
