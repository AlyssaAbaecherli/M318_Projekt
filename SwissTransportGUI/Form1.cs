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
      string[] nächsteVerbindungen = new string[5];
      int i = 0;
      foreach (Connection v in verbindungen.ConnectionList)
      {
        if (i <= 5)
        {
          
        }
        //  try
        //  {
        //    // lstFahrplan.Items.Add(v.From.Station.Name).SubItems.Add(v.To.Station.Name);


        //  }
        //  catch
        //  {
        //    lstFahrplan.Items.Add("Keine Verbindung vorhanden");
        //}    
      }

      lstFahrplan.View = View.Details;

      lstFahrplan.Columns.Add("Abfahrtsort", 100);
      lstFahrplan.Columns.Add("Ankunftsort", 100);
      lstFahrplan.Columns.Add("Anfahrtszeit", 100);
      lstFahrplan.Columns.Add("Ankunftszeit", 100);
      lstFahrplan.Columns.Add("Ankunftszeit", 100);

      ListViewItem item1 = new ListViewItem("item1", 0);
      

      ListViewItem item2 = new ListViewItem("item2", 1);
      item2.SubItems.Add("21");
      item2.SubItems.Add("22");
      item2.SubItems.Add("23");

      ListViewItem item3 = new ListViewItem("item3", 0);
      item3.SubItems.Add("31");
      item3.SubItems.Add("32");
      item3.SubItems.Add("33");

      ListViewItem item4 = new ListViewItem("item4", 0);
      item4.SubItems.Add("31");
      item4.SubItems.Add("32");
      item4.SubItems.Add("33");

      lstFahrplan.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
    }
  }
}
