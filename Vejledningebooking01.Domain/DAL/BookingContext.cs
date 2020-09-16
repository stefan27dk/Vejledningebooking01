using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Vejledningebooking01.Domain.Model;

namespace Vejledningebooking01.Domain.DAL
{
    public class BookingContext : DbContext
    {
        public   BookingContext() : base("BookingContext")
        {     
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<Booking> Bookings { get; set; } 
        public DbSet<Timeslot> Timeslots { get; set; } 
        public DbSet<Calendar> Calendars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

        }
    }
}
