using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main()
    {
        char[] charactersToSplitBy = { ' ', ',', 'T', 'H', 'a', 'o' };

        string namesV1 = "Tod Bob Maria Helena Jacky John";
        string namesV2 = "Tod, Bob, Maria, Helena, Jacky, John";
        string namesV3 = "Tod,,,THao Bob,,,THao Maria,,,THao Helena,,,THao Jacky,,,THao John";

        string[] splitNamesV1 = namesV1.Split(' ');
        string[] splitNamesV2 = namesV2.Split(new char[] { ' ', ',' }, StringSplitOptions.None);
        string[] splitNamesV3 = namesV3.Split(new string[] { ",,,TH", "ao " }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var name in splitNamesV3)
        {
            Console.WriteLine(name);
        }

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/sitemap-posttype-post.xml");

        string[] pageSource = driver.PageSource.Split('>');


        foreach (var line in pageSource)
        {
            Console.WriteLine(line);
        }

        int startIndex = 0;
        int length = 0;
        List<string> links = new List<string>();

        foreach (var link in pageSource)
        {
            if (link.Contains(@"""http://testing.todvachev.com"))
            {
                startIndex = link.IndexOf('"') + 1;
                length = link.LastIndexOf('"') - startIndex;
                links.Add(link.Substring(startIndex, length));
            }
        }

        foreach (var link in links)
        {
            Console.WriteLine(link);
        }
    }
}
