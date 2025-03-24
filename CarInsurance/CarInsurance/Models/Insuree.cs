using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Display(Name = "DOB")]
        public DateOnly DateOfBirth { get; set; }

        [Display(Name = "Car Year")]
        public int CarYear { get; set; }

        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Display(Name = "Car Model")]
        public string CarModel { get; set; }
        public bool DUI { get; set; }

        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }

        [Display(Name = "Coverage Type")]
        public string CoverageType { get; set; }
        public decimal  Quote { get; set; }
    }
}
