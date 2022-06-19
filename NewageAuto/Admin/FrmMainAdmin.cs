using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewageAuto.Admin
{
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBooking frm = new User.FrmBooking();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Admin.Expenses frm = new Admin.Expenses();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Summary frm = new Admin.Summary();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void bookingReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBookingReturn frm = new User.FrmBookingReturn();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBooking frm = new User.FrmBooking();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void bookinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FrmBookingReturn frm = new User.FrmBookingReturn();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
