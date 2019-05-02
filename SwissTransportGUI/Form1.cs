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

      btnVerbindungen.Enabled = false;
      lstVerbindungen.Columns.Add("Abfahrtszeit", 85);
      lstVerbindungen.Columns.Add("Verspätung", 82);
      lstVerbindungen.Columns.Add("Ankunftszeit", 85);
      lstVerbindungen.Columns.Add("Verspätung", 82);
      lstVerbindungen.Columns.Add("Abfahrtsort", 83);
      lstVerbindungen.Columns.Add("Ankunftsort", 83);
      lstVerbindungen.Columns.Add("Platform", 70);

      lstFahrplan.Columns.Add("Zug ID", 85);
    }
    private void StationSuchen(ListBox aktuelleListBox, TextBox aktuelleTextBox, string gesuchteStation)
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
          btnVerbindungen.Enabled = true;
        }
        else
        {
          btnVerbindungen.Enabled = false;
        }
      }
    }
    private void VerbindungstafelAnzeigen(Connections verbindungen)
    {
      lstVerbindungen.View = View.Details;

      foreach (Connection v in verbindungen.ConnectionList)
      {

        try
        {
          DateTime abfahrt = DateTime.Parse(v.From.Departure);
          DateTime ankunft = DateTime.Parse(v.To.Arrival);
          //TimeSpan dauer = TimeSpan.Parse(v.Duration);

          ListViewItem verbindungsTabelle = new ListViewItem(abfahrt.ToShortTimeString(), 0);
          if (v.From.Delay > 1)
          {
            verbindungsTabelle.SubItems.Add(v.From.Delay.ToString());
          }
          else
          {
            verbindungsTabelle.SubItems.Add("");
          }
          verbindungsTabelle.SubItems.Add(ankunft.ToShortTimeString());
          if (v.To.Delay > 1)
          {
            verbindungsTabelle.SubItems.Add(v.To.Delay.ToString());
          }
          else
          {
            verbindungsTabelle.SubItems.Add("");
          }
          verbindungsTabelle.SubItems.Add(v.From.Station.Name);
          verbindungsTabelle.SubItems.Add(v.To.Station.Name);
          verbindungsTabelle.SubItems.Add(v.From.Platform);


          lstVerbindungen.Items.AddRange(new ListViewItem[] { verbindungsTabelle });
        }
        catch
        {
          ListViewItem verbindungsTabelle = new ListViewItem("Verbindung konnte nicht angezeigt werden", 0);
        }
      }
    }

    private void FahrplantafelAnzeigen(string id)
    {

      StationBoardRoot fahrplanInhalt = t.GetStationBoard(txtStation.Text, id);
      foreach (StationBoard sb in fahrplanInhalt.Entries)
      {
        try
        {
          //DateTime abfahrt = DateTime.Parse(v.From.Departure);
          //DateTime ankunft = DateTime.Parse(v.To.Arrival);
          ////TimeSpan dauer = TimeSpan.Parse(v.Duration);

          ListViewItem fahrplanTabelle = new ListViewItem((sb.Name), 0);
          //fahrplanTabelle.SubItems.Add(ankunft.ToShortTimeString());
          //fahrplanTabelle.SubItems.Add(v.From.Station.Name);
          //fahrplanTabelle.SubItems.Add(v.To.Station.Name);
          //fahrplanTabelle.SubItems.Add(v.From.Platform);


          lstFahrplan.Items.AddRange(new ListViewItem[] { fahrplanTabelle });
        }
        catch
        {
          ListViewItem verbindungsTabelle = new ListViewItem("Verbindung konnte nicht angezeigt werden", 0);
        }
      }
    }

    private string StationWaehlen(ListBox aktuelleListBox, TextBox aktuelleTextBox)
    {
      aktuelleTextBox.Text = aktuelleListBox.SelectedItem.ToString();
      return aktuelleListBox.SelectedIndex.ToString();
    }

    private void txtVon_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstVon, txtVon, txtVon.Text);
    }

    private void lstVon_Click(object sender, EventArgs e)
    {
      StationWaehlen(lstVon, txtVon);
    }

    private void lstNach_Click(object sender, EventArgs e)
    {
      StationWaehlen(lstNach, txtNach);
    }

    private void lstOrt_Click(object sender, EventArgs e)
    {
      string Bahnhofsid = StationWaehlen(lstStation, txtStation);
      FahrplantafelAnzeigen(Bahnhofsid);
    }

    private void txtNach_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstNach, txtNach, txtNach.Text);
    }

    private void txtOrt_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstStation, txtStation, txtStation.Text);
    }

    private void btnVerbindungen_Click(object sender, EventArgs e)
    {
      Connections verbindungen = t.GetConnections(txtVon.Text, txtNach.Text);
      VerbindungstafelAnzeigen(verbindungen);
      
    }
  }
}
