using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsAffinityTestWin
{
  public class ProcessInfo
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string WindowTitle { get; set; }
    public int ThreadCount { get; set; }
    public int Affinity { get; set; }
    public bool IsAccessible { get; set; }
    public bool IsSelected { get; set; }
  }
}
