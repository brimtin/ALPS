using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Alps.Model
{
    class Alps : DbContext
    { 
        public DbSet<User> User { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<FirtLineSupervisor> FirtLineSupervisor { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Commander> Commander { get; set; }
        public DbSet<FirstSergeant> FirstSergeant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ALPS;Integrated Security=true");
        }

    }

    public class FirstSergeant
    {
        [Key]
        public string EmailAddress1sg { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int phone { get; set; }
    }

    public class Commander
    {
        [Key]
        public string EmailAddressCO { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int phone { get; set; }
    }

    public class Request
    {
        public int RequestID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserID { get; set; }
        User User { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }

    public class FirtLineSupervisor
    {
        [Key]
        public string EmailAddressFL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int phone { get; set; }
    }

    public class Unit
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public string Installation { get; set; }
        public int StaffDuty { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }


        public string EmailAddressCO { get; set; }
        public Commander Commander { get; set; }

        public string EmailAddress1sg { get; set; }
        public FirstSergeant FirstSergeant { get; set;}



    }

    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Dob { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }

        public int UnitID { get; set; }
        public Unit Unit { get; set; }

        public string EmailAddressFL { get; set; }
        public FirtLineSupervisor FirtLineSupervisor { get; set; }

    }
}
