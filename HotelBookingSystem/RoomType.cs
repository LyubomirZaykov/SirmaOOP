using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class RoomType
    {
        public string Type { get; set; }
        public double PricePerNight { get; set; }
        public double CancellationFee { get; set; }
        public string Amenities { get; set; }
        public int MaxOccupancy { get; set; }

        public override string ToString() =>
            $"{Type} - ${PricePerNight}/night - Max {MaxOccupancy} guests - Amenities: {Amenities}";
    }
}
