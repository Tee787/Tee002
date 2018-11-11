using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            string Code;
            decimal Total = 0;
            string Meal = "";

            decimal SushiCost = 10;
            decimal FishnChipCost = 8;
            decimal BurgerCost = 10;
            decimal BtrChickCost = 15;

            Boolean menu = true;
            do
            {
                Console.WriteLine("Welcome to the Toi -Ohomai Lunch Bar");
                Console.WriteLine("You may choose from the lunch menu below");
                Console.WriteLine("");
                Console.WriteLine("Salmon Sushi" + "CODE: SUSHI");
                Console.WriteLine("Fish n Chips" + "CODE: FNC");
                Console.WriteLine("Burger n Fries" + "CODE: BGR");
                Console.WriteLine("Butter Chicken" + "CODE: BTRCHK");
                Console.WriteLine("");
                Console.WriteLine("Please enter the Code");
                Code = Console.ReadLine().ToUpper();

                if (Code == "SUSHI")
                {
                    Meal = "Salmon Sushi";
                    Total = SushiCost;
                }
                else if (Code == "FNC")
                {
                    Meal = "Fish n Chips";
                    Total = FishnChipCost;
                }
                else if (Code == "BGR")
                {
                    Meal = "Burger n Fries";
                    Total = BurgerCost;
                }
                else if (Code == "BTRCHK")
                {
                    Meal = "Butter Chicken";
                    Total = BtrChickCost;
                }
                Console.WriteLine($"You ordered {Meal} it costs {Total.ToString("C")}");

                Console.WriteLine("Do you want to order again Y/N  ?");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                { menu = false; }
                Console.Clear();
            } while (menu);
        }
    }
}
