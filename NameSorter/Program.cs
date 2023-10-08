using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
   
        string unsortedNamesFile = args[0];

        // Read unsorted names from the file
        List<string> unsortedNames = ReadNamesFromFile(unsortedNamesFile);

        // Sort the names
        List<string> sortedNames = SortNames(unsortedNames);

        // Display the sorted names to the console
        DisplaySortedNames(sortedNames);

        // Write the sorted names to a file
        WriteSortedNamesToFile(sortedNames, "sorted-names-list.txt");
    }

    public static List<string> ReadNamesFromFile(string fileName)
    {
        List<string> names = new List<string>();
        using (StreamReader sr = new StreamReader(fileName))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                names.Add(line);
            }
        }
        return names;
    }

    public static List<string> SortNames(List<string> unsortedNames)
    {
        for (int i = 0; i < unsortedNames.Count - 1; i++)
        {
            for (int j = 0; j < unsortedNames.Count - i - 1; j++)
            {
                string[] parts1 = unsortedNames[j].Split(' ');
                string[] parts2 = unsortedNames[j + 1].Split(' ');

                int result = parts1[parts1.Length - 1].CompareTo(parts2[parts2.Length - 1]);

                if (result == 0)
                {
                    result = unsortedNames[j].CompareTo(unsortedNames[j + 1]);
                }

                if (result > 0)
                {
                    var temp = unsortedNames[j];
                    unsortedNames[j] = unsortedNames[j + 1];
                    unsortedNames[j + 1] = temp;
                }
            }
        }
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
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (string name in sortedNames)
            {
                sw.WriteLine(name);
            }
        }
    }

}

