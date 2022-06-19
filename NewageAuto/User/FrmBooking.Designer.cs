﻿namespace NewageAuto.User
{
    partial class FrmBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newageAutosDataSet = new NewageAuto.NewageAutosDataSet();
            this.CmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDriversName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtOfficer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNatOfRental = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVehicleType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKmOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtVechicleNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtClientDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.bookingTableAdapter = new NewageAuto.NewageAutosDataSetTableAdapters.BookingTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newageAutosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Date";
            // 
            // TxtDate
            // 
            this.TxtDate.CustomFormat = "MM/dd/yyyy";
            this.TxtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Date", true));
            this.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtDate.Location = new System.Drawing.Point(139, 153);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(200, 26);
            this.TxtDate.TabIndex = 64;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.newageAutosDataSet;
            // 
            // newageAutosDataSet
            // 
            this.newageAutosDataSet.DataSetName = "NewageAutosDataSet";
            this.newageAutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbPaymentMode
            // 
            this.CmbPaymentMode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "PaymentMode", true));
            this.CmbPaymentMode.FormattingEnabled = true;
            this.CmbPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Visa",
            "Mastercard",
            "POS"});
            this.CmbPaymentMode.Location = new System.Drawing.Point(873, 156);
            this.CmbPaymentMode.Name = "CmbPaymentMode";
            this.CmbPaymentMode.Size = new System.Drawing.Size(208, 26);
            this.CmbPaymentMode.TabIndex = 26;
            this.CmbPaymentMode.Text = "Select";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Email/Phone";
            // 
            // TxtDriversName
            // 
            this.TxtDriversName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "DriversName", true));
            this.TxtDriversName.Location = new System.Drawing.Point(873, 92);
            this.TxtDriversName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDriversName.Name = "TxtDriversName";
            this.TxtDriversName.Size = new System.Drawing.Size(208, 26);
            this.TxtDriversName.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(748, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Driver\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(748, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Payment Mode";
            // 
            // TxtAmount
            // 
            this.TxtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Amount", true));
            this.TxtAmount.Location = new System.Drawing.Point(873, 208);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(208, 26);
            this.TxtAmount.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Amount";
            // 
            // TxtOfficer
            // 
            this.TxtOfficer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Officer", true));
            this.TxtOfficer.Location = new System.Drawing.Point(873, 265);
            this.TxtOfficer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtOfficer.Name = "TxtOfficer";
            this.TxtOfficer.Size = new System.Drawing.Size(208, 26);
            this.TxtOfficer.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Officer";
            // 
            // TxtNatOfRental
            // 
            this.TxtNatOfRental.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "NatureOfRental", true));
            this.TxtNatOfRental.Location = new System.Drawing.Point(514, 95);
            this.TxtNatOfRental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNatOfRental.Name = "TxtNatOfRental";
            this.TxtNatOfRental.Size = new System.Drawing.Size(208, 26);
            this.TxtNatOfRental.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nature Of Rental";
            // 
            // TxtVehicleType
            // 
            this.TxtVehicleType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "VehicleType", true));
            this.TxtVehicleType.Location = new System.Drawing.Point(514, 152);
            this.TxtVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtVehicleType.Name = "TxtVehicleType";
            this.TxtVehicleType.Size = new System.Drawing.Size(208, 26);
            this.TxtVehicleType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vehicle Type";
            // 
            // TxtKmOut
            // 
            this.TxtKmOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "KmOut", true));
            this.TxtKmOut.Location = new System.Drawing.Point(514, 211);
            this.TxtKmOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtKmOut.Name = "TxtKmOut";
            this.TxtKmOut.Size = new System.Drawing.Size(208, 26);
            this.TxtKmOut.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Km Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Time Out";
            // 
            // TxtVechicleNo
            // 
            this.TxtVechicleNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "VehicleNo", true));
            this.TxtVechicleNo.Location = new System.Drawing.Point(139, 270);
            this.TxtVechicleNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtVechicleNo.Name = "TxtVechicleNo";
            this.TxtVechicleNo.Size = new System.Drawing.Size(208, 26);
            this.TxtVechicleNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle No";
            // 
            // TxtClientDetails
            // 
            this.TxtClientDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "ClientDetails", true));
            this.TxtClientDetails.Location = new System.Drawing.Point(139, 212);
            this.TxtClientDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtClientDetails.Name = "TxtClientDetails";
            this.TxtClientDetails.Size = new System.Drawing.Size(208, 26);
            this.TxtClientDetails.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Details";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(486, 326);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 41);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer/Client";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Customer", true));
            this.TxtCustomer.Location = new System.Drawing.Point(139, 97);
            this.TxtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(208, 26);
            this.TxtCustomer.TabIndex = 0;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "00:00:00";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "TimeOut", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 26);
            this.dateTimePicker1.TabIndex = 69;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 18);
            this.label16.TabIndex = 68;
            this.label16.Text = "Time Out";
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 379);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbPaymentMode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtOfficer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtDriversName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKmOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtVehicleType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNatOfRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVechicleNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtClientDetails);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBooking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newageAutosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TxtDate;
        private System.Windows.Forms.ComboBox CmbPaymentMode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDriversName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtOfficer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNatOfRental;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVehicleType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKmOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtVechicleNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtClientDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCustomer;
        private NewageAutosDataSet newageAutosDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private NewageAutosDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
    }
}