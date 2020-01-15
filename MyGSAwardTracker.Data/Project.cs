using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public Guid OwnerId { get; set; }
        public int IdeaId { get; set; }

        public virtual Idea IdeaTitle { get; set; }
        
        public string ProjectTitle { get; set; }
        public string ProjectDescritpion { get; set; }
        public string Sustainability { get; set; }
        public DateTimeOffset ProjectStartDate { get; set; }
        public DateTimeOffset? ProjectCompletionDate { get; set; }
        public Boolean PriorAward { get; set; }
        public Boolean PriorAwarApproved { get; set; }
        public string JourneyCompleted { get; set; }
        public string OtherJourneyCompleted { get; set; } 
        public string ProjectAdvisor { get; set; }
        public string CouncilMentor { get; set; }
        public string TroopLeader { get; set; }
 

        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateModified { get; set; }

    }
}
