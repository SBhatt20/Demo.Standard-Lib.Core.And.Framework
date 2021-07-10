using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoLib.Core
{
  public static class ServiceExtension
  {
    public static IServiceCollection RegisterDemoLib(this IServiceCollection services)
    {
      services.AddSingleton<ISettings,Settings>();
      services.AddSingleton<IStorageManager,StorageManager>();
      return services;
    }
  }
}
