﻿namespace SwissTransportGUI
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
      this.tabControl = new System.Windows.Forms.TabControl();
      this.verbindungSuchen = new System.Windows.Forms.TabPage();
      this.fahrplan = new System.Windows.Forms.TabPage();
      this.txtNach = new System.Windows.Forms.TextBox();
      this.lstNach = new System.Windows.Forms.ListBox();
      this.txtVon = new System.Windows.Forms.TextBox();
      this.lstVon = new System.Windows.Forms.ListBox();
      this.lstVerbindungen = new System.Windows.Forms.ListView();
      this.btnVerbindungen = new System.Windows.Forms.Button();
      this.lblVon = new System.Windows.Forms.Label();
      this.lblNach = new System.Windows.Forms.Label();
      this.txtStation = new System.Windows.Forms.TextBox();
      this.lstStation = new System.Windows.Forms.ListBox();
      this.lstFahrplan = new System.Windows.Forms.ListView();
      this.lblStation = new System.Windows.Forms.Label();
      this.tabControl.SuspendLayout();
      this.verbindungSuchen.SuspendLayout();
      this.fahrplan.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.verbindungSuchen);
      this.tabControl.Controls.Add(this.fahrplan);
      this.tabControl.Location = new System.Drawing.Point(-4, 1);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(824, 552);
      this.tabControl.TabIndex = 0;
      // 
      // verbindungSuchen
      // 
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
      this.verbindungSuchen.UseVisualStyleBackColor = true;
      // 
      // fahrplan
      // 
      this.fahrplan.Controls.Add(this.lblStation);
      this.fahrplan.Controls.Add(this.lstFahrplan);
      this.fahrplan.Controls.Add(this.lstStation);
      this.fahrplan.Controls.Add(this.txtStation);
      this.fahrplan.Location = new System.Drawing.Point(4, 25);
      this.fahrplan.Name = "fahrplan";
      this.fahrplan.Padding = new System.Windows.Forms.Padding(3);
      this.fahrplan.Size = new System.Drawing.Size(816, 523);
      this.fahrplan.TabIndex = 1;
      this.fahrplan.Text = "Fahrplan";
      this.fahrplan.UseVisualStyleBackColor = true;
      // 
      // txtNach
      // 
      this.txtNach.Location = new System.Drawing.Point(284, 64);
      this.txtNach.Name = "txtNach";
      this.txtNach.Size = new System.Drawing.Size(193, 22);
      this.txtNach.TabIndex = 20;
      this.txtNach.TextChanged += new System.EventHandler(this.txtNach_TextChanged);
      // 
      // lstNach
      // 
      this.lstNach.FormattingEnabled = true;
      this.lstNach.ItemHeight = 16;
      this.lstNach.Location = new System.Drawing.Point(284, 82);
      this.lstNach.Name = "lstNach";
      this.lstNach.Size = new System.Drawing.Size(193, 68);
      this.lstNach.TabIndex = 21;
      this.lstNach.Click += new System.EventHandler(this.lstNach_Click);
      // 
      // txtVon
      // 
      this.txtVon.Location = new System.Drawing.Point(29, 64);
      this.txtVon.Name = "txtVon";
      this.txtVon.Size = new System.Drawing.Size(193, 22);
      this.txtVon.TabIndex = 18;
      this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
      // 
      // lstVon
      // 
      this.lstVon.FormattingEnabled = true;
      this.lstVon.ItemHeight = 16;
      this.lstVon.Location = new System.Drawing.Point(29, 82);
      this.lstVon.Name = "lstVon";
      this.lstVon.Size = new System.Drawing.Size(193, 68);
      this.lstVon.TabIndex = 16;
      this.lstVon.Click += new System.EventHandler(this.lstVon_Click);
      // 
      // lstVerbindungen
      // 
      this.lstVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstVerbindungen.Location = new System.Drawing.Point(29, 183);
      this.lstVerbindungen.Name = "lstVerbindungen";
      this.lstVerbindungen.Size = new System.Drawing.Size(758, 318);
      this.lstVerbindungen.TabIndex = 14;
      this.lstVerbindungen.UseCompatibleStateImageBehavior = false;
      this.lstVerbindungen.View = System.Windows.Forms.View.Details;
      // 
      // btnVerbindungen
      // 
      this.btnVerbindungen.Location = new System.Drawing.Point(548, 64);
      this.btnVerbindungen.Name = "btnVerbindungen";
      this.btnVerbindungen.Size = new System.Drawing.Size(110, 25);
      this.btnVerbindungen.TabIndex = 11;
      this.btnVerbindungen.Text = "Suchen";
      this.btnVerbindungen.UseVisualStyleBackColor = true;
      this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
      // 
      // lblVon
      // 
      this.lblVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblVon.AutoSize = true;
      this.lblVon.Location = new System.Drawing.Point(26, 42);
      this.lblVon.Name = "lblVon";
      this.lblVon.Size = new System.Drawing.Size(37, 17);
      this.lblVon.TabIndex = 12;
      this.lblVon.Text = "Von:";
      // 
      // lblNach
      // 
      this.lblNach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNach.AutoSize = true;
      this.lblNach.Location = new System.Drawing.Point(281, 42);
      this.lblNach.Name = "lblNach";
      this.lblNach.Size = new System.Drawing.Size(45, 17);
      this.lblNach.TabIndex = 13;
      this.lblNach.Text = "Nach:";
      // 
      // txtStation
      // 
      this.txtStation.Location = new System.Drawing.Point(29, 53);
      this.txtStation.Name = "txtStation";
      this.txtStation.Size = new System.Drawing.Size(193, 22);
      this.txtStation.TabIndex = 22;
      this.txtStation.TextChanged += new System.EventHandler(this.txtOrt_TextChanged);
      // 
      // lstStation
      // 
      this.lstStation.FormattingEnabled = true;
      this.lstStation.ItemHeight = 16;
      this.lstStation.Location = new System.Drawing.Point(29, 71);
      this.lstStation.Name = "lstStation";
      this.lstStation.Size = new System.Drawing.Size(193, 20);
      this.lstStation.TabIndex = 23;
      this.lstStation.Click += new System.EventHandler(this.lstOrt_Click);
      // 
      // lstFahrplan
      // 
      this.lstFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstFahrplan.Location = new System.Drawing.Point(29, 117);
      this.lstFahrplan.Name = "lstFahrplan";
      this.lstFahrplan.Size = new System.Drawing.Size(756, 385);
      this.lstFahrplan.TabIndex = 24;
      this.lstFahrplan.UseCompatibleStateImageBehavior = false;
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
    private System.Windows.Forms.ListBox lstStation;
    private System.Windows.Forms.TextBox txtStation;
    private System.Windows.Forms.ListView lstFahrplan;
    private System.Windows.Forms.Label lblStation;
  }
}

