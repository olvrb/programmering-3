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


            Console.Write("Enter price: ");
            int i = Int32.Parse(Console.ReadLine());
            Console.Write("Enter how much paid: ");
            int calc = Int32.Parse(Console.ReadLine()) - i;


            foreach (var m in possibilities) {
                while (calc >= m.Type) {
                    m.Amount++;
                    calc -= m.Type;
                }

                change.AddMoney(m);
            }

            foreach (var money in change.Moneys) {
                if (money.Amount != 0) {
                    Console.WriteLine($"{money.Amount} * {money.GetHumanName()}");
                }
            }
            Console.WriteLine($"Total is {change.Sum()}kr");
        }
    }
}