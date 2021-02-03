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

            try
            {
                lbl_Anzahl_Einträge_Zahl.Text = GetDataLabel("SELECT COUNT(Abfragedatum) FROM tb_Eintrag");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler mit der Datenbank.\n {ex}");
                throw;
            }
        }


        // Test Daten aus Datenbank in Label
        private static String GetDataLabel(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Karteikartensystem;Data Source=localhost";

            String ergebnis;

            using (SqlConnection karteikartensystemConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlCommand, karteikartensystemConnection);

                karteikartensystemConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                ergebnis = reader.GetInt32(0).ToString();
            }

            return ergebnis;
        }

        // Daten aus Datenbank abrufen
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





        // Tabbedienung (Initialisierung der der einzelnen Tabs)
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
            else{}
        }

        // Aufruf der Unterkategorien, wenn ein Lernfeld angewählt ist
        private void dGV_Lernfeld_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Lernfeld.CurrentCell != null)
            {
                dGV_Unterkategorie.AutoGenerateColumns = true;
                //Ausgewählte Zeile in Variable abspeichern
                String ausgewähltesLernfeld = Convert.ToString(dGV_Lernfeld.Rows[e.RowIndex].Cells[0].Value);

                dGV_Unterkategorie.DataSource = GetData("SELECT dbo.tb_Unterkategorie.Unterkategoriename AS Unterkategorie " +
                                                        "FROM dbo.tb_Unterkategorie " +
                                                        "INNER JOIN dbo.tb_ZuordnungLernfeldUnterkategorie " +
                                                        "ON dbo.tb_Unterkategorie.UnterkategorieID = dbo.tb_ZuordnungLernfeldUnterkategorie.UnterkategorieID " +
                                                        "INNER JOIN dbo.tb_Lernfeld " +
                                                        "ON dbo.tb_ZuordnungLernfeldUnterkategorie.LernfeldID = dbo.tb_Lernfeld.LernfeldID " +
                                                        $"WHERE(dbo.tb_Lernfeld.Lernfeldname = N'{ausgewähltesLernfeld}')");
            }

        }

        private void btn_Lerninhalt_verändern_Click(object sender, EventArgs e)
        {
            if (btn_Lerninhalt_verändern.Text == "Lerninhalt ändern")
            {
                dGV_Lernfeld.ReadOnly = false;
                dGV_Unterkategorie.ReadOnly = false;
                dGV_Einträge.ReadOnly = false;

                btn_Lerninhalt_verändern.Text = "Bearbeitungsmodus verlassen";
            }
            else
            {
                dGV_Lernfeld.ReadOnly = true;
                dGV_Unterkategorie.ReadOnly = true;
                dGV_Einträge.ReadOnly = true;

                btn_Lerninhalt_verändern.Text = "Lerninhalt ändern";
            }
        }

        private void btn_Lernen_heute_Click(object sender, EventArgs e)
        {

            if (btn_Lernen_heute.Text == "Lernen heute")
            {
                dGV_Lernfeld.ReadOnly = false;
                dGV_Unterkategorie.ReadOnly = false;
                dGV_Einträge.ReadOnly = false;

                btn_Lerninhalt_verändern.Text = "Lernen unterbrechen";
            }
            else
            {
                dGV_Lernfeld.ReadOnly = true;
                dGV_Unterkategorie.ReadOnly = true;
                dGV_Einträge.ReadOnly = true;

                btn_Lerninhalt_verändern.Text = "Lernen heute";
            }

        }
    }
}
