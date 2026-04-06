using App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace App.Modelsö
{
    public class Ticket
    {
        public int TicketId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedDay {  get; set; }
        public Category Category { get; set; }
    }
}
