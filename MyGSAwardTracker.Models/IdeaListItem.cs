using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Models
{
    public class IdeaListItem
    {
        [Display(Name = "Idea ID")]
        public int IdeaId { get; set; }

        [Display(Name = "Idea Title")]
        [Required]
        public string IdeaTitle { get; set; }

        [Display(Name = "Idea Description")]
        public string IdeaDescription { get; set; }

        [Display(Name = "Date Idea Hatched")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset DateIdeaCreated { get; set; }

        [Display(Name = "Date Idea Changed")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? DateIdeaModified { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
