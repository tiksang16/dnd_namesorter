using System.Collections.Generic;
using Xunit;

namespace NameSorter.Tests
{
    public class NameSorterTests
    {
        [Fact]
        public void SortNames_ShouldReturnSortedNames()
        {
            var unsortedNames = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
            };

            var expectedSortedNames = new List<string>
            {
                "Adonis Julius Archer",
                "Vaughn Lewis",
                "Janet Parsons"
            };

            var sortedNames = Program.SortNames(unsortedNames);

            // Assertion
            Assert.Equal(expectedSortedNames, sortedNames);
        }
    }
}
