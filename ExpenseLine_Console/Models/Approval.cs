using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLine_Console.Models
{
    public class Approval
    {
        public int Id { get; set; }
        public Employee Approver { get; set; }
        public List<Note> ApprovalComments { get; set; }
        public DateTime DateApproved { get; set; }
        public bool IsApproved { get; set; }
    }
}
