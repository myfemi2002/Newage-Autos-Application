namespace NewageAuto.Admin
{
    partial class Expenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCashFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCashFuel = new System.Windows.Forms.TextBox();
            this.TxtVechNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFueExp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTollTicket = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVechMaint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPhoneCard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAllowances = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTransport = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStationary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtParking = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtPostages = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtOfficeRepair = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCashWash = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtOthersPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtOthers = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.newageAutosExpenses = new NewageAuto.NewageAutosExpenses();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new NewageAuto.NewageAutosExpensesTableAdapters.ExpensesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.newageAutosExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(403, 404);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 32);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "2019-09-30";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Date", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cash from R.O(Float)";
            // 
            // TxtCashFrom
            // 
            this.TxtCashFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "CashfromROFloat", true));
            this.TxtCashFrom.Location = new System.Drawing.Point(198, 147);
            this.TxtCashFrom.Name = "TxtCashFrom";
            this.TxtCashFrom.Size = new System.Drawing.Size(145, 26);
            this.TxtCashFrom.TabIndex = 12;
            this.TxtCashFrom.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtCashFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cash For Fuel";
            // 
            // TxtCashFuel
            // 
            this.TxtCashFuel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "CashForFuel", true));
            this.TxtCashFuel.Location = new System.Drawing.Point(198, 193);
            this.TxtCashFuel.Name = "TxtCashFuel";
            this.TxtCashFuel.Size = new System.Drawing.Size(145, 26);
            this.TxtCashFuel.TabIndex = 14;
            this.TxtCashFuel.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtCashFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // TxtVechNo
            // 
            this.TxtVechNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "VechicleNo", true));
            this.TxtVechNo.Location = new System.Drawing.Point(198, 239);
            this.TxtVechNo.Name = "TxtVechNo";
            this.TxtVechNo.Size = new System.Drawing.Size(145, 26);
            this.TxtVechNo.TabIndex = 16;
            this.TxtVechNo.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtVechNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vechicle No";
            // 
            // TxtFueExp
            // 
            this.TxtFueExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "VechicleManintainace", true));
            this.TxtFueExp.Location = new System.Drawing.Point(198, 284);
            this.TxtFueExp.Name = "TxtFueExp";
            this.TxtFueExp.Size = new System.Drawing.Size(145, 26);
            this.TxtFueExp.TabIndex = 18;
            this.TxtFueExp.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtFueExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fuel Expense";
            // 
            // TxtTollTicket
            // 
            this.TxtTollTicket.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "TollTicket", true));
            this.TxtTollTicket.Location = new System.Drawing.Point(488, 201);
            this.TxtTollTicket.Name = "TxtTollTicket";
            this.TxtTollTicket.Size = new System.Drawing.Size(145, 26);
            this.TxtTollTicket.TabIndex = 20;
            this.TxtTollTicket.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtTollTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Toll Ticket  ";
            // 
            // TxtVechMaint
            // 
            this.TxtVechMaint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "VechicleManintainace", true));
            this.TxtVechMaint.Location = new System.Drawing.Point(198, 334);
            this.TxtVechMaint.Name = "TxtVechMaint";
            this.TxtVechMaint.Size = new System.Drawing.Size(145, 26);
            this.TxtVechMaint.TabIndex = 22;
            this.TxtVechMaint.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtVechMaint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vechicle Manintainace";
            // 
            // TxtPhoneCard
            // 
            this.TxtPhoneCard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "PhoneCard", true));
            this.TxtPhoneCard.Location = new System.Drawing.Point(488, 108);
            this.TxtPhoneCard.Name = "TxtPhoneCard";
            this.TxtPhoneCard.Size = new System.Drawing.Size(145, 26);
            this.TxtPhoneCard.TabIndex = 24;
            this.TxtPhoneCard.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtPhoneCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone Card";
            // 
            // TxtAllowances
            // 
            this.TxtAllowances.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Allowances", true));
            this.TxtAllowances.Location = new System.Drawing.Point(488, 159);
            this.TxtAllowances.Name = "TxtAllowances";
            this.TxtAllowances.Size = new System.Drawing.Size(145, 26);
            this.TxtAllowances.TabIndex = 26;
            this.TxtAllowances.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtAllowances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Allowances";
            // 
            // TxtTransport
            // 
            this.TxtTransport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Transport", true));
            this.TxtTransport.Location = new System.Drawing.Point(760, 241);
            this.TxtTransport.Name = "TxtTransport";
            this.TxtTransport.Size = new System.Drawing.Size(145, 26);
            this.TxtTransport.TabIndex = 40;
            this.TxtTransport.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Transport";
            // 
            // TxtStationary
            // 
            this.TxtStationary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Stationery", true));
            this.TxtStationary.Location = new System.Drawing.Point(760, 194);
            this.TxtStationary.Name = "TxtStationary";
            this.TxtStationary.Size = new System.Drawing.Size(145, 26);
            this.TxtStationary.TabIndex = 38;
            this.TxtStationary.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtStationary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Stationery";
            // 
            // TxtParking
            // 
            this.TxtParking.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Parking", true));
            this.TxtParking.Location = new System.Drawing.Point(488, 298);
            this.TxtParking.Name = "TxtParking";
            this.TxtParking.Size = new System.Drawing.Size(145, 26);
            this.TxtParking.TabIndex = 36;
            this.TxtParking.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtParking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Parking";
            // 
            // TxtPostages
            // 
            this.TxtPostages.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Postages", true));
            this.TxtPostages.Location = new System.Drawing.Point(760, 154);
            this.TxtPostages.Name = "TxtPostages";
            this.TxtPostages.Size = new System.Drawing.Size(145, 26);
            this.TxtPostages.TabIndex = 34;
            this.TxtPostages.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtPostages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "Postages";
            // 
            // TxtInternet
            // 
            this.TxtInternet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Internet", true));
            this.TxtInternet.Location = new System.Drawing.Point(760, 111);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(145, 26);
            this.TxtInternet.TabIndex = 32;
            this.TxtInternet.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(673, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Internet ";
            // 
            // TxtOfficeRepair
            // 
            this.TxtOfficeRepair.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "OfficeRepair", true));
            this.TxtOfficeRepair.Location = new System.Drawing.Point(488, 351);
            this.TxtOfficeRepair.Name = "TxtOfficeRepair";
            this.TxtOfficeRepair.Size = new System.Drawing.Size(145, 26);
            this.TxtOfficeRepair.TabIndex = 30;
            this.TxtOfficeRepair.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtOfficeRepair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(365, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = "Office Repair";
            // 
            // TxtCashWash
            // 
            this.TxtCashWash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "CashWash", true));
            this.TxtCashWash.Location = new System.Drawing.Point(488, 245);
            this.TxtCashWash.Name = "TxtCashWash";
            this.TxtCashWash.Size = new System.Drawing.Size(145, 26);
            this.TxtCashWash.TabIndex = 28;
            this.TxtCashWash.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtCashWash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(376, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "Cash Wash";
            // 
            // TxtOthersPrice
            // 
            this.TxtOthersPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "OthersAmount", true));
            this.TxtOthersPrice.Location = new System.Drawing.Point(801, 309);
            this.TxtOthersPrice.Name = "TxtOthersPrice";
            this.TxtOthersPrice.Size = new System.Drawing.Size(104, 26);
            this.TxtOthersPrice.TabIndex = 42;
            this.TxtOthersPrice.TextChanged += new System.EventHandler(this.Exp_TextChange);
            this.TxtOthersPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(673, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 18);
            this.label17.TabIndex = 41;
            this.label17.Text = "Others";
            // 
            // TxtTotal
            // 
            this.TxtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Total", true));
            this.TxtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.TxtTotal.Location = new System.Drawing.Point(760, 351);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(145, 26);
            this.TxtTotal.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(673, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 29);
            this.label18.TabIndex = 43;
            this.label18.Text = "Total";
            // 
            // TxtOthers
            // 
            this.TxtOthers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Others", true));
            this.TxtOthers.Location = new System.Drawing.Point(760, 281);
            this.TxtOthers.Name = "TxtOthers";
            this.TxtOthers.Size = new System.Drawing.Size(145, 26);
            this.TxtOthers.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(771, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // newageAutosExpenses
            // 
            this.newageAutosExpenses.DataSetName = "NewageAutosExpenses";
            this.newageAutosExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.newageAutosExpenses;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 469);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtOthers);
            this.Controls.Add(this.TxtOthersPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtTransport);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtStationary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtParking);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtPostages);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtInternet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtOfficeRepair);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCashWash);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtAllowances);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPhoneCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtVechMaint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtTollTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtFueExp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtVechNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCashFuel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCashFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            ((System.ComponentModel.ISupportInitialize)(this.newageAutosExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCashFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCashFuel;
        private System.Windows.Forms.TextBox TxtVechNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFueExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTollTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVechMaint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPhoneCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAllowances;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTransport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtStationary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtParking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtPostages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtOfficeRepair;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCashWash;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtOthersPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtOthers;
        private System.Windows.Forms.CheckBox checkBox1;
        private NewageAutosExpenses newageAutosExpenses;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private NewageAutosExpensesTableAdapters.ExpensesTableAdapter expensesTableAdapter;
    }
}