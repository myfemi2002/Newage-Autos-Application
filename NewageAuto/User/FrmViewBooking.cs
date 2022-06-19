using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewageAuto.User
{
    public partial class FrmViewBooking : Form
    {
        public FrmViewBooking()
        {
            InitializeComponent();
        }

        private void FrmViewBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newageAutosDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.newageAutosDataSet.Booking);

        }
    }
}
