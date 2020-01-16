using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Data
{
    public class Fund
    {
        [Key]
        public int FundId { get; set; }

        public Guid OwnerId { get; set; }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public string FundDescription { get; set; }
        public double FundingAmount { get; set; }

        public DateTimeOffset DateFundCreated { get; set; }
        public DateTimeOffset? DateFundModified { get; set; }

        public virtual Project Project { get; set; }
    }
}
