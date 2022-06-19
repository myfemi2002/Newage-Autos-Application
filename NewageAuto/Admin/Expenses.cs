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

namespace NewageAuto.Admin
{
    public partial class Expenses : Form
    {

        // public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        Double  aa = 0; Double bb = 0; Double cc = 0; Double dd = 0; Double ee = 0; Double ff = 0;
        Double gg = 0; Double hh = 0; Double ii = 0; Double jj = 0; Double kk = 0; Double ll = 0;
        Double mm = 0; Double nn = 0; Double oo = 0; Double pp = 0;
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newageAutosExpenses.Expenses' table. You can move, or remove it, as needed.
           // this.expensesTableAdapter.Fill(this.newageAutosExpenses.Expenses);
            TxtOthers.Enabled = false;
            TxtOthersPrice.Enabled = false;
        }
        private void ClearData()
        {
            dateTimePicker1.Value = DateTime.Now;
            TxtCashFrom.Clear();
            TxtCashFuel.Clear();
            TxtVechNo.Clear();
            TxtFueExp.Clear();
            TxtVechMaint.Clear();
            TxtPhoneCard.Clear();
            TxtAllowances.Clear();
            TxtTollTicket.Clear();
            TxtCashWash.Clear();
            TxtParking.Clear();
            TxtOfficeRepair.Clear();
            TxtInternet.Clear();
            TxtPostages.Clear();
            TxtStationary.Clear();
            TxtTransport.Clear();
            TxtOthers.Clear();
            TxtOthersPrice.Clear();
            TxtTotal.Clear();
        }
        //private void BtnTotal_Click(object sender, EventArgs e)
        //{
        //    //    //dateTimePicker1
        //    //    //TxtCashFrom
        //    //    //TxtCashFuel
        //    //    //TxtVechNo
        //    //    //TxtFueExp
        //    //    //TxtVechMaint
        //    //    //TxtPhoneCard
        //    //    //TxtAllowances
        //    //    //TxtTollTicket
        //    //    //TxtCashWash
        //    //    //TxtParking
        //    //    //TxtOfficeRepair
        //    //    //TxtInternet
        //    //    //TxtPostages
        //    //    //TxtStationary
        //    //    //TxtTransport
        //    //    //TxtOthers
        //    //    //TxtTotal

        //}

    private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    //MessageBox.Show("Number Only Please !", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void Exp_TextChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCashFrom.Text))
            {
                TxtCashFrom.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtCashFuel.Text))
            {
                TxtCashFuel.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtVechNo.Text))
            {
                TxtVechNo.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtFueExp.Text))
            {
                TxtFueExp.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtVechMaint.Text))
            {
                TxtVechMaint.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtPhoneCard.Text))
            {
                TxtPhoneCard.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtPhoneCard.Text))
            {
                TxtPhoneCard.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtAllowances.Text))
            {
                TxtAllowances.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtTollTicket.Text))
            {
                TxtTollTicket.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtOfficeRepair.Text))
            {
                TxtOfficeRepair.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtInternet.Text))
            {
                TxtInternet.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtPostages.Text))
            {
                TxtPostages.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtStationary.Text))
            {
                TxtStationary.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtOthersPrice.Text))
            {
                TxtOthersPrice.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtCashWash.Text))
            {
                TxtCashWash.Text = "0";
            }

            if (string.IsNullOrEmpty(TxtParking.Text))
            {
                TxtParking.Text = "0";
            }
            if (string.IsNullOrEmpty(TxtTransport.Text))
            {
                TxtTransport.Text = "0";
            }
            aa = Double.Parse(TxtCashFrom.Text.Trim());
            bb = Double.Parse(TxtCashFuel.Text);
            cc = Double.Parse(TxtVechNo.Text);
            dd = Double.Parse(TxtFueExp.Text);
            ee = Double.Parse(TxtVechMaint.Text);
            ff = Double.Parse(TxtPhoneCard.Text);
            gg = Double.Parse(TxtAllowances.Text);
            hh = Double.Parse(TxtTollTicket.Text);
            ii = Double.Parse(TxtOfficeRepair.Text);
            jj = Double.Parse(TxtInternet.Text);
            kk = Double.Parse(TxtPostages.Text);
            ll = Double.Parse(TxtStationary.Text);
            mm = Double.Parse(TxtOthersPrice.Text);
            nn = Double.Parse(TxtCashWash.Text);
            oo = Double.Parse(TxtParking.Text);
            pp = Double.Parse(TxtTransport.Text);
            TxtTotal.Text = Convert.ToString(aa + bb + cc + dd + ee + ff + gg + hh + ii + jj + kk + ll + mm + nn + oo + pp);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox )sender ).Checked )
            {
                TxtOthers.Enabled = true;
                TxtOthersPrice.Enabled = true;
            }
            else
            {
                TxtOthers.Enabled = false;
                TxtOthersPrice.Enabled = false;
            }
        }

            Connection con = new Connection();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=FEMI-BLAZER\SQLEXPRESS;Initial Catalog=NewageAutos;Integrated Security=True;");
            //Date,CashfromROFloat,CashForFuel,VechicleNo,FuelExpense,VechicleManintainace,PhoneCard,Allowances,TollTicket,CashWash,Parking,OfficeRepair,Internet,Postages,Stationery,Transport,Others,OthersAmount,Total

            con.dataSend(" INSERT INTO [Expenses] (Date, CashfromROFloat, CashForFuel, VechicleNo, FuelExpense, VechicleManintainace, PhoneCard, Allowances, TollTicket, CashWash, Parking, OfficeRepair, Internet, Postages, Stationery, Transport, Others, OthersAmount, Total)VALUES" +
            "('" + dateTimePicker1.Value.ToString("yyyy-dd-MM") + "', '" + TxtCashFrom.Text + "','" + TxtCashFuel .Text + "','" + TxtVechNo .Text + "','" + TxtFueExp .Text + "','" + TxtVechMaint .Text + "','" + TxtPhoneCard .Text + "','" + TxtAllowances .Text + "','" + TxtTollTicket .Text + "','" + TxtCashWash .Text + "','" + TxtParking .Text + "','" + TxtOfficeRepair.Text + "','" + TxtInternet .Text + "','" + TxtPostages .Text + "','" + TxtStationary .Text + "','" + TxtTransport .Text + "','" + TxtOthers.Text + "','" + TxtOthersPrice .Text + "','" + TxtTotal .Text + "')");
            MessageBox.Show("Succesfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }
    }
}
