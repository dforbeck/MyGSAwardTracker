using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        public Guid OwnerId { get; set; }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public string TaskDescription { get; set; }
        public DateTimeOffset ProposedTaskCompletionDate { get; set; }
        public Boolean TaskCompleted { get; set; }

        public DateTimeOffset DateTaskCreated { get; set; }
        public DateTimeOffset? DateTaskModified { get; set; }

        public virtual Project Project { get; set; }
    }
}
