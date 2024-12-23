using Microsoft.EntityFrameworkCore;
using SettingsManagerDemo.Domain.Models;
using SettingsManagerDemo.Infrastructure;
using SettingsManagerDemo.Interfaces;
using SettingsManagerDemo.Operations;
using SettingsManagerDemo.Storages;
using SettingsManagerDemo.Utilities;

using (var context = new SettingsDemoDbContext())
{
    ISettingsStorage settingsStorage = new DatabaseStorage(context);
    SettingsManager.Initialize(settingsStorage);
    await SettingsManager.Instance.ReloadSettingsAsync();

    var operation = new ConcreteOperation();
    await operation.RunOperation(null);
}
