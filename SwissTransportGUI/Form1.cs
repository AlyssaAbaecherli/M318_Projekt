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
    private void StationSuchen(ListBox aktuelleListBox, TextBox aktuelleTextBox , string gesuchteStation) 
    {
      Stations Station = t.GetStations(gesuchteStation);

      aktuelleListBox.Items.Clear();
      //aktuelleTextBox.Select(aktuelleTextBox.Text.Length, 0);

      foreach (Station s in Station.StationList)
      {
        try
        {
          if (s.Id != null)
          {
            aktuelleListBox.Items.Add(s.Name);
          }
        }
        catch
        {
          //MessageBox.Show("Es wurde kein Resultat gefunden.");
        }
        if (txtVon.Text.Length != 0 && txtNach.Text.Length != 0)
        {
          btnFahrplan.Enabled = true;
        }
        else
        {
          btnFahrplan.Enabled = false;
        }
      }
    }

    private void StationWählen(ListBox aktuelleListBox, TextBox aktuelleTextBox)
    {
      aktuelleTextBox.Text = aktuelleListBox.SelectedItem.ToString();
    }
    private void txtVon_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstVon, txtVon, txtVon.Text);
    }
    private void lstVon_Click(object sender, EventArgs e)
    {
      StationWählen(lstVon, txtVon);
    }
    
    private void txtNach_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstNach, txtNach, txtNach.Text);
    }
    private void lstNach_Click(object sender, EventArgs e)
    {
      StationWählen(lstNach, txtNach);
    }

    private void btnFahrplan_Click(object sender, EventArgs e)
    {
      Connections verbindungen = t.GetConnections(txtVon.Text, txtNach.Text);
      lstFahrplan.View = View.Details;

      lstFahrplan.Columns.Add("Abfahrtszeit", 80);
      lstFahrplan.Columns.Add("Verspätung", 20);
      lstFahrplan.Columns.Add("Ankunftszeit", 80);
      lstFahrplan.Columns.Add("Verspätung", 20);
      lstFahrplan.Columns.Add("Abfahrtsort", 100);
      lstFahrplan.Columns.Add("Ankunftsort", 100);
      lstFahrplan.Columns.Add("Platform", 100);

      foreach (Connection v in verbindungen.ConnectionList)
      {
        
        try
        {
          DateTime abfahrt = DateTime.Parse(v.From.Departure);
          DateTime ankunft = DateTime.Parse(v.To.Arrival);
          //TimeSpan dauer = TimeSpan.Parse(v.Duration);


          ListViewItem verbindungsTabelle = new ListViewItem(abfahrt.ToShortTimeString(), 0);
          if(v.From.Delay > 1)
          {
            verbindungsTabelle.SubItems.Add("+" + v.From.Delay.ToString());
          }
          else
          {
            verbindungsTabelle.SubItems.Add(""());
          }
          verbindungsTabelle.SubItems.Add(ankunft.ToShortTimeString());
          if (v.To.Delay > 1)
          {
            verbindungsTabelle.SubItems.Add("+" + v.To.Delay.ToString());
          }
          else
          {
            verbindungsTabelle.SubItems.Add(""());
          }
          verbindungsTabelle.SubItems.Add(v.From.Station.Name); 
          verbindungsTabelle.SubItems.Add(v.To.Station.Name);
          verbindungsTabelle.SubItems.Add(v.From.Platform);


          lstFahrplan.Items.AddRange(new ListViewItem[] { verbindungsTabelle });
          }
         catch
         {
          ListViewItem verbindungsTabelle = new ListViewItem("Keine Verbindung vorhanden", 0);
         }    
      }
    }
  }
}
