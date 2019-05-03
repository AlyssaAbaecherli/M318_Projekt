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

      lstFahrplan.Columns.Add("Zug", 85);
      lstFahrplan.Columns.Add("Zielort", 85);
      lstFahrplan.Columns.Add("Zeit", 85);
    }
    private void StationSuchen(ListBox aktuelleListBox, TextBox aktuelleTextBox, string gesuchteStation)
    {
      Stations Station = t.GetStations(gesuchteStation);

      aktuelleListBox.Items.Clear();////////////////////////////////////////////////////////////////////////

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
      lstVerbindungen.Items.Clear();

      foreach (Connection v in verbindungen.ConnectionList)
      {

        try
        {
          DateTime abfahrt = DateTime.Parse(v.From.Departure);
          DateTime ankunft = DateTime.Parse(v.To.Arrival);

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
      lstFahrplan.Items.Clear();

      StationBoardRoot fahrplanInhalt = t.GetStationBoard(txtStation.Text, id);

      if (fahrplanInhalt != null)
      {
        foreach (StationBoard sb in fahrplanInhalt.Entries)
        {
          try
          {

            ListViewItem fahrplanTabelle = new ListViewItem((sb.Name), 0);
            fahrplanTabelle.SubItems.Add(sb.To);
            fahrplanTabelle.SubItems.Add(sb.Stop.Departure.ToShortTimeString());

            lstFahrplan.Items.AddRange(new ListViewItem[] { fahrplanTabelle });
          }
          catch
          {
            ListViewItem verbindungsTabelle = new ListViewItem("Fahrplan konnte nicht angezeigt werden", 0);
          }
        }
      }
    }

    private string StationWaehlen(ListBox aktuelleListBox, TextBox aktuelleTextBox)
    {
      try
      {
        aktuelleTextBox.Text = aktuelleListBox.SelectedItem.ToString();
        string id = aktuelleListBox.SelectedIndex.ToString();
        aktuelleListBox.Items.Clear();
        return id;
      }
      catch
      {
        return null;
      }
    }
    private void FahrplanTafel()
    {
      string Bahnhofsid = StationWaehlen(lstStation, txtStation);
      FahrplantafelAnzeigen(Bahnhofsid);
    }

    private void verbindungenSuchen()
    {
      Connections verbindungen = t.GetConnections(txtVon.Text, txtNach.Text);
      VerbindungstafelAnzeigen(verbindungen);
    }

    private void bewegen(KeyEventArgs e, ListBox lstBox, TextBox txtBox)
    {
      try
      {
        if (e.KeyCode == Keys.Down)
        {
          lstBox.SelectedIndex++;
        }
        else if (e.KeyCode == Keys.Up)
        {
          lstBox.SelectedIndex--;
        }
        else if (e.KeyCode == Keys.Enter)///////////////////////////////
        {
          StationWaehlen(lstBox, txtBox);
          if (lstBox == lstVon || lstBox == lstNach)
          {
            verbindungenSuchen();
          }
          else
          {
            FahrplanTafel();
          }
        }
      }
      catch
      {
      }
    }


    ///////////////////////////////////////////////////////


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

    private void lstStation_Click(object sender, EventArgs e)
    {
      FahrplanTafel();
    }

    private void txtNach_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstNach, txtNach, txtNach.Text);
    }

    private void txtStation_TextChanged(object sender, EventArgs e)
    {
      StationSuchen(lstStation, txtStation, txtStation.Text);
    }

    private void btnVerbindungen_Click(object sender, EventArgs e)
    {
      verbindungenSuchen();
    }

    private void btnWechseln_Click(object sender, EventArgs e)
    {
      string wechseln = txtNach.Text;
      txtNach.Text = txtVon.Text;
      txtVon.Text = wechseln;
    }

    private void btnLeeren_Click(object sender, EventArgs e)
    {
      lstVerbindungen.Items.Clear();
      txtVon.Text = "";
      txtNach.Text = "";
    }

    private void btnFahrplanLeeren_Click(object sender, EventArgs e)
    {
      lstFahrplan.Items.Clear();
      txtStation.Text = "";
    }

    private void txtVon_KeyDown(object sender, KeyEventArgs e)
    {
      bewegen(e, lstVon, txtVon);
    }

    private void txtNach_KeyDown(object sender, KeyEventArgs e)
    {
      bewegen(e, lstNach, txtNach);
    }

    private void txtStation_KeyDown(object sender, KeyEventArgs e)
    {
      bewegen(e, lstStation, txtStation);
    }
  }
}