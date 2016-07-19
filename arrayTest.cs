using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructuresTest
{
    class arrayTest
    {
        static int randomWithRange(int range) {
            Random r = new Random();
            int rInt = r.Next(0, range); //for ints
            return rInt;
        }

        static int []randomArrayCreator(int range, int size) {

            int [] myArray = new int[size];
            for (int i = 0; i < size; i++) {
                myArray[i] = randomWithRange(range);
            }
            return myArray;
        }

        static void arrayPrinter(int [] myArray) {
            for (int i = 0; i < myArray.Length; i++) {
                System.Console.WriteLine(myArray[i]);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("hello from arrayTest");
            /*template: arrayName = new arrayType[allocationSize];*/
            int range = 121;
            int size = 12;
            int[] myArray = randomArrayCreator(range, size);
            Console.WriteLine("first element of array is " + myArray[1]);
            arrayPrinter(myArray);
        }
    }
}
