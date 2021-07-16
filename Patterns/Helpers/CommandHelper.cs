using System.Collections.Generic;

namespace Patterns
{
    public class CommandHelper
    {
        public Dictionary<string, ICommand> AvailableCommands { get; private set; }

        public CommandHelper(List<CarInfo> carsInfo)
        {
            AvailableCommands = new Dictionary<string, ICommand>
            {
                { "1", new CountTypesCommand(carsInfo) },
                { "2", new CountAllCommand(carsInfo) },
                { "3", new AveragePriceCommand(carsInfo) },
                { "4", new AveragePriceTypeCommand(carsInfo) },
                { "5", new ExitCommand() }
            };
        }
    }
}
