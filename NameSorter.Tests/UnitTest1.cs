using System;
using System.Collections.Generic;
using Xunit;

public class NameSorterTests
{
    [Fact]
    public void SortNames_ShouldSortCorrectly()
    {
        // Arrange
        var names = new List<string> { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" };
        
        // Act
        var sortedNames = Program.SortNames(names);

        // Assert
        Assert.Equal("Adonis Julius Archer", sortedNames[0]);
        Assert.Equal("Vaughn Lewis", sortedNames[1]);
        Assert.Equal("Janet Parsons", sortedNames[2]);
    }
}
