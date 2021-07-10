using System;

namespace DemoLib
{
  public class StorageManager : IStorageManager
  {
    ISettings settingsObj;
    public StorageManager(ISettings settings)
    {
      this.settingsObj = settings;
    }

    public string MySettings()
    {
      return this.settingsObj.ConnectionString() + " - " + this.settingsObj.DatabaseName();
    }
  }

  public interface IStorageManager
  {
    string MySettings();
  }
}
