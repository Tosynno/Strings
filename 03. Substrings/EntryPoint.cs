using System;

class EntryPoint
{
    static void Main()
    {
        string fileDirectory = @"C:\Program Files\Microsoft\Word\Wo....rd.exe";
        string extension = string.Empty;
        string fileName = string.Empty;
        string firstFolder = string.Empty;
        string secondFolder = string.Empty;

        int startIndex = fileDirectory.IndexOf('P');
        int length = fileDirectory.IndexOf('s', 100) + 1 - startIndex;
        firstFolder = fileDirectory.Substring(startIndex, length);
        Console.WriteLine(firstFolder);

        startIndex = fileDirectory.LastIndexOf('.') + 1;
        length = fileDirectory.Length - startIndex;
        extension = fileDirectory.Substring(startIndex, length);
        Console.WriteLine(extension);

        startIndex = fileDirectory.LastIndexOf('\\') + 1;
        length = fileDirectory.LastIndexOf('.') - startIndex;
        fileName = fileDirectory.Substring(startIndex, length);
        Console.WriteLine(fileName);

        startIndex = NthIndexOf(fileDirectory, @"\", 2) + 1;
        length = NthIndexOf(fileDirectory, @"\", 3) - startIndex;
        secondFolder = fileDirectory.Substring(startIndex, length);
        Console.WriteLine(secondFolder);

    }

    static int NthIndexOf(string input, string toFind, int occurance)
    {
        int index = 0;
        int startIndex = 0;

        if (!input.Contains(toFind))
        {
            index = -1;
            return index;
        }

        for (int i = 0; i < occurance; i++)
        {
            index = input.IndexOf(toFind, startIndex);
            startIndex = index + 1;

            if (startIndex > input.Length)
            {
                index = -1;
                return index;
            }
        }

        return index;
    }
}
