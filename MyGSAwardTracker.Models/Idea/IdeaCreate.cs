using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Models.Idea
{
    public class IdeaCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [Display(Name = "Idea Title")]
        public string IdeaTitle { get; set; }

        [Display(Name = "Idea Description")]
        public string IdeaDescription { get; set; }

        public override string ToString() => IdeaTitle;
    }
}
