using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        string stringToTrim = "abTodab";
        char[] charactersToRemove = { 'a', 'b' };

        stringToTrim = Trimming(stringToTrim, charactersToRemove);

        Console.WriteLine(stringToTrim);











        string[] namesV1 = { "  Tod  ", "  Bob ", " Maria    ", "  Helena  ", "  Jacky  ", " John " };

        for (int i = 0; i < namesV1.Length; i++)
        {
            namesV1[i] = namesV1[i].Trim();
        }

        foreach (var name in namesV1)
        {
            Console.WriteLine(name);
        }

        //name = name.Trim(new char[] { ' ', 'g', 'd', 'f' });

        //Console.WriteLine(name);
    }

    static string Trimming(string stringToTrim, char[] charactersToRemove)
    {
        string trimmedString = string.Empty;
        List<int> indexesToSkip = new List<int>();
        int counter = 0;

        for (int i = 0; i < stringToTrim.Length; i++)
        {
            for (int j = 0; j < charactersToRemove.Length; j++)
            {
                if (stringToTrim[i] == charactersToRemove[j])
                {
                    indexesToSkip.Add(i);
                    break;
                }
                else
                {
                    counter++;
                }
            }

            if (counter == charactersToRemove.Length)
            {
                break;
            }

            counter = 0;
        }

        for (int i = stringToTrim.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < charactersToRemove.Length; j++)
            {
                if (stringToTrim[i] == charactersToRemove[j])
                {
                    indexesToSkip.Add(i);
                    break;
                }
                else
                {
                    counter++;
                }
            }

            if (counter == charactersToRemove.Length)
            {
                break;
            }

            counter = 0;
        }

        for (int i = 0; i < stringToTrim.Length; i++)
        {
            if (!indexesToSkip.Contains(i))
            {
                trimmedString += stringToTrim[i];
            }
        }

        return trimmedString;
    }
}