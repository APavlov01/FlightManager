using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.ViewModels
{
    public class SpecifyReservationViewModel
    {
        public int Id { get; set; }

        public int FlightID { get; set; }

        [Display(Name = "Regular Tickets")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter regular tickets count!")]
        [Range(0, Int32.MaxValue, ErrorMessage = "The number of regular tickets must be greater than 0!")]
        public int RegularTickets { get; set; }

        [Display(Name = "Business Tickets")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter business tickets count!")]
        [Range(0, Int32.MaxValue, ErrorMessage = "The number of business tickets must be greater than 0!")]
        public int BusinessTickets { get; set; }
    }
}
