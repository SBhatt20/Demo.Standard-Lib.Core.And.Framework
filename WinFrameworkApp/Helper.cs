using DemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrameworkApp
{
  public class Helper : IHelper
  {
    string Summary;
    public Helper(IStorageManager storageManager)
    {
      this.Summary = storageManager.MySettings();
    }

    public string MySettingData()
    {
      return this.Summary;
    }
  }

  public interface IHelper
  {
    string MySettingData();
  }
}
