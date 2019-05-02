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
      foreach (Connection v in verbindungen.ConnectionList)
      {
        // try
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
