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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        public string tc;
        sqlConnection cnc = new sqlConnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblCitID.Text = tc;
            SqlCommand com = new SqlCommand("Select PatientName,PatientSurname From Tbl_Patients Where PatientCitizenID=@p1",cnc.connection());
            com.Parameters.AddWithValue("@p1",lblCitID.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + " " + dr[1];
            }
            cnc.connection().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentStatus=1 and PatientCitizenID=@p1", cnc.connection());
            da.SelectCommand.Parameters.AddWithValue("@p1",lblCitID.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand com2 = new SqlCommand("Select DepartmentName From Tbl_Departments", cnc.connection());
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbDepartment.Items.Add(dr2[0]);
            }
            cnc.connection().Close();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand com3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors Where DoctorDepartment=@p1", cnc.connection());
            com3.Parameters.AddWithValue("@p1", cmbDepartment.Text);
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            cnc.connection().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments Where AppointmentDepartment='" + cmbDepartment.Text+ "'" + " and AppointmentDoctor='" + cmbDoctor.Text+"' and AppointmentStatus=0",cnc.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInfo fr = new FrmEditInfo();
            fr.citID = lblCitID.Text;
            fr.Show();          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Update Tbl_Appointments Set AppointmentStatus=1,PatientCitizenID=@p1,PatientComplaint=@p2 where AppointmentID=@p3",cnc.connection());
            com.Parameters.AddWithValue("@p1",lblCitID.Text);
            com.Parameters.AddWithValue("@p2",rTxtComplaint.Text);
            com.Parameters.AddWithValue("@p3",txtID.Text);
            com.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Appointment Saved","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
