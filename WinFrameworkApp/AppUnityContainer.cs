using DemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WinFrameworkApp
{
  public class AppUnityContainer
  {
    UnityContainer container = new UnityContainer();
    
    public void RegisterStorageManager()
    {
      DemoLib.Framework.UnitiExtension.RegisterDemoLib(this.container);
    }

    public IStorageManager ResolveStorageManager()
    {
      return container.Resolve<IStorageManager>();
    }


    public void RegisterHelper()
    {
      this.container.RegisterType<IHelper,Helper>();
    }

    public IHelper ResolveHelper()
    {
      return container.Resolve<IHelper>();
    }

  }
}
