using System;
using SettingsManagerDemo.Domain.Models;
using SettingsManagerDemo.Interfaces;
using SettingsManagerDemo.Utilities;

namespace SettingsManagerDemo.Operations;

public class ConcreteOperation : IOperation
{
    public async Task RunOperation(IOperationModel? model)
    {
        await SettingsManager.Instance.SaveSettingAsync("SettingKey", "SettingValue");
        await SettingsManager.Instance.ReloadSettingsAsync();

        string value = (string)await SettingsManager.Instance.GetSettingAsync("SettingKey");
        Console.WriteLine("Setting value: " + value);
    }
}