using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLine_Console.Models
{
    public class Note
    {
        public int Id { get; set; }
        public Employee WrittenBy { get; set; }
        public string NoteText { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
