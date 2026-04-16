using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    internal class Attachment
    {
        [Key]
    public string Id { get; set; }

        [Required]
        public string TicketId { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string Path { get; set; }
    }
}
