using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Models.Idea
{
    public class IdeaListItem
    {       
        [Required]
        [Display(Name = "Idea Title")]
        public string IdeaTitle { get; set; }

        [Display(Name = "Idea Description")]
        public string IdeaDescription { get; set; }

        [Display(Name = "Date Idea Hatched")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset DateIdeaCreated { get; set; }

        [Display(Name = "Date Idea Changed Last")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? DateIdeaModified { get; set; }

        public override string ToString() => IdeaTitle;
    }
}
