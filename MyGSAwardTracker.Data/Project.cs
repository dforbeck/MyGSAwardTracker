using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public enum ProjectAwardLevel {Bronze, Silver, Gold}

    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public Guid OwnerId { get; set; }

        public int IdeaId { get; set; }
        public string IdeaTitle { get; set; }

        [Required]
        public ProjectAwardLevel LevelOfProjectAward { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescritpion { get; set; }
        public string ProjectSustainabilityAspect { get; set; }
        public DateTimeOffset ProposedProjectStartDate { get; set; }
        public DateTimeOffset? ProposedProjectCompletionDate { get; set; }
        public Boolean CompletedPriorAward { get; set; }
        public Boolean PriorAwardApproved { get; set; }
        public string JourneyCompleted { get; set; }
        public string OtherJourneyCompleted { get; set; } 
        public string ProjectAdvisor { get; set; }
        public string CouncilMentor { get; set; }
        public string TroopLeader { get; set; }

        public DateTimeOffset DateProjectCreated { get; set; }
        public DateTimeOffset? DateProjectModified { get; set; }

        public virtual Idea Idea { get; set; }
    }
}
