using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistration
{
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        public string citID;
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblCitID.Text = citID;

            SqlCommand com = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretaryCitizenID=@p1",cnc.connection());
            com.Parameters.AddWithValue("@p1", lblCitID.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                lblNameSurname.Text = dr[0].ToString();
            }
            cnc.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select DepartmentName From Tbl_Departments", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' '+ DoctorSurname)as Doctor ,DoctorDepartment From Tbl_Doctors",cnc.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand com2 = new SqlCommand("Select DepartmentName From Tbl_Departments",cnc.connection());
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbDepartment.Items.Add(dr2[0].ToString());
            }
            cnc.connection().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand comSave = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentTime,AppointmentDepartment,AppointmentDoctor,AppointmentStatus,PatientCitizenID) values (@a1,@a2,@a3,@a4,@a5,@a6)", cnc.connection());
            comSave.Parameters.AddWithValue("@a1",mTxtDate.Text);
            comSave.Parameters.AddWithValue("@a2",mTxtTime.Text);
            comSave.Parameters.AddWithValue("@a3",cmbDepartment.Text);
            comSave.Parameters.AddWithValue("@a4",cmbDoctor.Text);
            comSave.Parameters.AddWithValue("@a5",chkStatus.Checked);
            comSave.Parameters.AddWithValue("@a6",mTxtCitID.Text);
            comSave.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Appointment Saved","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand com3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorDepartment=@p1",cnc.connection());
            com3.Parameters.AddWithValue("@p1",cmbDepartment.Text);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0]+ " "+ dr3[1]);
            }
            cnc.connection().Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand com4 = new SqlCommand("insert into Tbl_Announcements (Announcement) values (@a1)",cnc.connection());
            com4.Parameters.AddWithValue("@a1",rTxtAnnoun.Text);
            com4.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Announcement Created");
        }

        private void btnDocPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel dp = new FrmDoctorPanel();
            dp.Show();
        }

        private void btnDepPanel_Click(object sender, EventArgs e)
        {
            FrmDepartmentPanel dp = new FrmDepartmentPanel();
            dp.Show();
        }

        private void btnAppList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList al = new FrmAppointmentList();
            al.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show();
        }
    }
}
