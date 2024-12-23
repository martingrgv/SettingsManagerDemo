using System;
using Microsoft.EntityFrameworkCore;
using SettingsManagerDemo.Domain.Models;
using SettingsManagerDemo.Infrastructure;
using SettingsManagerDemo.Interfaces;

namespace SettingsManagerDemo.Storages;

public class DatabaseStorage : ISettingsStorage
{
    private SettingsDemoDbContext _context;

    public DatabaseStorage(SettingsDemoDbContext context)
    {
        _context = context;
    }

    public async Task<Dictionary<string, string>> LoadSettingsAsync()
    {
        return await _context.Settings.ToDictionaryAsync(kvp => kvp.Key, kvp => kvp.Value);
    }

    public async Task SaveSettingsAsync(string key, string value)
    {
        _context.Add(new Setting(key, value));
        await _context.SaveChangesAsync();
    }
}
