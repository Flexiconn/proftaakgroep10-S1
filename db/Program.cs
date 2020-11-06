using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext context = new SchoolContext();

            Console.WriteLine(context.Database.EnsureCreated());

            var plantData = new DbModel.plantData()
            {

                plantID = "2"
            };

            var planten = new DbModel.meetData()
            {
                deviceNaam = "test",
                co2Gehalte = 1,
                zuurstofGehalte = 1,
                plantID = "2"


            };

            using (var test = new SchoolContext())
            {
                // Attach an entity to DbContext with Added state
                test.Add<DbModel.meetData>(planten);
                test.Add<DbModel.plantData>(plantData);



                // Calling SaveChanges to insert a new record into Students table
                test.SaveChanges();
            }
        }
    }
}
