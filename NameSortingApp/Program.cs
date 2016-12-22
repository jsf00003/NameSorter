using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NameSortingApp
{
    class NameSorter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text file name including the path: ");
            string fileName = Console.ReadLine();
            
            GenerateSortedFile(fileName);
        }

        public static void GenerateSortedFile(string fileNameWithPath)
        {
            List<Name> originalNames = NameService.ExtractNames(fileNameWithPath);
            if (originalNames == null)
                return;
            List<Name> sortedNames = NameService.GetSortedNames(originalNames);

            string newFileNameWithPath = FileNameService.GetNewFileNameWithPath(fileNameWithPath);

            GenerateOutput(newFileNameWithPath, sortedNames);
        }


        public static void GenerateOutput(string newFileName, List<Name> sortedNames)
        {
            try {
                using (StreamWriter sw = File.CreateText(newFileName))
                {
                    foreach (Name personName in sortedNames) {                       
                        sw.WriteLine(string.Format("{0}, {1}", personName.FirstPart, personName.LastPart));
                    }
                }
                Console.WriteLine("Output file generated!");
            }
            catch(Exception e) {
                Console.WriteLine("Fail to generate sorted file.");
                Console.WriteLine(e.Message);
            }
        }


    }
}
