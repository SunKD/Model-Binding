using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranter.Models
{
    public class RReview
    {
        public int id { get; set; }

        [Display(Name = "Reviewer Name")]
        [Required]
        [MinLength(3)]
        public string Name  { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required]
        [MinLength(3)]
        public string RestaurantName { get; set; }

        [Display(Name = "Stars")]
        [Required]
        public int Stars { get; set; }

        [Display(Name = "Review")]
        [Required]
        [MinLength(10)]
        public string Review { get; set; }

        [Display(Name = "Date of Visit")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VisitedDate { get; set; }
        public DateTime Created_at { get; set; }
    }
}