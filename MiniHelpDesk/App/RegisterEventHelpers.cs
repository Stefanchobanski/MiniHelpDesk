using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App;

public static class RegisterEventHelpers
{
    public static bool CheckAllFields(string txtUsername, string txtEmail, string txtPassword, string txtConfirmPassword)
    {
        return string.IsNullOrWhiteSpace(txtUsername) ||
               string.IsNullOrWhiteSpace(txtEmail) ||
               string.IsNullOrWhiteSpace(txtPassword) ||
               string.IsNullOrWhiteSpace(txtConfirmPassword);
    }
}
