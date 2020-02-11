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
            this.panelSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(2133, 1068);
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
            this.buttonBookings.Location = new System.Drawing.Point(1843, 29);
            this.buttonBookings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(227, 110);
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
            this.buttonAirports.Location = new System.Drawing.Point(1576, 29);
            this.buttonAirports.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAirports.Name = "buttonAirports";
            this.buttonAirports.Size = new System.Drawing.Size(227, 110);
            this.buttonAirports.TabIndex = 17;
            this.buttonAirports.Text = "Airports";
            this.buttonAirports.UseVisualStyleBackColor = false;
            this.buttonAirports.Click += new System.EventHandler(this.buttonAirports_Click);
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
            this.buttonClose.Location = new System.Drawing.Point(1843, 889);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(227, 110);
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
            this.panel1.Location = new System.Drawing.Point(365, 587);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1437, 215);
            this.panel1.TabIndex = 16;
            // 
            // labelEconomy
            // 
            this.labelEconomy.AutoSize = true;
            this.labelEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEconomy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelEconomy.Location = new System.Drawing.Point(965, 155);
            this.labelEconomy.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEconomy.Name = "labelEconomy";
            this.labelEconomy.Size = new System.Drawing.Size(189, 46);
            this.labelEconomy.TabIndex = 6;
            this.labelEconomy.Text = "Economy";
            this.labelEconomy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBusiness
            // 
            this.labelBusiness.AutoSize = true;
            this.labelBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusiness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBusiness.Location = new System.Drawing.Point(600, 148);
            this.labelBusiness.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelBusiness.Name = "labelBusiness";
            this.labelBusiness.Size = new System.Drawing.Size(182, 46);
            this.labelBusiness.TabIndex = 5;
            this.labelBusiness.Text = "Business";
            this.labelBusiness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonEconomy
            // 
            this.radioButtonEconomy.AutoSize = true;
            this.radioButtonEconomy.Location = new System.Drawing.Point(896, 155);
            this.radioButtonEconomy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonEconomy.Name = "radioButtonEconomy";
            this.radioButtonEconomy.Size = new System.Drawing.Size(33, 32);
            this.radioButtonEconomy.TabIndex = 9;
            this.radioButtonEconomy.TabStop = true;
            this.radioButtonEconomy.UseVisualStyleBackColor = true;
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(536, 155);
            this.radioButtonBusiness.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(33, 32);
            this.radioButtonBusiness.TabIndex = 8;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFirst.Location = new System.Drawing.Point(280, 148);
            this.labelFirst.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(97, 46);
            this.labelFirst.TabIndex = 2;
            this.labelFirst.Text = "First";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(208, 155);
            this.radioButtonFirst.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(33, 32);
            this.radioButtonFirst.TabIndex = 7;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelClass.Location = new System.Drawing.Point(624, 21);
            this.labelClass.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(144, 55);
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
            this.buttonCancel.Location = new System.Drawing.Point(1576, 889);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(227, 110);
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
            this.buttonSearch.Location = new System.Drawing.Point(1304, 889);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(227, 110);
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
            this.panelBookingFilter.Location = new System.Drawing.Point(152, 176);
            this.panelBookingFilter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBookingFilter.Name = "panelBookingFilter";
            this.panelBookingFilter.Size = new System.Drawing.Size(1917, 372);
            this.panelBookingFilter.TabIndex = 0;
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Location = new System.Drawing.Point(389, 286);
            this.comboBoxStop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(260, 39);
            this.comboBoxStop.TabIndex = 5;
            this.comboBoxStop.Visible = false;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelStop.Location = new System.Drawing.Point(379, 200);
            this.labelStop.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(123, 55);
            this.labelStop.TabIndex = 20;
            this.labelStop.Text = "Stop";
            this.labelStop.Visible = false;
            // 
            // dateTimePickerDateLeg
            // 
            this.dateTimePickerDateLeg.Location = new System.Drawing.Point(45, 286);
            this.dateTimePickerDateLeg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePickerDateLeg.Name = "dateTimePickerDateLeg";
            this.dateTimePickerDateLeg.Size = new System.Drawing.Size(263, 38);
            this.dateTimePickerDateLeg.TabIndex = 2;
            this.dateTimePickerDateLeg.Value = new System.DateTime(2020, 2, 10, 12, 17, 44, 0);
            this.dateTimePickerDateLeg.Visible = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(32, 112);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(263, 38);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.Value = new System.DateTime(2020, 2, 10, 12, 17, 36, 0);
            // 
            // labelLegOption
            // 
            this.labelLegOption.AutoSize = true;
            this.labelLegOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLegOption.Location = new System.Drawing.Point(1221, 95);
            this.labelLegOption.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelLegOption.Name = "labelLegOption";
            this.labelLegOption.Size = new System.Drawing.Size(259, 55);
            this.labelLegOption.TabIndex = 9;
            this.labelLegOption.Text = "Leg Option";
            // 
            // checkBoxLegOption
            // 
            this.checkBoxLegOption.AutoSize = true;
            this.checkBoxLegOption.Location = new System.Drawing.Point(1165, 114);
            this.checkBoxLegOption.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxLegOption.Name = "checkBoxLegOption";
            this.checkBoxLegOption.Size = new System.Drawing.Size(34, 33);
            this.checkBoxLegOption.TabIndex = 6;
            this.checkBoxLegOption.UseVisualStyleBackColor = true;
            this.checkBoxLegOption.CheckedChanged += new System.EventHandler(this.checkBoxLegOption_CheckedChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(749, 112);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(260, 39);
            this.comboBoxTo.TabIndex = 4;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTo.Location = new System.Drawing.Point(739, 29);
            this.labelTo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(80, 55);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(389, 112);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(260, 39);
            this.comboBoxFrom.TabIndex = 3;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelFrom.Location = new System.Drawing.Point(379, 29);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(136, 55);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From";
            // 
            // labelDateLeg
            // 
            this.labelDateLeg.AutoSize = true;
            this.labelDateLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateLeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDateLeg.Location = new System.Drawing.Point(35, 200);
            this.labelDateLeg.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDateLeg.Name = "labelDateLeg";
            this.labelDateLeg.Size = new System.Drawing.Size(126, 55);
            this.labelDateLeg.TabIndex = 1;
            this.labelDateLeg.Text = "Date";
            this.labelDateLeg.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(21, 29);
            this.labelDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(126, 55);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1030);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmBooking";
            this.Text = "Cyanair - Booking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
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