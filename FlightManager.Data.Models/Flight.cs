using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManager.Data.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string TakeOffLocation { get; set; }

        public string LandingLocation { get; set; }

        public DateTime TakeOffDateTime { get; set; }

        public DateTime LandingDateTime { get; set; }

        public string PlaneType { get; set; }

        public string PlaneUniqueId { get; set; }

        public string PilotName { get; set; }

        public int Capacity { get; set; }

        public int BusinessClassCapacity { get; set; }
    }
}
