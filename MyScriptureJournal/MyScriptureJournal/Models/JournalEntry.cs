using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        public String Book { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please Enter Only Numbers")]
        public String Chapter { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please Enter Only Numbers")]
        public String Verse { get; set; }

        public String Notes { get; set; }

    }
}
