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

namespace HospitalRegistration
{
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments",cnc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
