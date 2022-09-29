using System;
using System.IO;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workWithFile = new WorkWithFile();

            //workWithFile.Generate();

            //var sort = new MySort("a.data");

            //sort.Sort();

            workWithFile.Output("B.data", 1000);
            Console.WriteLine();
            workWithFile.Output(34359738368 - 1024, "B.data");
        }		
	}

}
