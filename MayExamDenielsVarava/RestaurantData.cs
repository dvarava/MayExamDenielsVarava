using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MayExamDenielsVarava
{
    public class RestaurantData : DbContext
    {
        public RestaurantData() : base("OODExam_DenielsVarava") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
