using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
