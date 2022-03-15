namespace FsAffinityTestWin
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.txtProcessName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.flpSelected = new System.Windows.Forms.FlowLayoutPanel();
      this.flpOther = new System.Windows.Forms.FlowLayoutPanel();
      this.lblAffinitySelected = new System.Windows.Forms.Label();
      this.lblAffinityOther = new System.Windows.Forms.Label();
      this.btnApply = new System.Windows.Forms.Button();
      this.grd = new System.Windows.Forms.DataGridView();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.slbl = new System.Windows.Forms.ToolStripStatusLabel();
      this.sprg = new System.Windows.Forms.ToolStripProgressBar();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.windowTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.threadCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.affinityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isAccessibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.processInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.processInfoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Process:";
      // 
      // txtProcessName
      // 
      this.txtProcessName.Location = new System.Drawing.Point(92, 5);
      this.txtProcessName.Name = "txtProcessName";
      this.txtProcessName.Size = new System.Drawing.Size(175, 23);
      this.txtProcessName.TabIndex = 1;
      this.txtProcessName.Text = "FlightSimulator";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Other processes:";
      // 
      // flpSelected
      // 
      this.flpSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpSelected.Location = new System.Drawing.Point(332, 5);
      this.flpSelected.Name = "flpSelected";
      this.flpSelected.Size = new System.Drawing.Size(602, 23);
      this.flpSelected.TabIndex = 3;
      // 
      // flpOther
      // 
      this.flpOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpOther.Location = new System.Drawing.Point(332, 39);
      this.flpOther.Name = "flpOther";
      this.flpOther.Size = new System.Drawing.Size(602, 23);
      this.flpOther.TabIndex = 4;
      // 
      // lblAffinitySelected
      // 
      this.lblAffinitySelected.AutoSize = true;
      this.lblAffinitySelected.Location = new System.Drawing.Point(272, 8);
      this.lblAffinitySelected.Name = "lblAffinitySelected";
      this.lblAffinitySelected.Size = new System.Drawing.Size(51, 16);
      this.lblAffinitySelected.TabIndex = 5;
      this.lblAffinitySelected.Text = "Cores:";
      // 
      // lblAffinityOther
      // 
      this.lblAffinityOther.AutoSize = true;
      this.lblAffinityOther.Location = new System.Drawing.Point(274, 39);
      this.lblAffinityOther.Name = "lblAffinityOther";
      this.lblAffinityOther.Size = new System.Drawing.Size(51, 16);
      this.lblAffinityOther.TabIndex = 6;
      this.lblAffinityOther.Text = "Cores:";
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(13, 68);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(920, 31);
      this.btnApply.TabIndex = 7;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // grd
      // 
      this.grd.AllowUserToAddRows = false;
      this.grd.AllowUserToDeleteRows = false;
      this.grd.AllowUserToOrderColumns = true;
      this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grd.AutoGenerateColumns = false;
      this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.windowTitleDataGridViewTextBoxColumn,
            this.threadCountDataGridViewTextBoxColumn,
            this.affinityDataGridViewTextBoxColumn,
            this.isAccessibleDataGridViewCheckBoxColumn,
            this.isSelectedDataGridViewCheckBoxColumn});
      this.grd.DataSource = this.processInfoBindingSource;
      this.grd.Location = new System.Drawing.Point(13, 104);
      this.grd.Name = "grd";
      this.grd.ReadOnly = true;
      this.grd.Size = new System.Drawing.Size(920, 333);
      this.grd.TabIndex = 8;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl,
            this.sprg});
      this.statusStrip1.Location = new System.Drawing.Point(0, 463);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
      this.statusStrip1.Size = new System.Drawing.Size(944, 22);
      this.statusStrip1.TabIndex = 9;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // slbl
      // 
      this.slbl.Name = "slbl";
      this.slbl.Size = new System.Drawing.Size(118, 17);
      this.slbl.Text = "toolStripStatusLabel1";
      // 
      // sprg
      // 
      this.sprg.Name = "sprg";
      this.sprg.Size = new System.Drawing.Size(89, 16);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // windowTitleDataGridViewTextBoxColumn
      // 
      this.windowTitleDataGridViewTextBoxColumn.DataPropertyName = "WindowTitle";
      this.windowTitleDataGridViewTextBoxColumn.HeaderText = "Window Title";
      this.windowTitleDataGridViewTextBoxColumn.Name = "windowTitleDataGridViewTextBoxColumn";
      this.windowTitleDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // threadCountDataGridViewTextBoxColumn
      // 
      this.threadCountDataGridViewTextBoxColumn.DataPropertyName = "ThreadCount";
      this.threadCountDataGridViewTextBoxColumn.HeaderText = "Thread Count";
      this.threadCountDataGridViewTextBoxColumn.Name = "threadCountDataGridViewTextBoxColumn";
      this.threadCountDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // affinityDataGridViewTextBoxColumn
      // 
      this.affinityDataGridViewTextBoxColumn.DataPropertyName = "AffinityBinaryString";
      this.affinityDataGridViewTextBoxColumn.HeaderText = "Affinity";
      this.affinityDataGridViewTextBoxColumn.Name = "affinityDataGridViewTextBoxColumn";
      this.affinityDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // isAccessibleDataGridViewCheckBoxColumn
      // 
      this.isAccessibleDataGridViewCheckBoxColumn.DataPropertyName = "IsAccessible";
      this.isAccessibleDataGridViewCheckBoxColumn.HeaderText = "Is Accessible";
      this.isAccessibleDataGridViewCheckBoxColumn.Name = "isAccessibleDataGridViewCheckBoxColumn";
      this.isAccessibleDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // isSelectedDataGridViewCheckBoxColumn
      // 
      this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
      this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "Is Selected";
      this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
      this.isSelectedDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // processInfoBindingSource
      // 
      this.processInfoBindingSource.AllowNew = false;
      this.processInfoBindingSource.DataSource = typeof(FsAffinityTestWin.ProcessInfo);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 485);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.grd);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.lblAffinityOther);
      this.Controls.Add(this.lblAffinitySelected);
      this.Controls.Add(this.flpOther);
      this.Controls.Add(this.flpSelected);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtProcessName);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "FS Affinity Test Win";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.processInfoBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtProcessName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.FlowLayoutPanel flpSelected;
    private System.Windows.Forms.FlowLayoutPanel flpOther;
    private System.Windows.Forms.Label lblAffinitySelected;
    private System.Windows.Forms.Label lblAffinityOther;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.DataGridView grd;
    private System.Windows.Forms.BindingSource processInfoBindingSource;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel slbl;
    private System.Windows.Forms.ToolStripProgressBar sprg;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn windowTitleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn threadCountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn affinityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isAccessibleDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
  }
}

