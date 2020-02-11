using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Assignment
{
    public partial class FrmBooking : Form
    {
        public SQLiteConnection conn;
        private bool isAdministrator;

        public FrmBooking(bool isAdmin)
        {
            this.isAdministrator = isAdmin;
            InitializeComponent();
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            ComboBoxFrom();
            if (!isAdministrator)
            {
                buttonAirports.Visible = false;
                buttonBookings.Visible = false;
            }
        }

        private void ComboBoxFrom()
        {
            try
            {
                string mySQL = $@"SELECT Country
                        FROM 
                     Airport
                    ORDER BY Country";
                /*conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();*/

                conn.Open();
                DataSet dataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                dataAdapter.Fill(dataSet, "Airport");
                comboBoxFrom.DisplayMember = "Country";
                comboBoxFrom.ValueMember = "id";
                comboBoxFrom.DataSource = dataSet.Tables["Airport"];

                comboBoxTo.DisplayMember = "Country";
                comboBoxTo.ValueMember = "id";
                comboBoxTo.DataSource = dataSet.Tables["Airport"];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            dateTimePickerDate.Text = "";
            dateTimePickerDateLeg.Text = "";
            comboBoxFrom.Text = "";
            comboBoxTo.Text = "";
            comboBoxStop.Text = "";
            comboBoxStop.Visible = false;
            labelStop.Visible = false;
            checkBoxLegOption.Checked = false;
            radioButtonFirst.Checked = false;
            radioButtonBusiness.Checked = false;
            radioButtonEconomy.Checked = false;
            dateTimePickerDate.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FrmLogIn"].Enabled = true;
        }

        private void checkBoxLegOption_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLegOption.Checked == true)
            {
                comboBoxStop.Visible = true;
                labelStop.Visible = true;
                dateTimePickerDateLeg.Visible = true;
                labelDateLeg.Visible = true;
            } else
            {
                comboBoxStop.Visible = false;
                labelStop.Visible = false;
                dateTimePickerDateLeg.Visible = false;
                labelDateLeg.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            /*If there are tickets - message Ok and next page
              if not message with alert and pls chose another date */

            FrmCustomerDetails formCustomer = new FrmCustomerDetails();

            formCustomer.conn = conn;

            formCustomer.Show();

            this.Enabled = false;
        }

        private void buttonBookings_Click(object sender, EventArgs e)
        {
            FrmBookingsView formBooking = new FrmBookingsView();

            formBooking.conn = conn;

            formBooking.Show();

            this.Enabled = false;
        }

        private void buttonAirports_Click(object sender, EventArgs e)
        {
            FrmAirports formAirports = new FrmAirports();

            formAirports.conn = conn;

            formAirports.Show();

            this.Enabled = false;
        }


        /*public FrmBooking()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            ComboBoxField();

            ComboBoxOperator();

            ComboBoxValueAvailable();
        }
        private void ComboBoxField()
        {
            comboBoxDepart.Items.Add("Make");
            comboBoxDepart.Items.Add("EngineSize");
            comboBoxDepart.Items.Add("RentalPerDay");
            comboBoxDepart.Items.Add("Available");
        }
        private void ComboBoxOperator()
        {
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
        }
        private void ComboBoxValueAvailable()
        {
            comboBoxFrom.Items.Add("Yes");
            comboBoxFrom.Items.Add("No");
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {

            if(!CheckMandatoryFields())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            CheckComboBoxField();

            SelectTblCarFilter();

            AvailableCheckBox();
        }

        private bool CheckMandatoryFields(){

            if (comboBoxDepart.Text != "Available")
            {
                if (comboBoxDepart.Text == "" || cboOperator.Text == "" || textBoxValue.Text == "")
                {
                    return false;
                }
            } else
            {
                if (comboBoxDepart.Text == "" || cboOperator.Text == "" || comboBoxFrom.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void CheckComboBoxField()
        {
            if (comboBoxDepart.Text == "Make")
            {
                mySQLCondition = comboBoxDepart.Text + " " + "LIKE '%" + textBoxValue.Text + "%'";
            }

            if (comboBoxDepart.Text == "EngineSize")
            {
                mySQLCondition = comboBoxDepart.Text + " " + cboOperator.Text + " " + "'" + textBoxValue.Text + "'";
            }

            if (comboBoxDepart.Text == "RentalPerDay")
            {
                Double.Parse(textBoxValue.Text);
                mySQLCondition = comboBoxDepart.Text + " " + cboOperator.Text + " " + textBoxValue.Text;
            }

            if (comboBoxDepart.Text == "Available")
            {
                int availableValue = 0;
                if (comboBoxFrom.Text == "Yes")
                {
                    availableValue = 1;
                }
                mySQLCondition = "Available = " + availableValue;
            }

        }
        private void SelectTblCarFilter()
        {
            try
            {
                string mySQL = $@"SELECT *  
                    FROM 
                  tblCar
                   WHERE   " + mySQLCondition +
              " ORDER BY   VehicleRegNo ; ";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = dataTable;
                dataGridViewSearch.AllowUserToAddRows = false;
                dataGridViewSearch.Columns["uid"].Visible = false;
                dataGridViewSearch.Columns[5].DefaultCellStyle.Format = "c";

                AvailableCheckBox();
            } catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }
        private void AvailableCheckBox()
        {
            foreach (DataGridViewRow row in dataGridViewSearch.Rows)
            {
                DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
                row.Cells[6] = cell;
                row.Cells[6].ReadOnly = true;
            }
        }
        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeComboBoxOperator();
        }
        private void ChangeComboBoxOperator()
        {
            if (comboBoxDepart.Text == "Available" || comboBoxDepart.Text == "Make")
            {
                cboOperator.Enabled = false;
                cboOperator.Text = "=";
            }
            else
            {
                cboOperator.Enabled = true;
            }

            if (comboBoxDepart.Text == "Available")
            {
                textBoxValue.Visible = false;
                comboBoxFrom.Visible = true;
            }
            else
            {
                textBoxValue.Visible = true;
                comboBoxFrom.Visible = false;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FrmCars"].Enabled = true;
        }

        private void FrmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FrmCars"].Enabled = true;
        }*/
    }
}
