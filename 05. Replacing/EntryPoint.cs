using System;

class EntryPoint
{
    static void Main()
    {
        string[] fileDirectories =
        {
            @"C:\Program Files\Microsoft\Word.exe",
            @"D:\Games\Blizzard\World of Warcraft.exe",
            @"C:\Program Files\Microsoft\Powerpoint.exe"
        };

        int startIndex = 0;
        int length = 0;
        string fileName = string.Empty;

        for (int i = 0; i < fileDirectories.Length; i++)
        {
            startIndex = fileDirectories[i].LastIndexOf('\\') + 1;
            length = fileDirectories[i].LastIndexOf('.') - startIndex;
            fileName = fileDirectories[i].Substring(startIndex, length);
            fileDirectories[i] = Replacing(fileDirectories[i], startIndex, length, "Nothing");
            //fileDirectories[i] = fileDirectories[i].Replace(fileName, "!!!!!!!");
        }

        foreach (var directory in fileDirectories)
        {
            Console.WriteLine(directory);
        }
    }

    static string Replacing(string input, int startIndex, int length, string replaceWith)
    {
        string replacedString = string.Empty;
        bool added = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (!(i >= startIndex && i < length + startIndex))
            {
                replacedString += input[i];
            }
            else if (!added)
            {
                replacedString += replaceWith;
                added = true;
            }
        }

        return replacedString;
    }

}
