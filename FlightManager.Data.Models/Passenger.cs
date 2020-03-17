using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManager.Data.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public string PhoneNumber { get; set; }

        public string Nationality { get; set; }

        public string TicketType { get; set; }

        public string ReservationId { get; set; }

        public string Email { get; set; }
    }
}
