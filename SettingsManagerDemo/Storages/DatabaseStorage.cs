using System;
using SettingsManagerDemo.Interfaces;

namespace SettingsManagerDemo.Storages;

public class DatabaseStorage : ISettingsStorage
{
    public Dictionary<string, object> LoadSettings()
    {
        throw new NotImplementedException();
    }

    public Task SaveSettings(string key, object value)
    {
        throw new NotImplementedException();
    }

    public Task SaveSettingsAsync(string key, object value)
    {
        throw new NotImplementedException();
    }

    Task<Dictionary<string, object>> ISettingsStorage.LoadSettings()
    {
        throw new NotImplementedException();
    }
}
