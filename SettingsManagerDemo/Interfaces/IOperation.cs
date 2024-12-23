using System;

namespace SettingsManagerDemo.Interfaces;

public interface IOperation
{
    Task RunOperation(IOperationModel? model);
}
