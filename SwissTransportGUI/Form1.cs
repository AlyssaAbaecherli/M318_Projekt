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

    }
    private void StationSuchen(ComboBox aktuelleCombobox, string gesuchteStation) //<-- beinhaltet Fehler
    {
      Stations myStation = t.GetStations(gesuchteStation);
      foreach (Station s in myStation.StationList)
      {
        try
        {
          aktuelleCombobox.Items.Add(s.Name);
        }
        catch
        {
          MessageBox.Show("Es wurde kein Resultat gefunden.");
        }
      }
    }

    private void cmbVon_KeyDown(object sender, KeyEventArgs e)
    {
      //StationSuchen(cmbVon ,cmbVon.Text);
    }
  }
}
