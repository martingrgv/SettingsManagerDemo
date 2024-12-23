using System;

namespace SettingsManagerDemo.Interfaces;

public interface ISettingsStorage
{
    Task<Dictionary<string, object>> LoadSettings();
    Task SaveSettings(string key, object value);
}
