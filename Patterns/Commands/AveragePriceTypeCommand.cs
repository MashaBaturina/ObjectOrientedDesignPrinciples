using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class AveragePriceTypeCommand : ICommand
    {
        private List<CarInfo> carsInfo;

        public AveragePriceTypeCommand(List<CarInfo> carsInfo)
        {
            this.carsInfo = carsInfo;
        }

        public void Execute()
        {
            int totalAmountOfCars = 0;
            double totalPriceOfCars = 0;
            double averageCarPrice = 0;

            Console.WriteLine("Input car's brand.");
            var userInput = Console.ReadLine();
            bool isBrandContainedInList = carsInfo.Any(carInfo => carInfo.Brand == userInput);
            if (isBrandContainedInList)
            {
                var specificBrandCarsInfo = carsInfo.Where(carInfo => carInfo.Brand == userInput);

                foreach(var carInfo in specificBrandCarsInfo)
                {
                    totalPriceOfCars += carInfo.Amount * carInfo.Price;
                    totalAmountOfCars += carInfo.Amount;
                }

                averageCarPrice = totalPriceOfCars / totalAmountOfCars;

                Console.WriteLine($"Average price of car's brand: {userInput} is {averageCarPrice}");
            }
            else
            {
                Console.WriteLine("Car's brand not found.");
            }
        }
    }
}
