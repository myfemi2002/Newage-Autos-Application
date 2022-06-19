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

namespace NewageAuto
{
    public partial class FrmLogin : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public DataTable dt;
        public string pkk;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEMI-BLAZER\SQLEXPRESS;Initial Catalog=NewageAutos;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username ='" + TxtUsername.Text + "' and Password='" + TxtPassword.Text + "' and Role ='" + CmbUser.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Role from Login Where Username ='" + TxtUsername.Text + "' and Password='" + TxtPassword.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "Admin")
                {
                    this.Hide();
                    Admin.FrmMainAdmin AdminMain = new Admin.FrmMainAdmin();
                    AdminMain.Show();
                }
                else
                {
                    if (dt1.Rows[0][0].ToString() == "User")
                    {
                        this.Hide();
                        User.FrmUserMain UserMain = new User.FrmUserMain();
                        UserMain.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show(" Invalid Username & Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
      }
   }

