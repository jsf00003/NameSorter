using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSortingApp
{
    public class Name
    {
        const char defaultDelimiter = ',';
        
        public string FirstPart { get; set; }
        public string LastPart { get; set; }

        public Name(string fullName, char delimiter = defaultDelimiter) {

            string[] names = fullName.Split(delimiter).Select(x => x.Trim()).ToArray();
            if (names.Length >= 1)
            {
                FirstPart = names[0];
                // if more than 2 parts, concatenate the rest
                for (int i = 1; i < names.Length; i++ )
                {
                    LastPart += names[i];
                }
            }
        }

    }
}
