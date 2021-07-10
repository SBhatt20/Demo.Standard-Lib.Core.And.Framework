using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLib
{
  public class Settings: ISettings
  {
    public string ConnectionString()
    {
      return "SQLServer Connetction String";
    }

    public string DatabaseName()
    {
      return "MyDM";
    }
  }
}
