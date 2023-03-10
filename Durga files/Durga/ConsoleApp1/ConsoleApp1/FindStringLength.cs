using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FindStringLength
    {
        public bool IsCharExistsInString(string? sName, string? searchChar)
        {
            //Case 1
            bool found = sName.Contains(searchChar);


            return found;
        }
    }
}
