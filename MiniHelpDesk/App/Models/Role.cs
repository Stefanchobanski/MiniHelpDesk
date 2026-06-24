using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models;

public class Role
{
    public int RoleID { get; set; }
    public string Name { get; set; } = null!;

    public List<User> Users { get; set; } = new List<User>();

}
