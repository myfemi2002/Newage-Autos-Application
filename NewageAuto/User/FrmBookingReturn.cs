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

namespace NewageAuto.User
{
    public partial class FrmBookingReturn : Form
    {
       // public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;
        public FrmBookingReturn()
        {
            InitializeComponent();
        }

        private void FrmBookingReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newageAutosDataSet.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.newageAutosDataSet.Booking);

            dateTimePicker1.CustomFormat = "HH:mm:ss";
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            count();
        }
        private void count()
        {
            string count = (dateTimePicker1.Value - dateTimePicker2.Value).ToString();
            string[] interval = count.Replace("-", "").Substring(0, 8).Split(':');
           // TxtTimeTaken.Text = interval[0] + ":" + interval[1] + ":" + interval[2] + "";
            //TxtTimeTaken.Text = interval[0] + "Hours(s):" + interval[1] + "Minute(s):" + interval[2] + "Second(s)";
            // count();
        }

        private void ClearData()
        {
            TxtCustomer.Clear();
            TxtDate.Clear();
            TxtClientDetails.Clear();
            TxtVechicleNo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            TxtVehicleType.Clear();
            TxtNatOfRental.Clear();
            TxtKmOut.Clear();
            TxtTimeOut.Clear();
            TxtDriversName.Clear();
            CmbPaymentMode.Clear();
            TxtAmount.Clear();
            TxtOfficer.Clear();
        }

        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FEMI-BLAZER\SQLEXPRESS;Initial Catalog=NewageAutos;Integrated Security=True;");
            con.Open();
            if (TxtClientID.Text != "")
            {
                try
                {
                    string getCust = "select Customer,Date,ClientDetails,VehicleNo,NatureOfRental,VehicleType,KmOut,TimeOut,DriversName,PaymentMode,Amount,Officer from Booking where ClientID=" + Convert.ToInt32(TxtClientID.Text) + " ;";
                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        TxtCustomer.Text = dr.GetValue(0).ToString();
                        TxtDate.Text = dr.GetValue(1).ToString();
                        TxtClientDetails.Text = dr.GetValue(2).ToString();
                        TxtVechicleNo.Text = dr.GetValue(3).ToString();
                        TxtVehicleType.Text = dr.GetValue(5).ToString();
                        TxtNatOfRental.Text = dr.GetValue(4).ToString();
                        TxtKmOut.Text = dr.GetValue(6).ToString();
                        TxtTimeOut.Text = dr.GetValue(7).ToString();
                        TxtDriversName.Text = dr.GetValue(8).ToString();
                        CmbPaymentMode.Text = dr.GetValue(9).ToString();
                        TxtAmount.Text = dr.GetValue(10).ToString();
                        TxtOfficer.Text = dr.GetValue(11).ToString();
                    }
                    else
                    {
                        // MessageBox.Show("Sorry '" + TxtClientID.Text + "' This Client ID is not Available, Please Check Id..");
                        TxtCustomer.Text = "";
                        TxtDate.Text = "";
                        TxtClientDetails.Text = "";
                        TxtVechicleNo.Text = "";
                        TxtVehicleType.Text = "";
                        TxtNatOfRental.Text = "";
                        TxtKmOut.Text = "";
                        TxtTimeOut.Text = "";
                        TxtDriversName.Text = "";
                        CmbPaymentMode.Text = "";
                        TxtOfficer.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            count();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            count();
        }
        private void TxtKnIn_TextChanged(object sender, EventArgs e)
        {
            if (TxtKnIn.Text != "")
            {
                int a = Convert.ToInt32(TxtKmOut.Text);
                int b = Convert.ToInt32(TxtKnIn.Text);
                TxtKmCovered.Text = Convert.ToString(b - a);
            }
            else
            {
                TxtKmCovered.Clear();
            }
        }

        Connection con = new Connection();

        private bool IfUsernameExists(string ClientID)
        {
            //Connection con = new Connection();
            con.dataGet("Select 1 From [BookingReturn] WHERE [ClientID]='" + ClientID + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IfUsernameExists(TxtClientID .Text))
            {
                MessageBox.Show("ClientID Already Exist!");
            }
            else
            {
                //ClientID ,Customer,Date,ClientDetails,VehicleNo,NatureOfRental,VehicleType,KmOut,KmIn,KmCovered,TimeOut,TimeIn,TimeTaken,DriversName,PaymentMode,Amount,Officer,Remarks
                // SqlConnection con = new SqlConnection(@"Data Source=FEMI-BLAZER\SQLEXPRESS;Initial Catalog=NewageAutos;Integrated Security=True;");
                con.dataSend(" INSERT INTO [BookingReturn] (ClientID ,Customer,Date,ClientDetails,VehicleNo,NatureOfRental,VehicleType,KmOut,KmIn,KmCovered,TimeOut,TimeIn,TimeTaken,DriversName,PaymentMode,Amount,Officer,Remarks)VALUES" +
                "('" + TxtClientID.Text + "','" + TxtCustomer.Text + "','" + TxtDate.Text + "','" + TxtClientDetails.Text + "','" + TxtVechicleNo.Text + "','" + TxtNatOfRental.Text + "','" + TxtVehicleType.Text + "','" + TxtKmOut.Text + "','" + TxtKnIn.Text + "','" + TxtKmCovered .Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + TxtTimeTaken .Text + "','" + TxtDriversName.Text + "','" + CmbPaymentMode.Text + "','" + TxtAmount.Text + "','" + TxtOfficer.Text + "','" + TxtRemark .Text + "')");
            MessageBox.Show("Succesfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }
    }
   }
}

