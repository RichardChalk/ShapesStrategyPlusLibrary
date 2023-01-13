using MyClassLibrary;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesStrategyPlusLibrary
{
    public class App
    {
        private ApplicationDbContext _dbContext;
        public void GoGoGo()
        {
            var build = new Build();
            _dbContext = build.BuildDb();
            runMenu();
        }

        private void runMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1: Shapes");
                Console.WriteLine("2: Calculator");
                Console.WriteLine("3: Rock Paper Scissors");
                Console.WriteLine("0: Exit");

                var userAnswer = Console.ReadLine();
                if (userAnswer == "0") break;
                goSection(userAnswer);
            }
        }

        private void goSection(string? userAnswer)
        {
            switch (userAnswer)
            {
                case "1":
                    var goShapesMenu = new ShapesMenu(_dbContext);
                    goShapesMenu.ShowShapesMenu();
                    //Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("These are not the droids you are looking for!");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Nothing to see here... move along");
                    Console.ReadLine();
                    break;
                case "0":
                    Console.WriteLine("Case 0");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
