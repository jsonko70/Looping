using System;


namespace Looping
{
    class LargestandSmallestNumbers
    {
        static void Main(string[] args)
        {
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry;

            Console.WriteLine("Enter an integer: ");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer or Q to Quit: ");
            strEntry = Console.ReadLine();

            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }
                Console.WriteLine("Enter another integer or Q to Quit: ");
                strEntry = Console.ReadLine();
            }
            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was " + nSmallest + ".");

            Console.ReadLine();
        }
    }
}
