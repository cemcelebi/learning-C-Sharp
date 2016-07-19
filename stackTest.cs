using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication2
{
    class gun
    {
    public string Name { get; set; }
    public int MagazineSize { get; set; }
    public Stack Magazine { get; set; }
        public gun(string name, Stack magazine,int magazineSize)
        {
            //this is the constructor
            Name = name;
            MagazineSize=magazineSize;
            Magazine = magazine;
        }
        public static void loadGun(gun gun) {
            for (int i = 0; i < gun.MagazineSize; i++)
            {
                gun.Magazine.Push("round "+i);
                Console.WriteLine("loaded a round");
            }
            
        }
        public static void fireGun(gun gun)
        {
            if (gun.Magazine.Count > 0)
            {
                Console.WriteLine("fired the round " + gun.Magazine.Pop());
            }
            else
            {
                Console.WriteLine("you can not fire an empty gun, click!");
            }
            
        }

    }
    class stackTest
    {
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write("    " + obj);
            }
            Console.WriteLine();
        }
        public static void firstStack()
        {
            Stack myStack = new Stack();
            //not much of a deal, same logic as Queue, different function names, same syntax.
            myStack.Push(3.14);
            myStack.Push("hello ");
            myStack.Push("world");
            Console.WriteLine("before pop: \n");
            PrintValues(myStack);
            myStack.Pop();
            myStack.Push("peter griffin");
            myStack.Push("the bird is the word");
            Console.WriteLine("after pop: \n");
            PrintValues(myStack);
        }
        
        static void Main(string[] args)
        {
            //firstStack();
            Stack myMagazine=new Stack();
            gun myGun = new gun("deagle", myMagazine, 7);
            Console.WriteLine("gun name: "+myGun.Name);
            ConsoleApplication2.gun.fireGun(myGun);
            ConsoleApplication2.gun.loadGun(myGun);
            ConsoleApplication2.gun.fireGun(myGun);
            ConsoleApplication2.gun.fireGun(myGun);
            ConsoleApplication2.gun.fireGun(myGun);
        }
    }
}
