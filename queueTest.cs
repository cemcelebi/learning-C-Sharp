using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
    }
     
    class queueTest
    {
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write("    "+ obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(4);
            Queue anotherQueue = new Queue(2);
            myQueue.Enqueue(3.14);
            myQueue.Enqueue("hello");
            Person person1 = new Person("Leopold", 6);
            myQueue.Enqueue(person1);
            anotherQueue.Enqueue("this line is from");
            anotherQueue.Enqueue("the other Queue");
            myQueue.Enqueue(anotherQueue);
            PrintValues(myQueue);
            PrintValues(anotherQueue);
        }
    }
}
