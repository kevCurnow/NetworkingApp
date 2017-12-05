using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkingApp.Models
{
    public class ConnectionListModel
    {
        //TODO: Do we need ConnectionId when just listing out connections?
        public int ConnectionId { get; set; }

        public string ConnectionName { get; set; }
        public string Job { get; set; }
        public string Employer { get; set; }

        //TODO: Figure out EventInteractions
        //public string EventInteractions { get; set; }
    }
}
