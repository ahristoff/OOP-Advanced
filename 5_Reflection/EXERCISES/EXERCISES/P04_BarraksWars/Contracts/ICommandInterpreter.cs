﻿
namespace _04BarracksFactory.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data);
    }
}
