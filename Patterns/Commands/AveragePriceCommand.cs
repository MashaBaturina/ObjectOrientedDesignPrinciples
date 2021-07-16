using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class AveragePriceCommand : ICommand
    {
        private List<CarInfo> carsInfo;

        public AveragePriceCommand(List<CarInfo> carsInfo)
        {
            this.carsInfo = carsInfo;
        }

        public void Execute()
        {
            double averageCarPrice;
            double totalPriceOfAllCars = 0;
            int totalNumberOfCars = 0;


            foreach(var car in carsInfo)
            {
                var carsPrice = car.Amount * car.Price;
                totalPriceOfAllCars += carsPrice;
                totalNumberOfCars += car.Amount;
            }

            averageCarPrice = totalPriceOfAllCars / totalNumberOfCars;

            System.Console.WriteLine($"Average car price is: {averageCarPrice}");
        }
    }
}
