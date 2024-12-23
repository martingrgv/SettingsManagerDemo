using System;
using SettingsManagerDemo.Interfaces;

namespace SettingsManagerDemo.Utilities;

public class SettingsManager : ISettingsManager
{
    private static Lazy<SettingsManager> _instance = null!;
    private readonly ISettingsStorage _settingsStorage;
    private Dictionary<string, object> _settings;

    public SettingsManager(ISettingsStorage settingsStorage)
    {
        _settingsStorage = settingsStorage;
        _settings = new Dictionary<string, object>();

        ReloadSettingsAsync().GetAwaiter().GetResult();
    }

    public static void Initialize(ISettingsStorage settingsStorage)
    {
        if (_instance != null)
            throw new InvalidOperationException("Settings manager is already initialized!");
        
        _instance = new Lazy<SettingsManager>(() => new SettingsManager(settingsStorage));
    }

    public static SettingsManager Instance => _instance.Value;

    public async Task SaveSettingAsync(string key, object value)
    {
        await _settingsStorage.SaveSettings(key, value);
    }

    public async Task ReloadSettingsAsync()
    {
        _settings = await _settingsStorage.LoadSettings();
    }

    public async Task<object?> GetSettingAsync(string key, object? defaultValue = null)
    {
        await ReloadSettingsAsync();

        if (_settings.TryGetValue(key, out var value))
        {
            return value;
        }

        return defaultValue;
    }
}
