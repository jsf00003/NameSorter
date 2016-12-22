using System;
using System.Collections.Generic;
using NameSortingApp;
using Xunit;

namespace UnitTests
{
    public class FileNameServiceTest
    {
        [Fact]
        public void ShouldGenerateNewName()
        {
            Assert.Equal(@"C:\originFile-sorted.txt", FileNameService.GetNewFileNameWithPath((@"C:\originFile.txt")));
        }
    }
}
