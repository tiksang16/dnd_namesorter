using System;
using System.Collections.Generic;
using System.IO;

public class NameSorter
{
    public static List<string> ReadNamesFromFile(string fileName)
    {
        List<string> names = new List<string>();
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
        return names;
    }

    public static List<string> SortNames(List<string> unsortedNames)
    {
        unsortedNames.Sort((name1, name2) =>
        {
            string[] parts1 = name1.Split(' ');
            string[] parts2 = name2.Split(' ');

            // Compare last names first
            int result = parts1[parts1.Length - 1].CompareTo(parts2[parts2.Length - 1]);

            if (result == 0)
            {
                // If last names are the same, compare given names
                result = name1.CompareTo(name2);
            }

            return result;
        });

        return unsortedNames;
    }

    public static void DisplaySortedNames(List<string> sortedNames)
    {
        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }

    public static void WriteSortedNamesToFile(List<string> sortedNames, string fileName)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string name in sortedNames)
                {
                    sw.WriteLine(name);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to the file: " + ex.Message);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Check if the correct number of command-line arguments is provided
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: dotnet run <path_to_unsorted_names_file>");
            return;
        }

        string unsortedNamesFile = args[0];

        // Read unsorted names from the file
        List<string> unsortedNames = NameSorter.ReadNamesFromFile(unsortedNamesFile);

        // Sort the names
        List<string> sortedNames = NameSorter.SortNames(unsortedNames);

        // Display the sorted names to the console
        NameSorter.DisplaySortedNames(sortedNames);

        // Write the sorted names to a file
        NameSorter.WriteSortedNamesToFile(sortedNames, "sorted-names-list.txt");
    }

}

