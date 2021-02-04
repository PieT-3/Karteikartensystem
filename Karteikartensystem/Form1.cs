﻿using System;
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

        // Tabbedienung (Initialisierung der der einzelnen Tabs)
        private void tC_Menüführung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tC_Menüführung.SelectedIndex == 0)
            {
                lbl_Anzahl_Einträge_Zahl.Text = GetDataLabel("SELECT COUNT(Abfragedatum) FROM tb_Eintrag");
            }
            else if (tC_Menüführung.SelectedIndex == 1)
            {
                dGV_Lernfeld.AutoGenerateColumns = true;
                dGV_Lernfeld.DataSource = GetDataDGV("Select Lernfeldname From tb_Lernfeld As Lernfeldname");
            }
            else { }
        }

        // Aufruf der Unterkategorien, wenn ein Lernfeld angewählt ist
        private void dGV_Lernfeld_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Lernfeld.CurrentCell != null)
            {
                dGV_Unterkategorie.AutoGenerateColumns = true;
                //Ausgewählte Zeile in Variable abspeichern
                String ausgewähltesLernfeld = Convert.ToString(dGV_Lernfeld.Rows[e.RowIndex].Cells[0].Value);

                dGV_Unterkategorie.DataSource = GetDataDGV("SELECT dbo.tb_Unterkategorie.Unterkategoriename AS Unterkategorie " +
                                                        "FROM dbo.tb_Unterkategorie " +
                                                        "INNER JOIN dbo.tb_ZuordnungLernfeldUnterkategorie " +
                                                        "ON dbo.tb_Unterkategorie.UnterkategorieID = dbo.tb_ZuordnungLernfeldUnterkategorie.UnterkategorieID " +
                                                        "INNER JOIN dbo.tb_Lernfeld " +
                                                        "ON dbo.tb_ZuordnungLernfeldUnterkategorie.LernfeldID = dbo.tb_Lernfeld.LernfeldID " +
                                                        $"WHERE(dbo.tb_Lernfeld.Lernfeldname = N'{ausgewähltesLernfeld}')");


                //TODO: Wenn vorhanden, dann werden die Einträge gelöscht, wenn ein anderes Lernfeld ausgewählt wird
                dGV_Einträge.DataSource = null;
            }

        }

        private void dGV_Unterkategorie_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Unterkategorie.CurrentCell != null)
            {
                dGV_Einträge.AutoGenerateColumns = true;
                //Ausgewählte Zeile in Variable abspeichern
                String ausgewählteUnterkategorie = dGV_Unterkategorie.Rows[e.RowIndex].Cells[0].Value.ToString();

                String ausgewähltesLernfeld = dGV_Lernfeld.CurrentRow.Cells[0].Value.ToString();

                dGV_Einträge.DataSource = GetDataEinträge($@"SELECT dbo.tb_A_Seite.A_SeiteInhalt AS[A - Seite], dbo.tb_B_Seite.B_SeiteInhalt AS[B - Seite]
                                                            FROM            dbo.tb_A_Seite INNER JOIN
                                                            dbo.tb_Eintrag ON dbo.tb_A_Seite.A_SeiteID = dbo.tb_Eintrag.A_SeiteID INNER JOIN
                                                            dbo.tb_B_Seite ON dbo.tb_Eintrag.B_SeiteID = dbo.tb_B_Seite.B_SeiteID INNER JOIN
                                                            dbo.tb_ZuordnungUnterkategorieEintrag ON dbo.tb_Eintrag.EintragID = dbo.tb_ZuordnungUnterkategorieEintrag.EintragID INNER JOIN
                                                            dbo.tb_Unterkategorie ON dbo.tb_ZuordnungUnterkategorieEintrag.UnterkategorieID = dbo.tb_Unterkategorie.UnterkategorieID INNER JOIN
                                                             dbo.tb_ZuordnungLernfeldUnterkategorie ON dbo.tb_Unterkategorie.UnterkategorieID = dbo.tb_ZuordnungLernfeldUnterkategorie.UnterkategorieID INNER JOIN
                                                                dbo.tb_Lernfeld ON dbo.tb_ZuordnungLernfeldUnterkategorie.LernfeldID = dbo.tb_Lernfeld.LernfeldID
                                                            WHERE(dbo.tb_Unterkategorie.Unterkategoriename = N'{ausgewählteUnterkategorie}') AND(dbo.tb_Lernfeld.Lernfeldname = N'{ausgewähltesLernfeld}')");

            }
        }



        //Daten aus Datenbank in Label
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

        // Daten aus Datenbank für Mehrer Spalten
        private static DataTable GetDataEinträge(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Karteikartensystem;Data Source=localhost";

            DataTable table = new DataTable();

            using (SqlConnection karteikartensystemConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlCommand, karteikartensystemConnection);

                karteikartensystemConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                table.Load(reader);
            }

            return table;
        }

        // Daten aus Datenbank für eine Spalte
        private static DataTable GetDataDGV(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Karteikartensystem;Data Source=localhost";

            SqlConnection karteikartensystemConnection = new SqlConnection(connectionString);

            //karteikartensystemConnection.Open();

            SqlCommand command = new SqlCommand(sqlCommand, karteikartensystemConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            //karteikartensystemConnection.Close();

            return table;
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
