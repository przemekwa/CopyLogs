using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopyLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy logs...");


            var dateStart = new DateTime(2019,8,10);
            var dateStop = new DateTime(2019,9,10);


            var take = 100;
            var skip = 0;


            
             using var db = new BeeOfficeContext();
             var result = db.AppErrors
                    .Skip(skip)
                    .Take(take)
                    .OrderByDescending(s => s.DateTime)
                    .ToList()
                    .SplitInToParts(4);



            var parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 4
            };

            

            Parallel.ForEach(result, parallelOptions, data => {

                  using var db = new BeeOfficeContext();
                foreach (var item in data)
                {
                    db.Attach(item);
                    item.UserName= "test2";

                }

                db.SaveChanges();

                
                });


                

               


        }


        

    }
}