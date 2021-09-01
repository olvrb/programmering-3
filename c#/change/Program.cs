using System;

namespace change {
    class Program {
        static void Main(string[] args) {
            CollectionOfMoney change = new CollectionOfMoney();

            // Declare all types of possible bills & coins
            Money[] possibilities = {
                new Money(1000),
                new Money(500),
                new Money(200),
                new Money(100),
                new Money(50),
                new Money(20),
                new Money(10),
                new Money(5),
                new Money(2),
                new Money(1)
            };

            
            // Get price and paid amount.
            int price = GetIntInput("Enter price: ");
            int paid = GetIntInput("Enter how much paid: ");
            int calc =  paid - price;


            // Add one or more bills/coins of every relevant type to the money collection.
            foreach (var m in possibilities) {
                while (calc >= m.Type) {
                    m.Amount++;
                    calc -= m.Type;
                }

                change.AddMoney(m);
            }

            // Iterate through every type of money and print how many of each bills/coins the customer is to get back.
            foreach (var money in change.Moneys) {
                if (money.Amount != 0) {
                    Console.WriteLine($"{money.Amount} * {money.GetHumanName()}");
                }
            }

            Console.WriteLine($"Total is {change.Sum()}kr");
        }

        public static int GetIntInput(string message) {
            
            // Keep asking for a number until get a valid number. -1 is just a placeholder
            int i = -1;
            while (i == -1) {
                Console.Write(message);
                try {
                    i = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Please enter a number.");
                }
            }

            return i;
        }
    }
}