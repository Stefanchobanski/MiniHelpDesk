using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;

namespace App.Repositories;

public interface IUserRepository : IRepository<User>
{
    User GetByUsername(string username);
    bool ExistsByUsername(string username);

}
