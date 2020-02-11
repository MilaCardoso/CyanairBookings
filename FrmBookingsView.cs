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
    public partial class FrmBookingsView : Form
    {
        public SQLiteConnection conn;
        public FrmBookingsView()
        {
            InitializeComponent();
        }

        private void FrmBookingsView_Load(object sender, EventArgs e)
        {
            SelectBookings();
        }

        private void SelectBookings()
        {
            try
            {
                string mySQL = $@"SELECT C.Name, C.Surname, F.Date, A.Airport_Name AS Depart, AA.Airport_Name AS Dest
                        FROM Booking AS B
                        LEFT JOIN Customer AS C ON C.Id = B.Customer_Id
                        LEFT JOIN Flight AS F ON F.Id = B.Flight_Id
                        LEFT JOIN Airport AS A ON A.Id = F.Depart_Airport_Id
                        LEFT JOIN Airport AS AA ON AA.Id = F.Dest_Airport_Id";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBookings.DataSource = dataTable;
                dataGridViewBookings.AllowUserToAddRows = false;
                //dataGridViewBookings.Columns["Airport_Id"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }
    }
}
