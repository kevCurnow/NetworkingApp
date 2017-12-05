using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingApp.Models
{
    public class ConnectionCreateModel
    {
        [Required]
        public bool HaveMet { get; set; }

        [Required]
        public string ConnectionName { get; set; }

        public string Job { get; set; }
        public string Employer { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public bool LinkedIn { get; set; }

        public string Notes { get; set; }

        //TODO: figure out EventId (people you've already met)
        //public int EventId { get; set; }
    }
}
