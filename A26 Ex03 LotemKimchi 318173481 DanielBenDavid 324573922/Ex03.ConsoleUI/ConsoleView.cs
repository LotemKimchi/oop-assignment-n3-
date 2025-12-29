using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;


namespace Ex03.ConsoleUI
{
    class ConsoleView
    {
        private GarageManager m_Garge;

        public ConsoleView()
        {
            m_Garge = new GarageManager();
        }
        public void Run()
        {
            runMenu();
        }

        private void runMenu()
        {
            bool exit = false;

            while(!exit)
            {
                printMenu();
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        loadVehiclesFromFile();
                        Console.WriteLine("");
                        break;

                    case "2":
                        insertVewVehicle();
                        Console.WriteLine();
                        break;
                    
                    case "3":
                        showLicenseNumbers();
                        Console.WriteLine();
                        break;
                    
                    case "4":
                        Console.WriteLine();
                        break; 
                    
                    case "5":
                        Console.WriteLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        break;

                    case "7":
                        Console.WriteLine();
                        break;

                    case "8":
                        Console.WriteLine();
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }

        private void printMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== Garage Menu ===");
            Console.WriteLine("1. Load vehicles from file");
            Console.WriteLine("2. Insert new vehicle");
            Console.WriteLine("3. Show license numbers");
            Console.WriteLine("4. Change vehicle status");
            Console.WriteLine("5. Inflate wheels to maximum");
            Console.WriteLine("6. Refuel vehicle");
            Console.WriteLine("7. Recharge vehicle");
            Console.WriteLine("8. Show full vehicle details");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

        }

        private void loadVehiclesFromFile()
        {

        }

        private void insertVewVehicle()
        {

        }

        private void showLicenseNumbers()
        {

        }
    }
}
