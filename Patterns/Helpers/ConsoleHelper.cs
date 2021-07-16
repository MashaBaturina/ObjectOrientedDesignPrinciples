using System;
using System.Collections.Generic;

namespace Patterns
{
    public static class ConsoleHelper
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Choose a command:");
            Console.WriteLine("1 - Count types");
            Console.WriteLine("2 - Count all");
            Console.WriteLine("3 - Average price");
            Console.WriteLine("4 - Average price type");
            Console.WriteLine("5 - Exit");      
        }

        public static List<CarInfo> ReadCarsInfo()
        {
            List<CarInfo> carsInfoList = new List<CarInfo>();
            string userInput;

            do
            {
                string brand = ReadStringInput("Input car's brand:");
                string model = ReadStringInput("Input car's model:");
                int quantityOfCars = ReadAndGetCarsQuantity();
                double price = ReadAndGetCarsPrice();
                CarInfo carInfo = new CarInfo(brand, model, quantityOfCars, price);
                carsInfoList.Add(carInfo);
                Console.WriteLine("Do you want to add one more car? 'N' to exit, 'any key to continue.'");
                userInput = Console.ReadLine();

            } while (userInput != "N");

            return carsInfoList;
        }

        public static string ReadCommand(List<string> availableCommandsNumbers)
        {
            string input;
            bool isCommandCorrect;
           
            do
            {
                input = Console.ReadLine();
                isCommandCorrect = availableCommandsNumbers.Contains(input);

                if (!isCommandCorrect)
                {
                    Console.WriteLine("Command is not correct. Please, try again.");
                }

            } while (!isCommandCorrect);

            return input;
        }

        private static string ReadStringInput(string message)
        {
            int maxStringLength = 30;
            string resultString = string.Empty;
            bool flag = false;

            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) && userInput.Length < maxStringLength)
                {
                    resultString = userInput;
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Input string length should not be empy or exeeed {maxStringLength} symbols. Please, try again.");
                }

            } while (!flag);

            return resultString;
        }

        private static int ReadAndGetCarsQuantity()
        {
            int maxNumberOfCarsToAddAtATime = 10000;
            int quantity;
            bool flag = false;

            do
            {
                Console.WriteLine("Input quantity of cars:");
                string userInput = Console.ReadLine();
                bool isParsed = int.TryParse(userInput, out quantity);

                if (isParsed)
                {
                    if (quantity > 0 && quantity < maxNumberOfCarsToAddAtATime)
                    {
                        flag = true;
                    }
                }
                else
                {
                    Console.WriteLine($"Incorrect input. Please, input a number greated than 0 and less than {maxNumberOfCarsToAddAtATime}.");
                }

            } while (!flag);

            return quantity;
        }

        private static double ReadAndGetCarsPrice()
        {
            const int maxCarPriceInDollars = 100000000;
            double price;
            bool flag = false;

            do
            {
                Console.WriteLine("Input car's price:");
                string userInput = Console.ReadLine();
                bool isParsed = double.TryParse(userInput, out price);

                if (isParsed)
                {
                    if (price > 0 && price < maxCarPriceInDollars)
                    {
                        flag = true;
                    }
                }
                else
                {
                    Console.WriteLine($"Incorrect input. Please, input a price greated than 0 and less than {maxCarPriceInDollars}.");
                }

            } while (!flag);

            return price;
        }
    }
}
