namespace Assignment
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.buttonAirports = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEconomy = new System.Windows.Forms.Label();
            this.labelBusiness = new System.Windows.Forms.Label();
            this.radioButtonEconomy = new System.Windows.Forms.RadioButton();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.labelFirst = new System.Windows.Forms.Label();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelBookingFilter = new System.Windows.Forms.Panel();
            this.comboBoxStop = new System.Windows.Forms.ComboBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.dateTimePickerDateLeg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelLegOption = new System.Windows.Forms.Label();
            this.checkBoxLegOption = new System.Windows.Forms.CheckBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelDateLeg = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBookingFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Black;
            this.panelSearch.Controls.Add(this.buttonBookings);
            this.panelSearch.Controls.Add(this.buttonAirports);
            this.panelSearch.Controls.Add(this.buttonClose);
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.buttonCancel);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.panelBookingFilter);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 448);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonBookings
            // 
            this.buttonBookings.BackColor = System.Drawing.Color.Black;
            this.buttonBookings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBookings.Location = new System.Drawing.Point(691, 12);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(85, 46);
            this.buttonBookings.TabIndex = 18;
            this.buttonBookings.Text = "Bookings";
            this.buttonBookings.UseVisualStyleBackColor = false;
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            // 
            // buttonAirports
            // 
            this.buttonAirports.BackColor = System.Drawing.Color.Black;
            this.buttonAirports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAirports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAirports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAirports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAirports.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAirports.Location = new System.Drawing.Point(591, 12);
            this.buttonAirports.Name = "buttonAirports";
            this.buttonAirports.Size = new System.Drawing.Size(85, 46);
            this.buttonAirports.TabIndex = 17;
            this.buttonAirports.Text = "Airports";
            this.buttonAirports.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Location = new System.Drawing.Point(691, 373);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 46);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEconomy);
            this.panel1.Controls.Add(this.labelBusiness);
            this.panel1.Controls.Add(this.radioButtonEconomy);
            this.panel1.Controls.Add(this.radioButtonBusiness);
            this.panel1.Controls.Add(this.labelFirst);
            this.panel1.Controls.Add(this.radioButtonFirst);
            this.panel1.Controls.Add(this.labelClass);
            this.panel1.Location = new System.Drawing.Point(137, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 90);
            this.panel1.TabIndex = 16;
            // 
            // labelEconomy
            // 
            this.labelEconomy.AutoSize = true;
            this.labelEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelEconomy.Location = new System.Drawing.Point(362, 65);
            this.labelEconomy.Name = "labelEconomy";
            this.labelEconomy.Size = new System.Drawing.Size(75, 20);
            this.labelEconomy.TabIndex = 6;
            this.labelEconomy.Text = "Economy";
            this.labelEconomy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBusiness
            // 
            this.labelBusiness.AutoSize = true;
            this.labelBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusiness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBusiness.Location = new System.Drawing.Point(225, 62);
            this.labelBusiness.Name = "labelBusiness";
            this.labelBusiness.Size = new System.Drawing.Size(74, 20);
            this.labelBusiness.TabIndex = 5;
            this.labelBusiness.Text = "Business";
            this.labelBusiness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonEconomy
            // 
            this.radioButtonEconomy.AutoSize = true;
            this.radioButtonEconomy.Location = new System.Drawing.Point(336, 65);
            this.radioButtonEconomy.Name = "radioButtonEconomy";
            this.radioButtonEconomy.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEconomy.TabIndex = 9;
            this.radioButtonEconomy.TabStop = true;
            this.radioButtonEconomy.UseVisualStyleBackColor = true;
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(201, 65);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBusiness.TabIndex = 8;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFirst.Location = new System.Drawing.Point(105, 62);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(40, 20);
            this.labelFirst.TabIndex = 2;
            this.labelFirst.Text = "First";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(78, 65);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(14, 13);
            this.radioButtonFirst.TabIndex = 7;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelClass.Location = new System.Drawing.Point(234, 9);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(55, 24);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.Location = new System.Drawing.Point(591, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 46);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.Location = new System.Drawing.Point(489, 373);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 46);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelBookingFilter
            // 
            this.panelBookingFilter.Controls.Add(this.comboBoxStop);
            this.panelBookingFilter.Controls.Add(this.labelStop);
            this.panelBookingFilter.Controls.Add(this.dateTimePickerDateLeg);
            this.panelBookingFilter.Controls.Add(this.dateTimePickerDate);
            this.panelBookingFilter.Controls.Add(this.labelLegOption);
            this.panelBookingFilter.Controls.Add(this.checkBoxLegOption);
            this.panelBookingFilter.Controls.Add(this.comboBoxTo);
            this.panelBookingFilter.Controls.Add(this.labelTo);
            this.panelBookingFilter.Controls.Add(this.comboBoxFrom);
            this.panelBookingFilter.Controls.Add(this.labelFrom);
            this.panelBookingFilter.Controls.Add(this.labelDateLeg);
            this.panelBookingFilter.Controls.Add(this.labelDate);
            this.panelBookingFilter.Location = new System.Drawing.Point(57, 74);
            this.panelBookingFilter.Name = "panelBookingFilter";
            this.panelBookingFilter.Size = new System.Drawing.Size(719, 156);
            this.panelBookingFilter.TabIndex = 0;
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Location = new System.Drawing.Point(146, 120);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStop.TabIndex = 5;
            this.comboBoxStop.Visible = false;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelStop.Location = new System.Drawing.Point(142, 84);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(48, 24);
            this.labelStop.TabIndex = 20;
            this.labelStop.Text = "Stop";
            this.labelStop.Visible = false;
            // 
            // dateTimePickerDateLeg
            // 
            this.dateTimePickerDateLeg.Location = new System.Drawing.Point(17, 120);
            this.dateTimePickerDateLeg.Name = "dateTimePickerDateLeg";
            this.dateTimePickerDateLeg.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDateLeg.TabIndex = 2;
            this.dateTimePickerDateLeg.Value = new System.DateTime(2020, 2, 10, 12, 17, 44, 0);
            this.dateTimePickerDateLeg.Visible = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 47);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.Value = new System.DateTime(2020, 2, 10, 12, 17, 36, 0);
            // 
            // labelLegOption
            // 
            this.labelLegOption.AutoSize = true;
            this.labelLegOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLegOption.Location = new System.Drawing.Point(458, 40);
            this.labelLegOption.Name = "labelLegOption";
            this.labelLegOption.Size = new System.Drawing.Size(103, 24);
            this.labelLegOption.TabIndex = 9;
            this.labelLegOption.Text = "Leg Option";
            // 
            // checkBoxLegOption
            // 
            this.checkBoxLegOption.AutoSize = true;
            this.checkBoxLegOption.Location = new System.Drawing.Point(437, 48);
            this.checkBoxLegOption.Name = "checkBoxLegOption";
            this.checkBoxLegOption.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLegOption.TabIndex = 6;
            this.checkBoxLegOption.UseVisualStyleBackColor = true;
            this.checkBoxLegOption.CheckedChanged += new System.EventHandler(this.checkBoxLegOption_CheckedChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(281, 47);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTo.TabIndex = 4;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTo.Location = new System.Drawing.Point(277, 12);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(33, 24);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(146, 47);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFrom.TabIndex = 3;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFrom.Location = new System.Drawing.Point(142, 12);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(55, 24);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From";
            // 
            // labelDateLeg
            // 
            this.labelDateLeg.AutoSize = true;
            this.labelDateLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateLeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDateLeg.Location = new System.Drawing.Point(13, 84);
            this.labelDateLeg.Name = "labelDateLeg";
            this.labelDateLeg.Size = new System.Drawing.Size(48, 24);
            this.labelDateLeg.TabIndex = 1;
            this.labelDateLeg.Text = "Date";
            this.labelDateLeg.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(8, 12);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 24);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.panelSearch);
            this.Name = "FrmBooking";
            this.Text = "Cyanair - Booking";
            this.panelSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBookingFilter.ResumeLayout(false);
            this.panelBookingFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelBookingFilter;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelDateLeg;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBusiness;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelEconomy;
        private System.Windows.Forms.Label labelBusiness;
        private System.Windows.Forms.RadioButton radioButtonEconomy;
        private System.Windows.Forms.Label labelLegOption;
        private System.Windows.Forms.CheckBox checkBoxLegOption;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateLeg;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxStop;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Button buttonBookings;
        private System.Windows.Forms.Button buttonAirports;
    }
}