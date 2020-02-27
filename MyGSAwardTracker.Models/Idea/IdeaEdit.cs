using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Models.Idea
{
    public class IdeaEdit
    {
        public int IdeaId { get; set; }

        [Display(Name = "Idea Title")]
        public string IdeaTitle { get; set; }

        [Display(Name = "Idea Description")]
        public string IdeaDescription { get; set; }
    }
}
