using System;
using DeesMoneyScrap;
using OpenQA.Selenium;
using WebDataGathering.Context;

namespace WebDataGathering.Models
{
    public class DataScrape
    {
        private static readonly IWebDriver Driver = Drivers.Driver;
        private static IWebElement GetTable ()
        {
            // var chromeDriver = new ChromeDriver(options);

            var logMeIn = new Login("jayd9817", "ICG9817#");
            logMeIn.LogIn();

            //go to portfolio page
            Driver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_1/view/v1");
            
            //load table
            var mytable = Drivers.Wait.Until(d => d.FindElement(By.XPath("//table[@data-test='contentTable']/tbody")));
            return mytable;
        }

        public static void StartScraper()
        {
            //put login her too
            var newTable = GetTable();
            
            var pullTime = DateTime.Now;// scrape time;
            var rowCount = newTable.FindElements(By.XPath(".//tr")).Count;

            using (var db = new DataScrapeContext())
            {            //loop thru the table by row
                for (int i = 1; i <= rowCount; i++)
                {
                    var rowXpath = $"//tr[{i}]"; //"//tr[@data-index='0']";
                    var symb = Driver.FindElement(By.XPath(rowXpath + "/td[1]/span/a"))
                        .Text.ToString();
                    var lastP = Driver.FindElement(By.XPath(rowXpath + "/td[2]/span"))
                        .Text;
                    var changePerc = Driver.FindElement(By.XPath(rowXpath + "/td[4]/span")).Text;
                    var volume = Driver.FindElement(By.XPath(rowXpath + "/td[7]/span")).Text;
                    var volAvg = Driver.FindElement(By.XPath(rowXpath + "/td[9]")).Text;
                    Console.WriteLine($"{pullTime}\t{symb}\t{lastP}\t{changePerc}\t{volume}\t{volAvg}");
                    Console.WriteLine();

                    var anotherTable = new DataModel()
                    {
                        PullTime = pullTime,
                        Symbol = symb,
                        LastPrice = lastP,
                        ChangePerc = changePerc,
                        Volume = volume,
                        VolumeAvg = volAvg
                    };

                    db.DataModels.Add(anotherTable);
                    
                }
                db.SaveChanges();

                //Console.ReadLine();
            }

            Drivers.Driver.Close();
        }


        
    }
}