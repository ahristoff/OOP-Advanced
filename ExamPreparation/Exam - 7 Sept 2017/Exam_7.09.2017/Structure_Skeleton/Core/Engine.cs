using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private ICommandInterpreter commandInterpreter;
    private IWriter writer;
    private IReader reader;

    public Engine(ICommandInterpreter commandInterpreter, IReader reader, IWriter writer)
    {
        this.commandInterpreter = commandInterpreter;
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        while (true)
        {

            List<string> inputArgs = reader.ReadLine().Split().ToList();

            var res = commandInterpreter.ProcessCommand(inputArgs);

            writer.WriteLine(res);

            if (inputArgs[0] == "Shutdown")
            {
                break;
            }
        }
    }
}
