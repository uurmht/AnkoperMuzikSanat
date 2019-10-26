using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnkoperSanatveMuzikOkulu.Entity
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DataConnection")
        {

            Database.SetInitializer(new DataInitilializer());

        }


        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}