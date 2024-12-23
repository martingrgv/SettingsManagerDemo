using SettingsManagerDemo.Utilities;

namespace SettingsManagerDemo.Interfaces;

public interface ISettingsManager
{
    static SettingsManager Instance { get; } = null!;
    Task ReloadSettingsAsync();
    Task<object?> GetSettingAsync(string key, object? defaultValue = default);
    Task SaveSettingAsync(string key, object value);
}
