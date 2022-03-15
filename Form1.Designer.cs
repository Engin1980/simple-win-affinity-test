namespace FsAffinityTestWin
{
  partial class Form1
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
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.windowTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.threadCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.affinityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isAccessibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.processInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.slbl = new System.Windows.Forms.ToolStripStatusLabel();
      this.sprg = new System.Windows.Forms.ToolStripProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.processInfoBindingSource)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Process:";
      // 
      // txtProcessName
      // 
      this.txtProcessName.Location = new System.Drawing.Point(104, 6);
      this.txtProcessName.Name = "txtProcessName";
      this.txtProcessName.Size = new System.Drawing.Size(196, 26);
      this.txtProcessName.TabIndex = 1;
      this.txtProcessName.Text = "FlightSimulator";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Other processes:";
      // 
      // flpSelected
      // 
      this.flpSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpSelected.Location = new System.Drawing.Point(373, 6);
      this.flpSelected.Name = "flpSelected";
      this.flpSelected.Size = new System.Drawing.Size(677, 26);
      this.flpSelected.TabIndex = 3;
      // 
      // flpOther
      // 
      this.flpOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpOther.Location = new System.Drawing.Point(373, 44);
      this.flpOther.Name = "flpOther";
      this.flpOther.Size = new System.Drawing.Size(677, 26);
      this.flpOther.TabIndex = 4;
      // 
      // lblAffinitySelected
      // 
      this.lblAffinitySelected.AutoSize = true;
      this.lblAffinitySelected.Location = new System.Drawing.Point(306, 9);
      this.lblAffinitySelected.Name = "lblAffinitySelected";
      this.lblAffinitySelected.Size = new System.Drawing.Size(17, 18);
      this.lblAffinitySelected.TabIndex = 5;
      this.lblAffinitySelected.Text = "x";
      // 
      // lblAffinityOther
      // 
      this.lblAffinityOther.AutoSize = true;
      this.lblAffinityOther.Location = new System.Drawing.Point(306, 44);
      this.lblAffinityOther.Name = "lblAffinityOther";
      this.lblAffinityOther.Size = new System.Drawing.Size(17, 18);
      this.lblAffinityOther.TabIndex = 6;
      this.lblAffinityOther.Text = "x";
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(15, 76);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(1035, 35);
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
      this.grd.Location = new System.Drawing.Point(15, 117);
      this.grd.Name = "grd";
      this.grd.Size = new System.Drawing.Size(1035, 375);
      this.grd.TabIndex = 8;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // windowTitleDataGridViewTextBoxColumn
      // 
      this.windowTitleDataGridViewTextBoxColumn.DataPropertyName = "WindowTitle";
      this.windowTitleDataGridViewTextBoxColumn.HeaderText = "WindowTitle";
      this.windowTitleDataGridViewTextBoxColumn.Name = "windowTitleDataGridViewTextBoxColumn";
      // 
      // threadCountDataGridViewTextBoxColumn
      // 
      this.threadCountDataGridViewTextBoxColumn.DataPropertyName = "ThreadCount";
      this.threadCountDataGridViewTextBoxColumn.HeaderText = "ThreadCount";
      this.threadCountDataGridViewTextBoxColumn.Name = "threadCountDataGridViewTextBoxColumn";
      // 
      // affinityDataGridViewTextBoxColumn
      // 
      this.affinityDataGridViewTextBoxColumn.DataPropertyName = "Affinity";
      this.affinityDataGridViewTextBoxColumn.HeaderText = "Affinity";
      this.affinityDataGridViewTextBoxColumn.Name = "affinityDataGridViewTextBoxColumn";
      // 
      // isAccessibleDataGridViewCheckBoxColumn
      // 
      this.isAccessibleDataGridViewCheckBoxColumn.DataPropertyName = "IsAccessible";
      this.isAccessibleDataGridViewCheckBoxColumn.HeaderText = "IsAccessible";
      this.isAccessibleDataGridViewCheckBoxColumn.Name = "isAccessibleDataGridViewCheckBoxColumn";
      // 
      // isSelectedDataGridViewCheckBoxColumn
      // 
      this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
      this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "IsSelected";
      this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
      // 
      // processInfoBindingSource
      // 
      this.processInfoBindingSource.AllowNew = false;
      this.processInfoBindingSource.DataSource = typeof(FsAffinityTestWin.ProcessInfo);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl,
            this.sprg});
      this.statusStrip1.Location = new System.Drawing.Point(0, 524);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
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
      this.sprg.Size = new System.Drawing.Size(100, 16);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1062, 546);
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
      this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.processInfoBindingSource)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
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
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn windowTitleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn threadCountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn affinityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isAccessibleDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
    private System.Windows.Forms.BindingSource processInfoBindingSource;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel slbl;
    private System.Windows.Forms.ToolStripProgressBar sprg;
  }
}

