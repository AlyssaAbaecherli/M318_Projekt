using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
 
  public partial class Form1 : Form
  {
    public Transport t = new Transport();
    string[] verbindungsArray = new string[] { "Von", "Bis", "Abfahrtszeit", "Ankunftszeit", "Gleis"};
    public Form1()
    {
      InitializeComponent();

      btnFahrplan.Enabled = false;
    }
    private void StationSuchen(ComboBox aktuelleCombobox, string gesuchteStation) 
    {
      Stations Station = t.GetStations(gesuchteStation);

      aktuelleCombobox.DroppedDown = true;
      aktuelleCombobox.Items.Clear();
      int anzZeichen = aktuelleCombobox.Text.Length;
      aktuelleCombobox.Select(anzZeichen, 0);

      foreach (Station s in Station.StationList)
      {
        try
        {
          aktuelleCombobox.Items.Add(s.Name);
        }
        catch
        {
          //MessageBox.Show("Es wurde kein Resultat gefunden.");
        }
        if(cmbVon.Text.Length != 0 && cmbNach.Text.Length != 0)
        {
          btnFahrplan.Enabled = true;
        }
        else
        {
          btnFahrplan.Enabled = false;
        }
      }
    }


    private void cmbVon_KeyDown(object sender, KeyEventArgs e)//kann nur jeweils 1 Buchstabe auf einmal gelöscht werden
    {
      StationSuchen(cmbVon, cmbVon.Text);
    }

    private void cmbNach_KeyDown(object sender, KeyEventArgs e)//kann nur jeweils 1 Buchstabe auf einmal gelöscht werden
    {
      StationSuchen(cmbNach, cmbNach.Text);
    }

    private void btnFahrplan_Click(object sender, EventArgs e)
    {
      Connections verbindungen = t.GetConnections(cmbVon.Text, cmbNach.Text);
      foreach (Connection v in verbindungen.ConnectionList)
      {
        //try
        //{
        //  //verbindungsListe = (v.From.Station.Name, v.To.Station.Name);

        //  //lstFahrplan.Items.Add(v.Duration);
        //}
        //catch
        //{
        //  lstFahrplan.Items.Add("Keine Verbindung vorhanden");
        //}    
      }
    }
  }
}
