using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karteikartensystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //lbl_Anzahl_Einträge_Zahl.Text = GetData("SELECT Abfragedatum FROM tb_Eintrag");


            //dGV_Listen2.AutoGenerateColumns = true;
            //dGV_Listen2.DataSource = GetData("Select Lernfeldname From tb_Lernfeld As Lernfeldname"); 
        }

        private static String GetDataLabel3(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Karteikartensystem;Data Source=localhost";

            SqlConnection karteikartensystemConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, karteikartensystemConnection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            String ergebnis = table.ToString();

            return ergebnis;



            //SqlDataReader reader = command.ExecuteReader();

            //String Ausgabe = Convert.ToString(reader);

            //return Ausgabe;
        }

        


        private static DataTable GetData(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Karteikartensystem;Data Source=localhost";

            SqlConnection karteikartensystemConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, karteikartensystemConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void tC_Menüführung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tC_Menüführung.SelectedIndex == 0)
            {
                // Dann lade die aktuelle Anzahl der zu lernenden Karten
            }
            else if (tC_Menüführung.SelectedIndex == 1)
            {
                dGV_Lernfeld.AutoGenerateColumns = true;
                dGV_Lernfeld.DataSource = GetData("Select Lernfeldname From tb_Lernfeld As Lernfeldname");
            }
            else 
            {
                // Noch keine Infos, was passieren soll
            }



        }
    }
}
