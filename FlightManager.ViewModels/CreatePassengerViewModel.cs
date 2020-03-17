using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.ViewModels
{
    public class CreatePassengerViewModel
    {
        [Display(Name = "First name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a username")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._]{4,20}", ErrorMessage = "The username should be between 5 and 20 characters and not start with a number")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a username")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._]{4,20}", ErrorMessage = "The username should be between 5 and 20 characters and not start with a number")]
        public string MiddleName { get; set; }

        [Display(Name = "Last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a username")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._]{4,20}", ErrorMessage = "The username should be between 5 and 20 characters and not start with a number")]
        public string LastName { get; set; }

        [Display(Name = "EGN")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your EGN")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter a valid EGN")]
        public string EGN { get; set; }

        [Display(Name = "Phone Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Type of ticket")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a ticket type")]
        public string TicketType { get; set; }

        [Display(Name = "ReservationId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the unique id of the reservation")]
        public int ReservationId { get; set; }

        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter an email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
