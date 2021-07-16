using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<CarInfo> carInfoList = ConsoleHelper.ReadCarsInfo();
            CommandHelper commandHelper = new CommandHelper(carInfoList);
            var instance = CommandExecutor.GetInstance();

            while (true)
            {
                Console.WriteLine();
                ConsoleHelper.ShowMenu();
                Console.WriteLine();
                var userInput = ConsoleHelper.ReadCommand(commandHelper.AvailableCommands.Keys.ToList());
                var command = commandHelper.AvailableCommands[userInput];
                instance.Command = command;
                instance.ExecuteCommand();
            }       
        }
    }
}
