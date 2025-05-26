using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class Room
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public bool IsBooked { get; set; }

        public override string ToString() =>
            $"Room {Number} - {Type} - {(IsBooked ? "Booked" : "Available")}";
    }
}
