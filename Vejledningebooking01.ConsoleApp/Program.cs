using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Vejledningebooking01.Domain.DAL;
using Vejledningebooking01.Domain.Model;

namespace Vejledningebooking01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var Context1 = new BookingContext(); // New DbContext   
            var calendar2 = new Vejledningebooking01.Domain.Model.Calendar { Id = 1}; // Create new Calendar
              
            Context1.Calendars.Add(calendar2); // Add Calendar to Db
            Context1.SaveChanges(); // Save

            var calendars = Context1.Calendars.AsNoTracking().ToList(); // Get all Calendars


            foreach (var c in calendars)   // Read Calendar
            {
                Console.WriteLine("IDDDDDDDDDDDD" + c.Id);
            }

            Console.ReadLine();
        }
    }
}
