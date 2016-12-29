using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Team Name is required to create new team!")]
        [MaxLength(30, ErrorMessage = "Team Name should be shorter than 30 characters!")]
        [MinLength(1, ErrorMessage = "Team Name should contain at leat 1 charcter.")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
    }
}
