using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MayExamDenielsVarava
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOfParticipants { get; set; }

        public virtual Customer Customer { get; set; } // navigation property
        public int CustomerId { get; set; } // foreign key

        public string ToString()
        {
            return $"{Customer.Name} ({Customer.ContactNumber}) - Party of {NumberOfParticipants}";
        }
    }
}
