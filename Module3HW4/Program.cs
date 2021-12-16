using System;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var task1 = new Task1();
            var task2 = new Task2();
            Console.WriteLine(task1.SumOfSum());

            task2.LINQTesting();
        }
    }
}