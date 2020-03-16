using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.ViewModels
{
    public class SpecifyReservationViewModel
    {
        [Display(Name = "Ticket Count")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a phone number")]
        public string TicketCount { get; set; }
    }
}
