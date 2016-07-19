using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructuresTest
{
    class helloWorldandFunctionTest
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world");
            Console.WriteLine("hey hoo "+(4+3));
            int a = 5;
            double f = 3.14;
            while (a > 0)
            {
                Console.WriteLine("pi is not " + f);
                int scopeTest=319;
                a--;
            }
            try {
                //Console.WriteLine("scopeTest?" + scopeTest);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("\n variable created in loop can't be reached from the outside!!!");
                Console.WriteLine(e.GetBaseException());
            }
            int bit1 = 0;
            int bit2 = 1;

            Console.WriteLine("\n oneBitOrGate of "+bit1+" and "+bit2+" is: "+ oneBitOrGate(bit1,bit2)+"\n");

        }
        static int oneBitOrGate(int bit1, int bit2) {
            int returnVal = 0;
            if (bit1 == 0 && bit2 == 0) {
                return 0;
            }
            if (bit1 == 0 && bit2 == 1)
            {
                returnVal=1;
            }
            if (bit1 == 1 && bit2 == 0)
            {
                returnVal=1;
            }
            if (bit1 == 1 && bit2 == 1)
            {
                returnVal=1;
            }
            return returnVal;

        }
    }

}
