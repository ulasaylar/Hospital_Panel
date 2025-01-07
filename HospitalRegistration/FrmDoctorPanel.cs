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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doctors", cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand comDep = new SqlCommand("Select DepartmentName From Tbl_Departments",cnc.connection());
            SqlDataReader cd = comDep.ExecuteReader();
            while (cd.Read())
            {
                cmbDepartment.Items.Add(cd[0]);
            }
            cnc.connection().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorDepartment,DoctorCitizenID,DoctorPass) values (@d1,@d2,@d3,@d4,@d5)",cnc.connection());
            com.Parameters.AddWithValue("@d1",txtName.Text);
            com.Parameters.AddWithValue("@d2",txtSurname.Text);
            com.Parameters.AddWithValue("@d3",cmbDepartment.Text);
            com.Parameters.AddWithValue("@d4",mTxtCitID.Text);
            com.Parameters.AddWithValue("@d5",txtPass.Text);
            com.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Doctor Added","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text= dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtSurname.Text= dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbDepartment.Text= dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mTxtCitID.Text= dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtPass.Text= dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand comDel = new SqlCommand("Delete From Tbl_Doctors where DoctorCitizenID=@i1",cnc.connection());
            comDel.Parameters.AddWithValue("@i1",mTxtCitID.Text);
            comDel.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Doctor Deleted","Warning",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand comUp = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorDepartment=@p3,DoctorPass=@p5 where DoctorCitizenID=@p4",cnc.connection());
            comUp.Parameters.AddWithValue("@p1", txtName.Text);
            comUp.Parameters.AddWithValue("@p2", txtSurname.Text);
            comUp.Parameters.AddWithValue("@p3", cmbDepartment.Text);
            comUp.Parameters.AddWithValue("@p4", mTxtCitID.Text);
            comUp.Parameters.AddWithValue("@p5", txtPass.Text);
            comUp.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Doctor Info Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
