using System;

namespace SettingsManagerDemo.Interfaces;

public interface ISettingsStorage
{
    Task<Dictionary<string, string>> LoadSettingsAsync();
    Task SaveSettingsAsync(string key, string value);
}
