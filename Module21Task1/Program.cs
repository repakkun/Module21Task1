using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Module21Task1
{
    class Program
    {

        static void Main(string[] args)
        {          
            string text = File.ReadAllText("/Users/1/Downloads/Text1.txt");

            var watch1 = Stopwatch.StartNew();           

            var list = new List<string>();
            list.Add(text);
            Console.WriteLine($"Вставка в список: {watch1.Elapsed.TotalMilliseconds}  мс");
          
            var watch2 = Stopwatch.StartNew();

            var linkedList = new LinkedList<string>();
            linkedList.AddFirst(text);
            Console.WriteLine($"Вставка в  связанный список: {watch2.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
