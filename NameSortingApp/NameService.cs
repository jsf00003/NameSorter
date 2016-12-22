using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NameSortingApp
{
    public static class NameService
    {
        public static List<Name> ExtractNames(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    List<string> names = File.ReadAllLines(fileName).ToList();
                    if (names != null)
                    {
                        return names.Select(n => new Name(n)).ToList();
                    }
                    else
                    {
                        Console.WriteLine("File does not contain any names. Please check the file and retry.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist. Please check the input and retry.");
                    return null;
                }

            }
            catch
            {
                Console.WriteLine("Fail to extract names from the file. Please check the input and retry.");
                return null;
            }
        }

        public static List<Name> GetSortedNames(List<Name> names)
        {
            if (names == null)
            {
                return null;
            }
            return names.OrderBy(n => n.FirstPart).ThenBy(n => n.LastPart).ToList();
        }

    }
}
