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
    public partial class FrmAirports : Form
    {
        public SQLiteConnection conn;
        public FrmAirports()
        {
            InitializeComponent();
        }

        private void FrmAirports_Load(object sender, EventArgs e)
        {
            SelectAirports();
        }

        private void SelectAirports()
        {
            try
            {
                string mySQL = $@"SELECT ID, Country, City, Airport_Name
                        FROM Airport 
                        Where logicDelete = 'False'";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                dataGridViewAirports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewAirports.DataSource = dataTable;
                dataGridViewAirports.AllowUserToAddRows = false;

                if (dataGridViewAirports.Columns["Action"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Action";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    int columnIndex = 4;

                    dataGridViewAirports.Columns.Insert(columnIndex, deleteButtonColumn);
                    dataGridViewAirports.CellClick += dataGridViewSoftware_CellClick;
                }

                dataGridViewAirports.Columns["ID"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAirports.Columns["Action"].Index)
            {
                try
                {
                    string mySQL = $@"UPDATE Airport SET logicDelete = 'true' WHERE Id = {dataGridViewAirports.Rows[e.RowIndex].Cells[0].Value.ToString()}";
                    conn.Open();
                    SQLiteCommand sqlUpd = new SQLiteCommand(mySQL, conn);
                    sqlUpd.ExecuteNonQuery();
                    conn.Close();
                    SelectAirports();
                }
                catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }

        private void buttonAddAirport_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                try
                {
                    string mySQL = $@"INSERT 
                            INTO    
                         Airport   ('Country',
                                    'City',
                                    'Airport_Name', 
                                    'logicDelete')
                        VALUES   ('{textBoxCountry.Text}',
                                  '{textBoxCity.Text}',
                                  '{textBoxAirport_Name.Text}',
                                  'False')";

                    conn.Open();
                    SQLiteCommand sqlAdd = new SQLiteCommand(mySQL, conn);
                    sqlAdd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Airport added!");
                    SelectAirports();
                }
                catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }

        private bool CheckFields()
        {
            if (textBoxCountry.Text == "")
            {
                MessageBox.Show("Country is required!");
                return false;
            }

            if (textBoxCity.Text == "")
            {
                MessageBox.Show("City is required!");
                return false;
            }

            if (textBoxAirport_Name.Text == "")
            {
                MessageBox.Show("Airport name is required!");
                return false;
            }

            return true;
        }
    }
}
