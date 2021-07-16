using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class CountTypesCommand : ICommand
    {
        private List<CarInfo> carsInfo;

        public CountTypesCommand(List<CarInfo> carsInfo)
        {
            this.carsInfo = carsInfo;
        }

        public void Execute()
        {
            var uniqueBrands = carsInfo.Select(x => x.Brand).ToHashSet().Count();
            System.Console.WriteLine($"A numbers of unique brands is: {uniqueBrands}");
        }
    }
}
