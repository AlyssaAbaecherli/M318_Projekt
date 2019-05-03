namespace SwissTransportGUI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.verbindungSuchen = new System.Windows.Forms.TabPage();
      this.btnLeeren = new System.Windows.Forms.Button();
      this.btnWechseln = new System.Windows.Forms.Button();
      this.txtNach = new System.Windows.Forms.TextBox();
      this.lstNach = new System.Windows.Forms.ListBox();
      this.txtVon = new System.Windows.Forms.TextBox();
      this.lstVon = new System.Windows.Forms.ListBox();
      this.lstVerbindungen = new System.Windows.Forms.ListView();
      this.btnVerbindungen = new System.Windows.Forms.Button();
      this.lblVon = new System.Windows.Forms.Label();
      this.lblNach = new System.Windows.Forms.Label();
      this.fahrplan = new System.Windows.Forms.TabPage();
      this.lstFahrplan = new System.Windows.Forms.ListView();
      this.btnFahrplanLeeren = new System.Windows.Forms.Button();
      this.lblStation = new System.Windows.Forms.Label();
      this.lstStation = new System.Windows.Forms.ListBox();
      this.txtStation = new System.Windows.Forms.TextBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.webStationSuchen = new System.Windows.Forms.WebBrowser();
      this.lstStationSuchen = new System.Windows.Forms.ListBox();
      this.txtStationSuchen = new System.Windows.Forms.TextBox();
      this.lblStationSuchen = new System.Windows.Forms.Label();
      this.tabControl.SuspendLayout();
      this.verbindungSuchen.SuspendLayout();
      this.fahrplan.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.verbindungSuchen);
      this.tabControl.Controls.Add(this.fahrplan);
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Location = new System.Drawing.Point(-4, 1);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(824, 552);
      this.tabControl.TabIndex = 0;
      // 
      // verbindungSuchen
      // 
      this.verbindungSuchen.BackColor = System.Drawing.Color.Transparent;
      this.verbindungSuchen.Controls.Add(this.btnLeeren);
      this.verbindungSuchen.Controls.Add(this.btnWechseln);
      this.verbindungSuchen.Controls.Add(this.txtNach);
      this.verbindungSuchen.Controls.Add(this.lstNach);
      this.verbindungSuchen.Controls.Add(this.txtVon);
      this.verbindungSuchen.Controls.Add(this.lstVon);
      this.verbindungSuchen.Controls.Add(this.lstVerbindungen);
      this.verbindungSuchen.Controls.Add(this.btnVerbindungen);
      this.verbindungSuchen.Controls.Add(this.lblVon);
      this.verbindungSuchen.Controls.Add(this.lblNach);
      this.verbindungSuchen.Location = new System.Drawing.Point(4, 25);
      this.verbindungSuchen.Name = "verbindungSuchen";
      this.verbindungSuchen.Padding = new System.Windows.Forms.Padding(3);
      this.verbindungSuchen.Size = new System.Drawing.Size(816, 523);
      this.verbindungSuchen.TabIndex = 0;
      this.verbindungSuchen.Text = "Verbindung suchen";
      // 
      // btnLeeren
      // 
      this.btnLeeren.Image = ((System.Drawing.Image)(resources.GetObject("btnLeeren.Image")));
      this.btnLeeren.Location = new System.Drawing.Point(655, 40);
      this.btnLeeren.Name = "btnLeeren";
      this.btnLeeren.Size = new System.Drawing.Size(50, 49);
      this.btnLeeren.TabIndex = 5;
      this.btnLeeren.UseVisualStyleBackColor = true;
      this.btnLeeren.Click += new System.EventHandler(this.btnLeeren_Click);
      // 
      // btnWechseln
      // 
      this.btnWechseln.Image = ((System.Drawing.Image)(resources.GetObject("btnWechseln.Image")));
      this.btnWechseln.Location = new System.Drawing.Point(572, 40);
      this.btnWechseln.Name = "btnWechseln";
      this.btnWechseln.Size = new System.Drawing.Size(50, 49);
      this.btnWechseln.TabIndex = 4;
      this.btnWechseln.UseVisualStyleBackColor = true;
      this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
      // 
      // txtNach
      // 
      this.txtNach.Location = new System.Drawing.Point(258, 53);
      this.txtNach.Name = "txtNach";
      this.txtNach.Size = new System.Drawing.Size(193, 22);
      this.txtNach.TabIndex = 2;
      this.txtNach.TextChanged += new System.EventHandler(this.txtNach_TextChanged);
      this.txtNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNach_KeyDown);
      // 
      // lstNach
      // 
      this.lstNach.FormattingEnabled = true;
      this.lstNach.ItemHeight = 16;
      this.lstNach.Location = new System.Drawing.Point(258, 71);
      this.lstNach.Name = "lstNach";
      this.lstNach.Size = new System.Drawing.Size(193, 68);
      this.lstNach.TabIndex = 21;
      this.lstNach.TabStop = false;
      this.lstNach.Click += new System.EventHandler(this.lstNach_Click);
      // 
      // txtVon
      // 
      this.txtVon.Location = new System.Drawing.Point(29, 53);
      this.txtVon.Name = "txtVon";
      this.txtVon.Size = new System.Drawing.Size(193, 22);
      this.txtVon.TabIndex = 1;
      this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
      this.txtVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVon_KeyDown);
      // 
      // lstVon
      // 
      this.lstVon.FormattingEnabled = true;
      this.lstVon.ItemHeight = 16;
      this.lstVon.Location = new System.Drawing.Point(29, 71);
      this.lstVon.Name = "lstVon";
      this.lstVon.Size = new System.Drawing.Size(193, 68);
      this.lstVon.TabIndex = 16;
      this.lstVon.TabStop = false;
      this.lstVon.Click += new System.EventHandler(this.lstVon_Click);
      // 
      // lstVerbindungen
      // 
      this.lstVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstVerbindungen.Location = new System.Drawing.Point(29, 170);
      this.lstVerbindungen.Name = "lstVerbindungen";
      this.lstVerbindungen.Size = new System.Drawing.Size(758, 318);
      this.lstVerbindungen.TabIndex = 14;
      this.lstVerbindungen.TabStop = false;
      this.lstVerbindungen.UseCompatibleStateImageBehavior = false;
      this.lstVerbindungen.View = System.Windows.Forms.View.Details;
      // 
      // btnVerbindungen
      // 
      this.btnVerbindungen.Image = ((System.Drawing.Image)(resources.GetObject("btnVerbindungen.Image")));
      this.btnVerbindungen.Location = new System.Drawing.Point(488, 40);
      this.btnVerbindungen.Name = "btnVerbindungen";
      this.btnVerbindungen.Size = new System.Drawing.Size(50, 49);
      this.btnVerbindungen.TabIndex = 3;
      this.btnVerbindungen.UseVisualStyleBackColor = true;
      this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
      // 
      // lblVon
      // 
      this.lblVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblVon.AutoSize = true;
      this.lblVon.Location = new System.Drawing.Point(26, 33);
      this.lblVon.Name = "lblVon";
      this.lblVon.Size = new System.Drawing.Size(37, 17);
      this.lblVon.TabIndex = 12;
      this.lblVon.Text = "Von:";
      // 
      // lblNach
      // 
      this.lblNach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNach.AutoSize = true;
      this.lblNach.Location = new System.Drawing.Point(255, 33);
      this.lblNach.Name = "lblNach";
      this.lblNach.Size = new System.Drawing.Size(45, 17);
      this.lblNach.TabIndex = 13;
      this.lblNach.Text = "Nach:";
      // 
      // fahrplan
      // 
      this.fahrplan.BackColor = System.Drawing.Color.Transparent;
      this.fahrplan.Controls.Add(this.lstFahrplan);
      this.fahrplan.Controls.Add(this.btnFahrplanLeeren);
      this.fahrplan.Controls.Add(this.lblStation);
      this.fahrplan.Controls.Add(this.lstStation);
      this.fahrplan.Controls.Add(this.txtStation);
      this.fahrplan.Location = new System.Drawing.Point(4, 25);
      this.fahrplan.Name = "fahrplan";
      this.fahrplan.Padding = new System.Windows.Forms.Padding(3);
      this.fahrplan.Size = new System.Drawing.Size(816, 523);
      this.fahrplan.TabIndex = 1;
      this.fahrplan.Text = "Fahrplan";
      // 
      // lstFahrplan
      // 
      this.lstFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstFahrplan.Location = new System.Drawing.Point(29, 170);
      this.lstFahrplan.Name = "lstFahrplan";
      this.lstFahrplan.Size = new System.Drawing.Size(749, 329);
      this.lstFahrplan.TabIndex = 26;
      this.lstFahrplan.TabStop = false;
      this.lstFahrplan.UseCompatibleStateImageBehavior = false;
      this.lstFahrplan.View = System.Windows.Forms.View.Details;
      // 
      // btnFahrplanLeeren
      // 
      this.btnFahrplanLeeren.Image = ((System.Drawing.Image)(resources.GetObject("btnFahrplanLeeren.Image")));
      this.btnFahrplanLeeren.Location = new System.Drawing.Point(270, 40);
      this.btnFahrplanLeeren.Name = "btnFahrplanLeeren";
      this.btnFahrplanLeeren.Size = new System.Drawing.Size(50, 49);
      this.btnFahrplanLeeren.TabIndex = 2;
      this.btnFahrplanLeeren.UseVisualStyleBackColor = true;
      this.btnFahrplanLeeren.Click += new System.EventHandler(this.btnFahrplanLeeren_Click);
      // 
      // lblStation
      // 
      this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblStation.AutoSize = true;
      this.lblStation.Location = new System.Drawing.Point(26, 33);
      this.lblStation.Name = "lblStation";
      this.lblStation.Size = new System.Drawing.Size(56, 17);
      this.lblStation.TabIndex = 25;
      this.lblStation.Text = "Station:";
      // 
      // lstStation
      // 
      this.lstStation.FormattingEnabled = true;
      this.lstStation.ItemHeight = 16;
      this.lstStation.Location = new System.Drawing.Point(29, 71);
      this.lstStation.Name = "lstStation";
      this.lstStation.Size = new System.Drawing.Size(193, 68);
      this.lstStation.TabIndex = 23;
      this.lstStation.TabStop = false;
      this.lstStation.Click += new System.EventHandler(this.lstStation_Click);
      // 
      // txtStation
      // 
      this.txtStation.Location = new System.Drawing.Point(29, 53);
      this.txtStation.Name = "txtStation";
      this.txtStation.Size = new System.Drawing.Size(193, 22);
      this.txtStation.TabIndex = 1;
      this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
      this.txtStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyDown);
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.Transparent;
      this.tabPage1.Controls.Add(this.webStationSuchen);
      this.tabPage1.Controls.Add(this.lstStationSuchen);
      this.tabPage1.Controls.Add(this.txtStationSuchen);
      this.tabPage1.Controls.Add(this.lblStationSuchen);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Size = new System.Drawing.Size(816, 523);
      this.tabPage1.TabIndex = 2;
      this.tabPage1.Text = "Station suchen";
      // 
      // webStationSuchen
      // 
      this.webStationSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webStationSuchen.Location = new System.Drawing.Point(29, 170);
      this.webStationSuchen.MinimumSize = new System.Drawing.Size(20, 20);
      this.webStationSuchen.Name = "webStationSuchen";
      this.webStationSuchen.Size = new System.Drawing.Size(749, 329);
      this.webStationSuchen.TabIndex = 31;
      this.webStationSuchen.TabStop = false;
      // 
      // lstStationSuchen
      // 
      this.lstStationSuchen.FormattingEnabled = true;
      this.lstStationSuchen.ItemHeight = 16;
      this.lstStationSuchen.Location = new System.Drawing.Point(29, 71);
      this.lstStationSuchen.Name = "lstStationSuchen";
      this.lstStationSuchen.Size = new System.Drawing.Size(193, 68);
      this.lstStationSuchen.TabIndex = 29;
      this.lstStationSuchen.TabStop = false;
      this.lstStationSuchen.Click += new System.EventHandler(this.lstStationSuchen_Click);
      // 
      // txtStationSuchen
      // 
      this.txtStationSuchen.Location = new System.Drawing.Point(29, 53);
      this.txtStationSuchen.Name = "txtStationSuchen";
      this.txtStationSuchen.Size = new System.Drawing.Size(193, 22);
      this.txtStationSuchen.TabIndex = 28;
      this.txtStationSuchen.TextChanged += new System.EventHandler(this.txtStationSuchen_TextChanged);
      this.txtStationSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStationSuchen_KeyDown);
      // 
      // lblStationSuchen
      // 
      this.lblStationSuchen.AutoSize = true;
      this.lblStationSuchen.Location = new System.Drawing.Point(26, 33);
      this.lblStationSuchen.Name = "lblStationSuchen";
      this.lblStationSuchen.Size = new System.Drawing.Size(56, 17);
      this.lblStationSuchen.TabIndex = 1;
      this.lblStationSuchen.Text = "Station:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(816, 551);
      this.Controls.Add(this.tabControl);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tabControl.ResumeLayout(false);
      this.verbindungSuchen.ResumeLayout(false);
      this.verbindungSuchen.PerformLayout();
      this.fahrplan.ResumeLayout(false);
      this.fahrplan.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage verbindungSuchen;
    private System.Windows.Forms.TextBox txtNach;
    private System.Windows.Forms.ListBox lstNach;
    private System.Windows.Forms.TextBox txtVon;
    private System.Windows.Forms.ListBox lstVon;
    private System.Windows.Forms.ListView lstVerbindungen;
    private System.Windows.Forms.Button btnVerbindungen;
    private System.Windows.Forms.Label lblVon;
    private System.Windows.Forms.Label lblNach;
    private System.Windows.Forms.TabPage fahrplan;
    private System.Windows.Forms.TextBox txtStation;
    private System.Windows.Forms.Label lblStation;
    private System.Windows.Forms.Button btnWechseln;
    private System.Windows.Forms.Button btnLeeren;
    private System.Windows.Forms.Button btnFahrplanLeeren;
    private System.Windows.Forms.ListView lstFahrplan;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ListBox lstStation;
    private System.Windows.Forms.WebBrowser webStationSuchen;
    private System.Windows.Forms.ListBox lstStationSuchen;
    private System.Windows.Forms.TextBox txtStationSuchen;
    private System.Windows.Forms.Label lblStationSuchen;
  }
}

