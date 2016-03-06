using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

// This C# scraper uses Selenium browser to scrape job offers on Indeed.com and feed them to a local MySQL database called mysqltest
namespace Scraper
{
    class Program
    {
        static void Main()
        {
            // Instanciation of a Dbcontext (handles the conection to MySQL DB)
            var context = new db_Entities();

            //// instanciation of a Firefox browser (using Selenium)
            //FirefoxDriver firefox = new FirefoxDriver();

            //// go to job website of interest (Indeed.com)
            //firefox.Navigate().GoToUrl("http://www.indeed.fr/emplois?q=Csharp&l=Paris+%2875%29");

            //// find list of job offers with an Xpath parsing
            //var offers = firefox.FindElementsByXPath("//div[@class = '  row  result']");

            //// for each job offer, find title, body, date and link
            //foreach (var offer in offers)
            //{
            //    // finding title
            //    var title = offer.FindElement(By.XPath("h2")).Text;
            //    Console.WriteLine(title);

            //    // finding body
            //    var body = offer.FindElement(By.XPath(".//span[@class = 'summary']")).Text;
            //    Console.WriteLine(body);

            //    // finding date
            //    var date_raw = offer.FindElement(By.XPath(".//span[@class = 'date']")).Text;
            //    // transforming date from ("2 days ago") to DateTime format
            //    var date = DateTime.Now.AddDays(-Int32.Parse(Regex.Match(date_raw, @"\d+").Value));
            //    Console.WriteLine(date);

            //    // finding url link to the offer
            //    var link = offer.FindElement(By.XPath("h2/a")).GetAttribute("href");
            //    Console.WriteLine(link);

            //    // creating an article object with all these information
            //    Article art = new Article{title = title, body = body, link = link, created = date};

            //    // if the url link is not already in a databse row
            //    if (!context.Article.Any(a => string.Compare(a.link, link, StringComparison.CurrentCultureIgnoreCase) == 0))
            //    {
            //        // write the article in the database
            //        context.Article.Add(art);
            //        context.SaveChanges();
            //    }

            //    // skip a line
            //    Console.WriteLine();
            //}
            
            
            // write all articles from the DB in the console
            var articles = context.Article.ToList();
            foreach (var art in articles)
            {
                Console.WriteLine(art.id);
                Console.WriteLine(art.title);
                Console.WriteLine(art.body);
                Console.WriteLine(art.created);
                Console.WriteLine(art.link);

            }

        }
    }
}
