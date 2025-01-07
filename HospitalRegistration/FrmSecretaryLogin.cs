using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistration
{
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        sqlConnection cnc = new sqlConnection();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * From Tbl_Secretary where SecretaryCitizenID=@p1 and SecretaryPass=@p2", cnc.connection());
            com.Parameters.AddWithValue("@p1",mTxtID.Text);
            com.Parameters.AddWithValue("@p2",txtPass.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetail fr = new FrmSecretaryDetail();
                fr.citID = mTxtID.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Citizen ID Or Password","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            cnc.connection().Close();
        }
    }
}
