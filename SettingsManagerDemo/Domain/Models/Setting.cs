using System;
using System.ComponentModel.DataAnnotations;

namespace SettingsManagerDemo.Domain.Models;

public class Setting
{
    public Setting(string key, string value)
    {
        Key = key;
        Value = value;
    }

    [Key]
    public string Key { get; private set; } = null!;
    public string Value { get; private set; }= null!;

    public void SetValue(string value) => Value = value;
}
