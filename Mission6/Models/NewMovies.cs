using System.ComponentModel.DataAnnotations;

namespace Mission06_Bangerter.Models
{
    public class NewMovies
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public required string Category { get; set; }
        public required string Title { get; set; }
        public required string Year { get; set; }
        public required string Director { get; set; }
        public required string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        //set the length to 25 max
        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters long.")]
        public string? Notes { get; set; }

    }
}
