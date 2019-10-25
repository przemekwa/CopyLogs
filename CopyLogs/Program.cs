using System;
using System.Linq;

namespace CopyLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy logs...");

            using var db = new BeeOfficeContext();


            var result = db.AppErrors.Take(20).OrderBy(s => s.DateTime).ToList();


        }
    }
}
