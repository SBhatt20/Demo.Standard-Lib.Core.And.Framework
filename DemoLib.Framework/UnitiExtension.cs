using System;
using Unity;

namespace DemoLib.Framework
{
  public static class UnitiExtension
  {
    public static UnityContainer RegisterDemoLib(this UnityContainer container)
    {
      container.RegisterType<ISettings,Settings>();
      container.RegisterType<IStorageManager, StorageManager>();
      return container;
    }
  }
}
