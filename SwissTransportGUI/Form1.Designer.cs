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
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.cmbVon = new System.Windows.Forms.ComboBox();
      this.lblFahrplan = new System.Windows.Forms.Label();
      this.lblVon = new System.Windows.Forms.Label();
      this.cmbNach = new System.Windows.Forms.ComboBox();
      this.lblNach = new System.Windows.Forms.Label();
      this.lstFahrplan = new System.Windows.Forms.ListBox();
      this.lblVerbindungen = new System.Windows.Forms.Label();
      this.lstVerbindungen = new System.Windows.Forms.ListBox();
      this.splitContainer4 = new System.Windows.Forms.SplitContainer();
      this.btnFahrplan = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
      this.splitContainer4.Panel1.SuspendLayout();
      this.splitContainer4.Panel2.SuspendLayout();
      this.splitContainer4.SuspendLayout();
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
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.lblVerbindungen);
      this.splitContainer1.Panel2.Controls.Add(this.lstVerbindungen);
      this.splitContainer1.Size = new System.Drawing.Size(918, 555);
      this.splitContainer1.SplitterDistance = 556;
      this.splitContainer1.TabIndex = 0;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.lstFahrplan);
      this.splitContainer2.Size = new System.Drawing.Size(556, 555);
      this.splitContainer2.SplitterDistance = 103;
      this.splitContainer2.TabIndex = 0;
      // 
      // splitContainer3
      // 
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.Location = new System.Drawing.Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.btnFahrplan);
      this.splitContainer3.Size = new System.Drawing.Size(556, 103);
      this.splitContainer3.SplitterDistance = 429;
      this.splitContainer3.TabIndex = 0;
      // 
      // cmbVon
      // 
      this.cmbVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbVon.DisplayMember = "cmbVon";
      this.cmbVon.FormattingEnabled = true;
      this.cmbVon.Location = new System.Drawing.Point(17, 67);
      this.cmbVon.Name = "cmbVon";
      this.cmbVon.Size = new System.Drawing.Size(180, 24);
      this.cmbVon.TabIndex = 3;
      this.cmbVon.ValueMember = "cmbVon";
      this.cmbVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVon_KeyDown);
      // 
      // lblFahrplan
      // 
      this.lblFahrplan.AutoSize = true;
      this.lblFahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFahrplan.Location = new System.Drawing.Point(12, 9);
      this.lblFahrplan.Name = "lblFahrplan";
      this.lblFahrplan.Size = new System.Drawing.Size(89, 25);
      this.lblFahrplan.TabIndex = 0;
      this.lblFahrplan.Text = "Fahrplan";
      // 
      // lblVon
      // 
      this.lblVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblVon.AutoSize = true;
      this.lblVon.Location = new System.Drawing.Point(14, 47);
      this.lblVon.Name = "lblVon";
      this.lblVon.Size = new System.Drawing.Size(37, 17);
      this.lblVon.TabIndex = 1;
      this.lblVon.Text = "Von:";
      // 
      // cmbNach
      // 
      this.cmbNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbNach.DisplayMember = "cmbNach";
      this.cmbNach.FormattingEnabled = true;
      this.cmbNach.Location = new System.Drawing.Point(14, 67);
      this.cmbNach.Name = "cmbNach";
      this.cmbNach.Size = new System.Drawing.Size(180, 24);
      this.cmbNach.TabIndex = 4;
      this.cmbNach.ValueMember = "cmbVon";
      this.cmbNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNach_KeyDown);
      // 
      // lblNach
      // 
      this.lblNach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNach.AutoSize = true;
      this.lblNach.Location = new System.Drawing.Point(11, 47);
      this.lblNach.Name = "lblNach";
      this.lblNach.Size = new System.Drawing.Size(45, 17);
      this.lblNach.TabIndex = 2;
      this.lblNach.Text = "Nach:";
      // 
      // lstFahrplan
      // 
      this.lstFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstFahrplan.FormattingEnabled = true;
      this.lstFahrplan.ItemHeight = 16;
      this.lstFahrplan.Location = new System.Drawing.Point(17, 22);
      this.lstFahrplan.Name = "lstFahrplan";
      this.lstFahrplan.Size = new System.Drawing.Size(519, 404);
      this.lstFahrplan.TabIndex = 5;
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
      this.lstVerbindungen.Location = new System.Drawing.Point(23, 69);
      this.lstVerbindungen.Name = "lstVerbindungen";
      this.lstVerbindungen.Size = new System.Drawing.Size(310, 452);
      this.lstVerbindungen.TabIndex = 7;
      // 
      // splitContainer4
      // 
      this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer4.Location = new System.Drawing.Point(0, 0);
      this.splitContainer4.Name = "splitContainer4";
      // 
      // splitContainer4.Panel1
      // 
      this.splitContainer4.Panel1.Controls.Add(this.lblFahrplan);
      this.splitContainer4.Panel1.Controls.Add(this.lblVon);
      this.splitContainer4.Panel1.Controls.Add(this.cmbVon);
      // 
      // splitContainer4.Panel2
      // 
      this.splitContainer4.Panel2.Controls.Add(this.cmbNach);
      this.splitContainer4.Panel2.Controls.Add(this.lblNach);
      this.splitContainer4.Size = new System.Drawing.Size(429, 103);
      this.splitContainer4.SplitterDistance = 214;
      this.splitContainer4.TabIndex = 0;
      // 
      // btnFahrplan
      // 
      this.btnFahrplan.Location = new System.Drawing.Point(14, 67);
      this.btnFahrplan.Name = "btnFahrplan";
      this.btnFahrplan.Size = new System.Drawing.Size(75, 23);
      this.btnFahrplan.TabIndex = 0;
      this.btnFahrplan.Text = "Suchen";
      this.btnFahrplan.UseVisualStyleBackColor = true;
      this.btnFahrplan.Click += new System.EventHandler(this.btnFahrplan_Click);
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
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
      this.splitContainer3.ResumeLayout(false);
      this.splitContainer4.Panel1.ResumeLayout(false);
      this.splitContainer4.Panel1.PerformLayout();
      this.splitContainer4.Panel2.ResumeLayout(false);
      this.splitContainer4.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
      this.splitContainer4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox lstFahrplan;
    private System.Windows.Forms.ComboBox cmbNach;
    private System.Windows.Forms.Label lblNach;
    private System.Windows.Forms.Label lblVon;
    private System.Windows.Forms.Label lblFahrplan;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.Label lblVerbindungen;
    private System.Windows.Forms.ListBox lstVerbindungen;
    private System.Windows.Forms.ComboBox cmbVon;
    private System.Windows.Forms.SplitContainer splitContainer4;
    private System.Windows.Forms.Button btnFahrplan;
  }
}

