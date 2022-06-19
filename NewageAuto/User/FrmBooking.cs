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
    public partial class FrmBooking : Form
    {

        public FrmBooking()
        {
            InitializeComponent();
        }
        
        private void FrmBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newageAutosDataSet.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.newageAutosDataSet.Booking);

            dateTimePicker1.CustomFormat = "HH:mm:ss";
            count();
        }

        private void count()
        {
            string count = (dateTimePicker1.Value ).ToString();
        }
        Connection con = new Connection();
        private void ClearData()
        {
            TxtCustomer.Clear();
            TxtDate.Value = DateTime.Now;
            TxtClientDetails.Clear();
            TxtVechicleNo.Clear();
            TxtVehicleType.Clear();
            TxtNatOfRental.Clear();
            TxtKmOut.Clear();
            dateTimePicker1.Value = DateTime.Now;
            TxtDriversName.Clear();
            CmbPaymentMode.SelectedIndex = -1;
            TxtAmount.Clear();
            TxtOfficer.Clear();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
           con.dataSend(" INSERT INTO [Booking] (Customer,Date,ClientDetails,VehicleNo,NatureOfRental,VehicleType,KmOut,TimeOut,DriversName,PaymentMode,Amount,Officer)VALUES('" + TxtCustomer.Text + "','" + TxtDate.Value.ToString("MM/dd/yyyy") + "','" + TxtClientDetails.Text + "','" + TxtVechicleNo.Text + "','" + TxtNatOfRental.Text + "','" + TxtVehicleType.Text + "','" + TxtKmOut.Text + "','" + dateTimePicker1.Text + "','" + TxtDriversName.Text + "','" + CmbPaymentMode.Text + "','" + TxtAmount.Text + "','" + TxtOfficer.Text + "')");
            MessageBox.Show("Succesfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            count();
        }
    }
}
