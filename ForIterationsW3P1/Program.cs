using System;

namespace ForIterationsW3P1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // i++ is the incriment operator it is the equivelent to writing i +1
            // this code will frun until i is no longet less then ten

            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine(i.ToString());
                if (i == 7)
                {
                    Console.WriteLine("Found Seven!");
                    break;
                    // this makes the for statement stop once the block of code is executed
                    // and it is only executed when the for statement works 
                }
            }
            // type for and hit tab twice and it will breate a complete for iteration
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }


            Console.ReadLine();
        }
    }
}
