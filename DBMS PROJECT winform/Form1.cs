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
    public partial class Form1 : Form
    {
        


        Flights FL = new Flights();
        Terminal TRM = new Terminal();
        Tickets TK = new Tickets();
        Passengers PSG = new Passengers();
        Airline AIR = new Airline();
        Aircrafts AR = new Aircrafts();
        Boarded_Passengers BO_PAS = new Boarded_Passengers();
        Passport PASS = new Passport(); 



        public Form1()
        {
            InitializeComponent();
        }


        //Airline_btn
        

        private void Flights_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FL.Show();
        }

        private void Terminal_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRM.Show();
        }

        private void Tickets_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TK.Show();
        }

        private void Passengers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PSG.Show();
        }

        private void Airlines_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AIR.Show();
        }

        private void Aircrafts_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AR.Show();
        }

        private void Boarded_passengers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BO_PAS.Show();
        }

        private void Passport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PASS.Show();
        }
    }
}
