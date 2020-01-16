using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        public Guid OwnerId { get; set; }

        [Required]
        public string IdeaTitle { get; set; }

        public string IdeaDescription { get; set; }

        public DateTimeOffset DateIdeaCreated { get; set; }
        public DateTimeOffset? DateIdeaModified { get; set; }

        public virtual Project Project { get; set; }
    }
}
