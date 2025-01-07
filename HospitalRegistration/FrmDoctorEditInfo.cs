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
using System.Drawing.Design;
using System.Data.SqlClient;

namespace HospitalRegistration
{
    public partial class FrmDoctorEditInfo : Form
    {
        public FrmDoctorEditInfo()
        {
            InitializeComponent();
        }
        public string docCitID;
        sqlConnection cnc = new sqlConnection();
        private void FrmDoctorEditInfo_Load(object sender, EventArgs e)
        {
            mTxtID.Text= docCitID;

            SqlCommand com = new SqlCommand("Select * From Tbl_Doctors where DoctorCitizenID=@p1",cnc.connection());
            com.Parameters.AddWithValue("@p1",mTxtID.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbDepartment.Text = dr[3].ToString();
                txtPass.Text = dr[5].ToString();
            }
            cnc.connection().Close();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            SqlCommand comUp = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorDepartment=@p3,DoctorPass=@p4 where DoctorCitizenID=@p5",cnc.connection());
            comUp.Parameters.AddWithValue("@p1",txtName.Text);
            comUp.Parameters.AddWithValue("@p2",txtSurname.Text);
            comUp.Parameters.AddWithValue("@p3",cmbDepartment.Text);
            comUp.Parameters.AddWithValue("@p4",txtPass.Text);
            comUp.Parameters.AddWithValue("@p5",mTxtID.Text);
            comUp.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Doctor Updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
