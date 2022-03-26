using System;
using Ex1.Entities.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in date.");
            }
            RoomNumber = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates must be future dates.");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in date.");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reservation: Room" + RoomNumber);
            sb.Append(", Check-in: " + CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(", check-out: " + CheckOut.ToString("dd/MM/yyyy"));
            sb.Append(", " + Duration() + " nights.\n");
            return sb.ToString();
        }
    }
}
