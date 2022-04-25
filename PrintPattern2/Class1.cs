using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPattern2
{
    internal class Class1
    {
        public static void pattern2()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

           
          
            Console.ReadLine();
        }
    }
}
