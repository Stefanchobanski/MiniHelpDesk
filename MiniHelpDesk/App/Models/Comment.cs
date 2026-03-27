using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int TicketID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

    }
}
