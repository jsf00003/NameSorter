using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSortingApp
{
    public static class FileNameService
    {
        public static string GetNewFileNameWithPath(string fileNameWithPath){
            string fileName = Path.GetFileName(fileNameWithPath);
            string newFileName = Path.GetFileNameWithoutExtension(fileNameWithPath) + "-sorted" + Path.GetExtension(fileNameWithPath);
            return fileNameWithPath.Replace(fileName, newFileName);        
        }
    }
}
