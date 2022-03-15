using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FsAffinityTestWin
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      for (int i = 0; i < Environment.ProcessorCount; i++)
      {
        flpSelected.Controls.Add(CreateCheckBox());
        flpOther.Controls.Add(CreateCheckBox());
      }
    }

    private CheckBox CreateCheckBox()
    {
      CheckBox ret = new CheckBox();
      ret.Checked = true;
      ret.Text = "";
      ret.Width = 16;
      ret.CheckedChanged += chk_CheckStateChanged;
      return ret;
    }

    private void chk_CheckStateChanged(object sender, EventArgs e)
    {
      lblAffinitySelected.Text = CalculateAffinity(flpSelected).ToString();
      lblAffinityOther.Text = CalculateAffinity(flpOther).ToString();
    }

    private int CalculateAffinity(FlowLayoutPanel flp)
    {
      List<bool> bits = new List<bool>();
      foreach (var ctr in flp.Controls)
      {
        CheckBox cb = (CheckBox)ctr;
        bits.Add(cb.Checked);
      }
      BitArray bitArray = new BitArray(bits.ToArray());
      int[] tmp = new int[1];
      bitArray.CopyTo(tmp, 0);
      int ret = tmp[0];
      return ret;
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      slbl.Text = "Applying";
      slbl.Invalidate();
      btnApply.Enabled = false;
      processInfoBindingSource.DataSource = null;

      int selected = CalculateAffinity(flpSelected);
      int other = CalculateAffinity(flpOther);
      List<ProcessInfo> pis = ApplyAffinity(txtProcessName.Text.Trim(), (IntPtr)selected, (IntPtr)other);
      pis = pis.OrderBy(q => q.Name).ToList();

      processInfoBindingSource.DataSource = pis;
      btnApply.Enabled = true;
      slbl.Text = $"Applied. {pis.Count} processes, {pis.Count(q => q.IsAccessible)} accessible, " +
        $"{pis.Count(q => q.IsAccessible == false)} unacessible, {pis.Count(q => q.IsSelected)} selected";
    }

    private List<ProcessInfo> ApplyAffinity(string selectedProcess, IntPtr selectedAffinity, IntPtr otherAffinity)
    {
      List<ProcessInfo> ret = new List<ProcessInfo>();
      Process[] processes = Process.GetProcesses();
      foreach (Process process in processes.OrderBy(q => q.ProcessName))
      {
        ProcessInfo pi = new ProcessInfo()
        {
          Id = process.Id,
          Name = process.ProcessName,
          WindowTitle = process.MainWindowTitle,
          IsSelected = false
        };
        ret.Add(pi);

        IntPtr trgAffinity;
        if (process.ProcessName == selectedProcess)
        {
          trgAffinity = selectedAffinity;
          pi.IsSelected = true;
        }
        else
          trgAffinity = otherAffinity;

        try
        {
          process.ProcessorAffinity = trgAffinity;
          pi.IsAccessible = true;
        }
        catch (Exception)
        {
          pi.IsAccessible = false;
        }

        try
        {
          pi.Affinity = (int)process.ProcessorAffinity;
        }
        catch (Exception)
        {
          pi.Affinity = -1;
        }
      }
      return ret;
    }
  }
}