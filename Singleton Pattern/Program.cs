using System;

namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 =  Counter.GetInstance();
            Counter counter2 = Counter.GetInstance();
            counter1.Addone();
            counter2.Addone();
            Console.WriteLine("counter1 : " + counter1.count.ToString());
            Console.WriteLine("counter2 : " + counter1.count.ToString());
            Console.WriteLine();
            
            counter1.Addone();
            Console.WriteLine("counter1 : " + counter1.count.ToString());
            Console.WriteLine("counter2 : " + counter1.count.ToString());

        }
    }
}
