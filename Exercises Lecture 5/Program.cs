using System;
using System.IO;

namespace Exercises_Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Read -----

            //ReadInteger();
            //try
            //{
            //string[] dir = Directory.GetFiles(@"C:\foo");
            //File.Delete(dir[0]);
            //File.ReadAllText(dir[0]);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (UnauthorizedAccessException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // -----Bank account------

            //bankAccount Lars = new bankAccount(10);
            //try
            //{
            //    Lars.withdraw(100);
            //}
            //catch (InsufficientFundsException e)
            //{
            //    Console.WriteLine(e.Message); 
            //}

            // -----Gear box-----

            //GearBox myGear = new GearBox(1);
            //myGear.changeGear(1);

            // ------ Digital Display -----

            //DigitalDisplay myDisplay = new DigitalDisplay(new int[] { 2, 4, 8, 10 });
            //myDisplay.GetDigit(1);
            //myDisplay.SetDigit(2, 1000);

            // ----- Printer from Hell -----
            PrinterFromHell raymondPrinter = new PrinterFromHell();
            while (true)
            {
                try
                {
                    raymondPrinter.print();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
        }

        static void ReadInteger()
        {
            string input = Console.ReadLine();
            try
            {
                int inputNumber = int.Parse(input);
                Console.WriteLine(inputNumber);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                ReadInteger();
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                ReadInteger();
            }
        }
    }
}
