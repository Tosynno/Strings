using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        DateTime start = DateTime.Now;
        string testOne = Concatenator('a', 200000);
        DateTime end = DateTime.Now;
        Console.WriteLine(end - start);

        DateTime startTwo = DateTime.Now;
        StringBuilder testTwo = ConcatenatorSB('a', 200000000);
        DateTime endTwo = DateTime.Now;
        Console.WriteLine(endTwo - startTwo);

        string testThree = testTwo.ToString();
    }

    static string Concatenator(char characterToConcatenate, int count)
    {
        string concatenatedString = string.Empty;

        for (int i = 0; i < count; i++)
        {
            concatenatedString += characterToConcatenate;
        }

        return concatenatedString;
    }

    static StringBuilder ConcatenatorSB(char characterToConcatenate, int count)
    {
        StringBuilder concatenatedString = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            concatenatedString.Append(characterToConcatenate);
        }

        return concatenatedString;
    }
}
