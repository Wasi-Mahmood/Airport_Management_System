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

namespace DBMS_PROJECT_winform
{
    public partial class Tickets : Form
    {
        string connectionstring = ("Data Source=AFFAN-PC;Initial Catalog=DBMSPROJECT;Integrated Security=True");
        public Tickets()
        {
            InitializeComponent();
        }

        private void BookingREF_Serach_BTN_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("EXEC Search_Via_Booking_REF_Tickects_Joint_SelectCommand " +  BookingRefSearch_txtBox.Text,sqlCon);
                DataTable dataTable1 = new DataTable();
                sqlDa.Fill(dataTable1);

                dataGridView1.DataSource = dataTable1;
            }

            

        }
    }
}
