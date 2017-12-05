using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingApp.Models
{
    public class EventEditModel
    {
        [Required]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        public string EventLocation { get; set; }
    }
}
