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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }
        public string citID;
        sqlConnection cnc = new sqlConnection();
        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            LblCitizenID.Text = citID;

            SqlCommand com = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorCitizenID=@p1",cnc.connection());
            com.Parameters.AddWithValue("@p1",citID);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            cnc.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentDoctor='"+LblNameSurname.Text+"'",cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmDoctorEditInfo fr = new FrmDoctorEditInfo();
            fr.docCitID = citID;
            fr.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fra = new FrmAnnouncements();
            fra.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            rTxtComplaint.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
