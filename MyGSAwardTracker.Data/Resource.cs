using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        public Guid OwnerId { get; set; }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public string ResourceTitle { get; set; }
        public string ResourceDescription { get; set; }        

        public DateTimeOffset DateResourceCreated { get; set; }
        public DateTimeOffset? DateResourceModified { get; set; }

        public virtual Project Project { get; set; }
    }
}
