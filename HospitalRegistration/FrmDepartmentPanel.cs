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
    public partial class FrmDepartmentPanel : Form
    {
        public FrmDepartmentPanel()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void FrmDepartmentPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Departments",cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Tbl_Departments (DepartmentName) values (@p1)",cnc.connection());
            com.Parameters.AddWithValue("@p1",txtDepName.Text);
            com.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Department Added","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtDepID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtDepName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand comDel = new SqlCommand("Delete From Tbl_Departments where DepartmentID=@p1",cnc.connection());
            comDel.Parameters.AddWithValue("@p1",txtDepID.Text);
            comDel.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Department Deleted","Info",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand comUp = new SqlCommand("Update Tbl_Departments set DepartmentName=@p1 where DepartmentID=@p2",cnc.connection());
            comUp.Parameters.AddWithValue("@p1",txtDepName.Text);
            comUp.Parameters.AddWithValue("@p2",txtDepID.Text);
            comUp.ExecuteNonQuery();
            cnc.connection().Close();
            MessageBox.Show("Department Updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
