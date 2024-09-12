using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace MultiEjercicios
{
    class ClassValidaciones
    {
        static public Boolean ValidaEmail (string Email)
        {
            String Exprecion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, Exprecion))
            {
                if (Regex.Replace(Email, Exprecion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
