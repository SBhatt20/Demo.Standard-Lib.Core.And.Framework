using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLib
{
  public interface ISettings
  {
    string DatabaseName();
    string ConnectionString();
  }
}
