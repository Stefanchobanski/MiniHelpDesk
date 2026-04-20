using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class FormHelper
    {
        public static void CheckSelectedIndex(int index)
        {
            if (index == -1)
            {
                throw new IndexOutOfRangeException("Not selected item");
            }
        }
    }
}
