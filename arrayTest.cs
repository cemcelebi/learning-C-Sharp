using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructuresTest
{
    class arrayTest
    {
        static int randomWithRange(Random r, int range) {
            
            int rInt = r.Next(0, range); //for ints
            return rInt;
        }

        static int []randomArrayCreator(int range, int size) {
            Random r = new Random();
            int [] myArray = new int[size];
            for (int i = 0; i < size; i++) {
               myArray[i] = randomWithRange(r, range);
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
            arrayPrinter(myArray);
            
        }
    }
}
