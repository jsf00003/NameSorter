using Xunit;
using NameSortingApp;
using System.Reflection;
using System.Resources;
using System.IO;

namespace UnitTests
{
    public class NameServiceTest
    {
        string _validFilePath, _invalidFilePath;

        public NameServiceTest() {
            string resFolderPath = Path.Combine(System.Environment.CurrentDirectory, "Resources");
            _validFilePath = resFolderPath + "\\namelist.txt";
            _invalidFilePath = resFolderPath + "\\invalidNamelist.txt";
        }

        [Fact]
        public void ShouldNotExtractNames()
        {
            Assert.Null(NameService.ExtractNames(@"C:\NoSuchFile"));
            Assert.Null(NameService.ExtractNames(_invalidFilePath));
        }

        [Fact]
        public void ShouldExtractNames()
        {
            var names = NameService.ExtractNames(_validFilePath);
            Assert.Equal(4, names.Count);
        }
    }
}
