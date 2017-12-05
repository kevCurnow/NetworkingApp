using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingApp.Models
{
    public class ConnectionDetailModel
    {
        public int ConnectionId { get; set; }
        public string ConnectionName { get; set; }

        public string Job { get; set; }
        public string Employer { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public bool LinkedIn { get; set; }

        //TODO: figure out if notes is needed here. What does this model belong to, the event details or your connection list?
        public string Notes { get; set; }

        //TODO: Would it be useful to list out events you interacted with existing connections at?
        //public int EventId { get; set;}
        //public string EventInteractions {get; set;}
    }
}
