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
    public partial class Flights : Form
    {
        string connectionstring = ("Data Source=AFFAN-PC;Initial Catalog=DBMSPROJECT;Integrated Security=True");
        public Flights()
        {
            InitializeComponent();
        }

        private void Show_DEP_Flights_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("EXEC Flight_DEP_INFO_Joint_SelectCommand ", sqlCon);
                DataTable dataTable1 = new DataTable();
                sqlDa.Fill(dataTable1);

                dataGridView1.DataSource = dataTable1;
            }

        }

        private void Show_ARR_Flights_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("EXEC Flight_Arrival_INFO_Joint_SelectCommand", sqlCon);
                DataTable dataTable2 = new DataTable();
                sqlDa.Fill(dataTable2);

                dataGridView2.DataSource = dataTable2;
            }

        }
    }
}
