using System;
using System.ComponentModel.DataAnnotations;

namespace SettingsManagerDemo.Domain.Models;

public class Setting
{
    public Setting(string key, object value)
    {
        Key = key;
        Value = value;
    }

    [Key]
    public string Key { get; private set; } = null!;
    public object Value { get; private set; }= null!;
}
