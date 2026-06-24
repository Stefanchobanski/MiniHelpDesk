using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.DTOs;

public class CommentDTO
{
    public int CommentID { get; set; }
    public string Text { get; set; } = null!;
    public DateTime CreatedDate { get; set; }

    public string Display  => $"Comment id: {CommentID} - {Text} - {CreatedDate.Date}";
    
}
