using System;
using System.ComponentModel.DataAnnotations;

namespace MyGSAwardTracker.Data
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        public Guid OwnerId { get; set; }

        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }

        public DateTimeOffset ExpenseDate { get; set; }
        public string ExpenseDescription { get; set; }
        public double ExpenseAmount { get; set; }

        public DateTimeOffset DateExpenseCreated { get; set; }
        public DateTimeOffset? DateExpenseModified { get; set; }

        public virtual Project Project { get; set; }
    }
}
