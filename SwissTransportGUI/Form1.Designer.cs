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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.txtNach = new System.Windows.Forms.TextBox();
      this.lstNach = new System.Windows.Forms.ListBox();
      this.txtVon = new System.Windows.Forms.TextBox();
      this.lstVon = new System.Windows.Forms.ListBox();
      this.lstFahrplan = new System.Windows.Forms.ListView();
      this.lblFahrplan = new System.Windows.Forms.Label();
      this.btnFahrplan = new System.Windows.Forms.Button();
      this.lblVon = new System.Windows.Forms.Label();
      this.lblNach = new System.Windows.Forms.Label();
      this.lblVerbindungen = new System.Windows.Forms.Label();
      this.lstVerbindungen = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.txtNach);
      this.splitContainer1.Panel1.Controls.Add(this.lstNach);
      this.splitContainer1.Panel1.Controls.Add(this.txtVon);
      this.splitContainer1.Panel1.Controls.Add(this.lstVon);
      this.splitContainer1.Panel1.Controls.Add(this.lstFahrplan);
      this.splitContainer1.Panel1.Controls.Add(this.lblFahrplan);
      this.splitContainer1.Panel1.Controls.Add(this.btnFahrplan);
      this.splitContainer1.Panel1.Controls.Add(this.lblVon);
      this.splitContainer1.Panel1.Controls.Add(this.lblNach);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.lblVerbindungen);
      this.splitContainer1.Panel2.Controls.Add(this.lstVerbindungen);
      this.splitContainer1.Size = new System.Drawing.Size(918, 555);
      this.splitContainer1.SplitterDistance = 523;
      this.splitContainer1.TabIndex = 0;
      // 
      // txtNach
      // 
      this.txtNach.Location = new System.Drawing.Point(234, 70);
      this.txtNach.Name = "txtNach";
      this.txtNach.Size = new System.Drawing.Size(147, 22);
      this.txtNach.TabIndex = 9;
      this.txtNach.TextChanged += new System.EventHandler(this.txtNach_TextChanged);
      // 
      // lstNach
      // 
      this.lstNach.FormattingEnabled = true;
      this.lstNach.ItemHeight = 16;
      this.lstNach.Location = new System.Drawing.Point(234, 88);
      this.lstNach.Name = "lstNach";
      this.lstNach.Size = new System.Drawing.Size(147, 84);
      this.lstNach.TabIndex = 10;
      this.lstNach.Click += new System.EventHandler(this.lstNach_Click);
      // 
      // txtVon
      // 
      this.txtVon.Location = new System.Drawing.Point(21, 70);
      this.txtVon.Name = "txtVon";
      this.txtVon.Size = new System.Drawing.Size(147, 22);
      this.txtVon.TabIndex = 8;
      this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
      // 
      // lstVon
      // 
      this.lstVon.FormattingEnabled = true;
      this.lstVon.ItemHeight = 16;
      this.lstVon.Location = new System.Drawing.Point(21, 88);
      this.lstVon.Name = "lstVon";
      this.lstVon.Size = new System.Drawing.Size(147, 84);
      this.lstVon.TabIndex = 7;
      this.lstVon.Click += new System.EventHandler(this.lstVon_Click);
      // 
      // lstFahrplan
      // 
      this.lstFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstFahrplan.Location = new System.Drawing.Point(21, 268);
      this.lstFahrplan.Name = "lstFahrplan";
      this.lstFahrplan.Size = new System.Drawing.Size(479, 253);
      this.lstFahrplan.TabIndex = 6;
      this.lstFahrplan.UseCompatibleStateImageBehavior = false;
      this.lstFahrplan.View = System.Windows.Forms.View.Details;
      // 
      // lblFahrplan
      // 
      this.lblFahrplan.AutoSize = true;
      this.lblFahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFahrplan.Location = new System.Drawing.Point(16, 14);
      this.lblFahrplan.Name = "lblFahrplan";
      this.lblFahrplan.Size = new System.Drawing.Size(89, 25);
      this.lblFahrplan.TabIndex = 0;
      this.lblFahrplan.Text = "Fahrplan";
      // 
      // btnFahrplan
      // 
      this.btnFahrplan.Location = new System.Drawing.Point(408, 69);
      this.btnFahrplan.Name = "btnFahrplan";
      this.btnFahrplan.Size = new System.Drawing.Size(75, 23);
      this.btnFahrplan.TabIndex = 0;
      this.btnFahrplan.Text = "Suchen";
      this.btnFahrplan.UseVisualStyleBackColor = true;
      this.btnFahrplan.Click += new System.EventHandler(this.btnFahrplan_Click);
      // 
      // lblVon
      // 
      this.lblVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblVon.AutoSize = true;
      this.lblVon.Location = new System.Drawing.Point(18, 48);
      this.lblVon.Name = "lblVon";
      this.lblVon.Size = new System.Drawing.Size(37, 17);
      this.lblVon.TabIndex = 1;
      this.lblVon.Text = "Von:";
      // 
      // lblNach
      // 
      this.lblNach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNach.AutoSize = true;
      this.lblNach.Location = new System.Drawing.Point(231, 48);
      this.lblNach.Name = "lblNach";
      this.lblNach.Size = new System.Drawing.Size(45, 17);
      this.lblNach.TabIndex = 2;
      this.lblNach.Text = "Nach:";
      // 
      // lblVerbindungen
      // 
      this.lblVerbindungen.AutoSize = true;
      this.lblVerbindungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVerbindungen.Location = new System.Drawing.Point(8, 9);
      this.lblVerbindungen.Name = "lblVerbindungen";
      this.lblVerbindungen.Size = new System.Drawing.Size(212, 25);
      this.lblVerbindungen.TabIndex = 8;
      this.lblVerbindungen.Text = "Nächste Verbindungen";
      // 
      // lstVerbindungen
      // 
      this.lstVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstVerbindungen.FormattingEnabled = true;
      this.lstVerbindungen.ItemHeight = 16;
      this.lstVerbindungen.Location = new System.Drawing.Point(23, 101);
      this.lstVerbindungen.Name = "lstVerbindungen";
      this.lstVerbindungen.Size = new System.Drawing.Size(343, 420);
      this.lstVerbindungen.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 555);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label lblVerbindungen;
    private System.Windows.Forms.ListBox lstVerbindungen;
    private System.Windows.Forms.TextBox txtNach;
    private System.Windows.Forms.ListBox lstNach;
    private System.Windows.Forms.TextBox txtVon;
    private System.Windows.Forms.ListBox lstVon;
    private System.Windows.Forms.ListView lstFahrplan;
    private System.Windows.Forms.Label lblFahrplan;
    private System.Windows.Forms.Button btnFahrplan;
    private System.Windows.Forms.Label lblVon;
    private System.Windows.Forms.Label lblNach;
  }
}

