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
    public partial class FrmUserMain : Form
    {
        public FrmUserMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBooking frm = new User.FrmBooking();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void BookingReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBookingReturn frm = new User.FrmBookingReturn();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void ViewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmViewBooking frm = new User.FrmViewBooking();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
