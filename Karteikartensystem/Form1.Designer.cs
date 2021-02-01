
namespace Karteikartensystem
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Willkommen = new System.Windows.Forms.Label();
            this.btn_Lernen_heute = new System.Windows.Forms.Button();
            this.tC_Menüführung = new System.Windows.Forms.TabControl();
            this.tP_Lernen = new System.Windows.Forms.TabPage();
            this.lbl_Anzahl_Einträge_2 = new System.Windows.Forms.Label();
            this.lbl_Anzahl_Einträge_Zahl = new System.Windows.Forms.Label();
            this.lbl_Anzahl_Einträge_1 = new System.Windows.Forms.Label();
            this.lbl_Viel_Spaß = new System.Windows.Forms.Label();
            this.tP_Lerninhalt = new System.Windows.Forms.TabPage();
            this.dGV_Einträge = new System.Windows.Forms.DataGridView();
            this.dGV_Unterkategorie = new System.Windows.Forms.DataGridView();
            this.dGV_Lernfeld = new System.Windows.Forms.DataGridView();
            this.tP_Einstellungen = new System.Windows.Forms.TabPage();
            this.tC_Menüführung.SuspendLayout();
            this.tP_Lernen.SuspendLayout();
            this.tP_Lerninhalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Einträge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Unterkategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Lernfeld)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Willkommen
            // 
            this.lbl_Willkommen.AutoSize = true;
            this.lbl_Willkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Willkommen.Location = new System.Drawing.Point(432, 43);
            this.lbl_Willkommen.Name = "lbl_Willkommen";
            this.lbl_Willkommen.Size = new System.Drawing.Size(285, 31);
            this.lbl_Willkommen.TabIndex = 0;
            this.lbl_Willkommen.Text = "Herzlich Willkommen\r\n";
            // 
            // btn_Lernen_heute
            // 
            this.btn_Lernen_heute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lernen_heute.Location = new System.Drawing.Point(431, 376);
            this.btn_Lernen_heute.Name = "btn_Lernen_heute";
            this.btn_Lernen_heute.Size = new System.Drawing.Size(286, 87);
            this.btn_Lernen_heute.TabIndex = 1;
            this.btn_Lernen_heute.Text = "Lernen heute";
            this.btn_Lernen_heute.UseVisualStyleBackColor = true;
            // 
            // tC_Menüführung
            // 
            this.tC_Menüführung.Controls.Add(this.tP_Lernen);
            this.tC_Menüführung.Controls.Add(this.tP_Lerninhalt);
            this.tC_Menüführung.Controls.Add(this.tP_Einstellungen);
            this.tC_Menüführung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tC_Menüführung.Location = new System.Drawing.Point(0, 0);
            this.tC_Menüführung.Name = "tC_Menüführung";
            this.tC_Menüführung.SelectedIndex = 0;
            this.tC_Menüführung.Size = new System.Drawing.Size(1184, 661);
            this.tC_Menüführung.TabIndex = 5;
            this.tC_Menüführung.SelectedIndexChanged += new System.EventHandler(this.tC_Menüführung_SelectedIndexChanged);
            // 
            // tP_Lernen
            // 
            this.tP_Lernen.Controls.Add(this.lbl_Anzahl_Einträge_2);
            this.tP_Lernen.Controls.Add(this.lbl_Anzahl_Einträge_Zahl);
            this.tP_Lernen.Controls.Add(this.lbl_Anzahl_Einträge_1);
            this.tP_Lernen.Controls.Add(this.lbl_Viel_Spaß);
            this.tP_Lernen.Controls.Add(this.btn_Lernen_heute);
            this.tP_Lernen.Controls.Add(this.lbl_Willkommen);
            this.tP_Lernen.Location = new System.Drawing.Point(4, 22);
            this.tP_Lernen.Name = "tP_Lernen";
            this.tP_Lernen.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Lernen.Size = new System.Drawing.Size(1176, 635);
            this.tP_Lernen.TabIndex = 0;
            this.tP_Lernen.Text = "Lernen";
            this.tP_Lernen.UseVisualStyleBackColor = true;
            // 
            // lbl_Anzahl_Einträge_2
            // 
            this.lbl_Anzahl_Einträge_2.AutoSize = true;
            this.lbl_Anzahl_Einträge_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anzahl_Einträge_2.Location = new System.Drawing.Point(579, 228);
            this.lbl_Anzahl_Einträge_2.Name = "lbl_Anzahl_Einträge_2";
            this.lbl_Anzahl_Einträge_2.Size = new System.Drawing.Size(173, 20);
            this.lbl_Anzahl_Einträge_2.TabIndex = 5;
            this.lbl_Anzahl_Einträge_2.Text = "Einträge für dich bereit.";
            // 
            // lbl_Anzahl_Einträge_Zahl
            // 
            this.lbl_Anzahl_Einträge_Zahl.AutoSize = true;
            this.lbl_Anzahl_Einträge_Zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anzahl_Einträge_Zahl.Location = new System.Drawing.Point(536, 167);
            this.lbl_Anzahl_Einträge_Zahl.Name = "lbl_Anzahl_Einträge_Zahl";
            this.lbl_Anzahl_Einträge_Zahl.Size = new System.Drawing.Size(23, 20);
            this.lbl_Anzahl_Einträge_Zahl.TabIndex = 4;
            this.lbl_Anzahl_Einträge_Zahl.Text = "hi";
            // 
            // lbl_Anzahl_Einträge_1
            // 
            this.lbl_Anzahl_Einträge_1.AutoSize = true;
            this.lbl_Anzahl_Einträge_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anzahl_Einträge_1.Location = new System.Drawing.Point(415, 167);
            this.lbl_Anzahl_Einträge_1.Name = "lbl_Anzahl_Einträge_1";
            this.lbl_Anzahl_Einträge_1.Size = new System.Drawing.Size(106, 20);
            this.lbl_Anzahl_Einträge_1.TabIndex = 3;
            this.lbl_Anzahl_Einträge_1.Text = "Heute stehen";
            // 
            // lbl_Viel_Spaß
            // 
            this.lbl_Viel_Spaß.AutoSize = true;
            this.lbl_Viel_Spaß.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Viel_Spaß.Location = new System.Drawing.Point(490, 344);
            this.lbl_Viel_Spaß.Name = "lbl_Viel_Spaß";
            this.lbl_Viel_Spaß.Size = new System.Drawing.Size(184, 20);
            this.lbl_Viel_Spaß.TabIndex = 2;
            this.lbl_Viel_Spaß.Text = "Viel Spaß beim Lernen:-)";
            // 
            // tP_Lerninhalt
            // 
            this.tP_Lerninhalt.Controls.Add(this.dGV_Einträge);
            this.tP_Lerninhalt.Controls.Add(this.dGV_Unterkategorie);
            this.tP_Lerninhalt.Controls.Add(this.dGV_Lernfeld);
            this.tP_Lerninhalt.Location = new System.Drawing.Point(4, 22);
            this.tP_Lerninhalt.Name = "tP_Lerninhalt";
            this.tP_Lerninhalt.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Lerninhalt.Size = new System.Drawing.Size(1176, 635);
            this.tP_Lerninhalt.TabIndex = 1;
            this.tP_Lerninhalt.Text = "Lerninhalt";
            this.tP_Lerninhalt.UseVisualStyleBackColor = true;
            // 
            // dGV_Einträge
            // 
            this.dGV_Einträge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Einträge.Location = new System.Drawing.Point(699, 73);
            this.dGV_Einträge.Name = "dGV_Einträge";
            this.dGV_Einträge.ReadOnly = true;
            this.dGV_Einträge.Size = new System.Drawing.Size(240, 452);
            this.dGV_Einträge.TabIndex = 2;
            // 
            // dGV_Unterkategorie
            // 
            this.dGV_Unterkategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Unterkategorie.Location = new System.Drawing.Point(379, 73);
            this.dGV_Unterkategorie.Name = "dGV_Unterkategorie";
            this.dGV_Unterkategorie.ReadOnly = true;
            this.dGV_Unterkategorie.Size = new System.Drawing.Size(240, 452);
            this.dGV_Unterkategorie.TabIndex = 1;
            // 
            // dGV_Lernfeld
            // 
            this.dGV_Lernfeld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Lernfeld.Location = new System.Drawing.Point(30, 73);
            this.dGV_Lernfeld.Name = "dGV_Lernfeld";
            this.dGV_Lernfeld.ReadOnly = true;
            this.dGV_Lernfeld.Size = new System.Drawing.Size(240, 452);
            this.dGV_Lernfeld.TabIndex = 0;
            // 
            // tP_Einstellungen
            // 
            this.tP_Einstellungen.Location = new System.Drawing.Point(4, 22);
            this.tP_Einstellungen.Name = "tP_Einstellungen";
            this.tP_Einstellungen.Size = new System.Drawing.Size(1176, 635);
            this.tP_Einstellungen.TabIndex = 2;
            this.tP_Einstellungen.Text = "Einstellungen";
            this.tP_Einstellungen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tC_Menüführung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karteikartensystem";
            this.tC_Menüführung.ResumeLayout(false);
            this.tP_Lernen.ResumeLayout(false);
            this.tP_Lernen.PerformLayout();
            this.tP_Lerninhalt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Einträge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Unterkategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Lernfeld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Willkommen;
        private System.Windows.Forms.Button btn_Lernen_heute;
        private System.Windows.Forms.TabControl tC_Menüführung;
        private System.Windows.Forms.TabPage tP_Lernen;
        private System.Windows.Forms.TabPage tP_Lerninhalt;
        private System.Windows.Forms.TabPage tP_Einstellungen;
        private System.Windows.Forms.Label lbl_Anzahl_Einträge_1;
        private System.Windows.Forms.Label lbl_Viel_Spaß;
        private System.Windows.Forms.Label lbl_Anzahl_Einträge_2;
        private System.Windows.Forms.Label lbl_Anzahl_Einträge_Zahl;
        private System.Windows.Forms.DataGridView dGV_Einträge;
        private System.Windows.Forms.DataGridView dGV_Unterkategorie;
        private System.Windows.Forms.DataGridView dGV_Lernfeld;
    }
}

