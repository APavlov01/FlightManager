using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.ViewModels
{
    public class CreateFlightViewModel
    {
        public int Id { get; set; }

        [Display(Name = "From")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a takeoff location")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,30}$", ErrorMessage = "The location should only contain letters")]
        public string TakeOffLocation { get; set; }

        [Display(Name = "To")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a landing location")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,30}$", ErrorMessage = "The location should only contain letters")]
        public string LandingLocation { get; set; }

        [Display(Name = "Departure")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a takeoff datetime")]
        public DateTime TakeOffDateTime { get; set; }

        [Display(Name = "Arrival")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a landing datetime")]
        public DateTime LandingDateTime { get; set; }

        [Display(Name = "Plane Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the type of the plane")]
        public string PlaneType { get; set; }

        [Display(Name = "Plane Unique Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the unique id of the plane")]
        public string PlaneUniqueId { get; set; }

        [Display(Name = "Pilot Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name of the pilot")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$", ErrorMessage = "A name should only contain letters")]
        public string PilotName { get; set; }

        [Display(Name = "Capacity")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the capacity of the plance")]
        [Range(1,Int32.MaxValue, ErrorMessage = "The capacity needs to be more than 0")]
        public int Capacity { get; set; }

        [Display(Name = "Business Class Capacity")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the capacity of the business class seats")]
        [Range(1, Int32.MaxValue, ErrorMessage = "The capacity needs to be more than 0")]
        public int BusinessClassCapacity { get; set; }
    }
}
