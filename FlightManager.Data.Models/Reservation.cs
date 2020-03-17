using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManager.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public string FlightId{ get; set; }

        public int BusinessTickets { get; set; }

        public int RegularTickets { get; set; }

    }
}
