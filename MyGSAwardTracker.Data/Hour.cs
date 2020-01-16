using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Hour
    {
        [Key]
        public int HourId { get; set; }

        public Guid OwnerId { get; set; }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public DateTimeOffset HoursDate { get; set; }
        public string HourDescription { get; set; }
        public double Hours { get; set; }

        public DateTimeOffset DateHoursCreated { get; set; }
        public DateTimeOffset? DateHoursModified { get; set; }

        public virtual Project Project { get; set; }

    }
}
