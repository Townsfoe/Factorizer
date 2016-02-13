using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Test program to factor large numbers for a Project Euler problem
        by Jacob Townsend */


namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Establishing Variables
            String strFactor = Console.ReadLine();
            long toFactor = Convert.ToInt64(strFactor);
            List<long> factors = new List<long>();
            #endregion
            #region Checking 2
            if (toFactor%2==0)
            {
                factors.Add(2);
                toFactor /= 2;
            }
            #endregion
            #region Factoring odds
            for (int i = 3; i*i< toFactor;i+=2)
            {
                if(toFactor%i==0)
                {
                    factors.Add(i);
                    toFactor /= i;
                }
            }
            #endregion
            #region Printing Answer

            foreach (long num in factors)
            {
                Console.WriteLine(num);
            }
            #endregion
            #region User Acknowledgement
            Console.WriteLine("Press Enter to terminate");
            Console.ReadLine();
            #endregion

        }
    }
}
