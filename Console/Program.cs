using System.Linq;
using AZUXlib.DataAccess;
using AZUXlib.Models;
using System;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(CategoryAccess.Find(1).CategoryName);
            System.Console.ReadKey();
        }
    }
}
