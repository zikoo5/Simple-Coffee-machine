namespace Kys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Welcome to ziko's coffee shop this is our menu : \n 1.Coffee  3$ \n 2.Java Chip  5$ \n 3.Caramel/Espresso  5$ \n 4.Cappuccino  5$ \n 5.Ice tea  4$");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            switch(choice)
            {
                case 1: Console.WriteLine("You ordered one cup of Coffee \n Total : 3$                   Enjoy.");
                    break;
                case 2: Console.WriteLine("You ordered one cup of Java Chip \n Total : 3$                   Enjoy.");
                    break;
                case 3: Console.WriteLine("You ordered one cup of Caramel/Espresso \n Total : 3$                   Enjoy.");
                    break;
                case 4: Console.WriteLine("You ordered one cup of Cappuccino \n Total : 3$                   Enjoy.");
                    break;
                case 5: Console.WriteLine("You ordered one cup of Ice tea \n Total : 3$                   Enjoy.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
