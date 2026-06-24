using App.Models;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class ServiceHelper
    {
        public static void CheckFields<T>(string userName, ILogger<T> logger, string type)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                logger.LogWarning($"{type} е празнa!");
                throw new FormatException($"{type} е празнa!");
            }
        }
        public static void ObjectIsNull<T, U>(U? user, ILogger<T> logger)
        {
            if (user == null)
            {
                logger.LogError($"{typeof(U).Name} не e намерен в базата данни!");
                throw new InvalidOperationException($"{typeof(U).Name} не e намерен!");
            }
        }
    }
}
