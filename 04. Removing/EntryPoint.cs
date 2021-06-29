using System;

class EntryPoint
{
    static void Main()
    {
        string fileDirectory = @"C:\Program Files\Microsoft\Word\Word.exe";

        string path = fileDirectory.Remove(fileDirectory.LastIndexOf('\\') + 1);

        int startIndex = NthIndexOf(fileDirectory, @"\", 3) + 1;
        int length = NthIndexOf(fileDirectory, @"\", 4) - startIndex + 1;
        string pathWithoutThirdFolderV1 = fileDirectory.Remove(startIndex, length);
        string pathWithoutThirdFolderV2 = Removing(fileDirectory, startIndex, length);

        Console.WriteLine(pathWithoutThirdFolderV1);
        Console.WriteLine(pathWithoutThirdFolderV2);
    }

    static string Removing(string input, int startIndex, int length)
    {
        string modifiedString = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (!(i >= startIndex && i < length + startIndex))
            {
                modifiedString += input[i];
            }
        }
        
        return modifiedString;
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