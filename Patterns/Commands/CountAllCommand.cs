using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class CountAllCommand : ICommand
    {
        private List<CarInfo> carsInfo;

        public CountAllCommand(List<CarInfo> carsInfo)
        {
            this.carsInfo = carsInfo;
        }

        public void Execute()
        {
            int result = 0;
            var amounts = carsInfo.Select(x => x.Amount);

            foreach(var item in amounts)
            {
                result += item;
            }

            Console.WriteLine($"Total amount of cars is: {result}");
        }
    }
}
