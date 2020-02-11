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
    public partial class FrmCustomerDetails : Form
    {
        public SQLiteConnection conn;

        public FrmCustomerDetails()
        {
            InitializeComponent();
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string mySQL = $@"SELECT *                   
                            FROM 
                        Customer
                           WHERE   Passport_No =  '{textBoxCustomerPassportNumber.Text}'";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow row = dataTable.Rows[i];
                        MessageBox.Show("Customer already exist!");
                        textBoxCustomerName.Text = row["Name"].ToString();
                        textBoxCustomerSurname.Text = row["Surname"].ToString();
                        textBoxCustomerPassportNumber.Text = row["Passport_No"].ToString();
                        textBoxCustomerNationality.Text = row["Nationality"].ToString();
                        textBoxCustomerEmail.Text = row["Email"].ToString();
                        textBoxCustomerPhone.Text = row["Telephone"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("It is a new customer");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                try
                {
                    string mySQL = $@"INSERT 
                            INTO    
                        Customer   ('Name',
                                    'Surname',
                                    'Passport_No', 
                                    'Nationality', 
                                    'Email', 
                                    'Telephone')
                        VALUES   ('{textBoxCustomerName.Text}',
                                  '{textBoxCustomerSurname.Text}',
                                  '{textBoxCustomerPassportNumber.Text}',
                                  '{textBoxCustomerNationality.Text}',
                                  '{textBoxCustomerEmail.Text}',
                                  '{textBoxCustomerPhone.Text}')";

                    conn.Open();
                    SQLiteCommand sqlAdd = new SQLiteCommand(mySQL, conn);
                    sqlAdd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer Details added!");
                }
                catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }
   
        private bool CheckFields()
        {
            if (textBoxCustomerName.Text == "")
            {
                MessageBox.Show("Customer Name is required!");
                return false;
            }

            if (textBoxCustomerSurname.Text == "")
            {
                MessageBox.Show("Customer Surname is required!");
                return false;
            }

            if (textBoxCustomerPassportNumber.Text == "")
            {
                MessageBox.Show("Customer Passport Number is required!");
                return false;
            }

            if (textBoxCustomerNationality.Text == "")
            {
                MessageBox.Show("Customer Nationality is required!");
                return false;
            }

            if (textBoxCustomerEmail.Text == "")
            {
                MessageBox.Show("Customer Email is required!");
                return false;
            }

            if (textBoxCustomerPhone.Text == "")
            {
                MessageBox.Show("Customer Phone is required!");
                return false;
            }

            return true;
        }

        private void buttonCleanForm_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            textBoxCustomerPassportNumber.Text = "";
            textBoxCustomerPassportNumber.Focus();
            textBoxCustomerName.Text = "";
            textBoxCustomerSurname.Text = "";  
            textBoxCustomerNationality.Text = "";
            textBoxCustomerEmail.Text = "";
            textBoxCustomerPhone.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FrmBooking"].Enabled = true;
        }
    }
}
