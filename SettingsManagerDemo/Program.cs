using SettingsManagerDemo.Domain.Models;
using SettingsManagerDemo.Interfaces;
using SettingsManagerDemo.Operations;
using SettingsManagerDemo.Storages;
using SettingsManagerDemo.Utilities;

ISettingsStorage settingsStorage = new DatabaseStorage();
SettingsManager.Initialize(settingsStorage);
await SettingsManager.Instance.ReloadSettingsAsync();

var operation = new ConcreteOperation();
await operation.RunOperation(null);