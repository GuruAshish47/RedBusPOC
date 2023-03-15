using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RedBusPOC;
using System.Threading;

namespace RedBusPoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //-----------------------------------------All Xpaths Group Class--------------------------------------------
              Xpaths.RedBusHomepage RBMP = new Xpaths.RedBusHomepage();
              Xpaths.OperatorDir OPD = new Xpaths.OperatorDir();
            //--------------------------------------Loading and initiChromedriver----------------------------------------
            //-----------------------------------AC1 Visithttps://www.redbus.in/----------------------------------------
            IWebDriver driver = new ChromeDriver();
            SeleniumDriverFunction D = new SeleniumDriverFunction(driver);//------SeleniumDriverFunction class
            string Parent = "https://www.redbus.in/";
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Parent);
            Thread.Sleep(800);
            //----------------------------------------------------------------------------------------------------------

            //--------------AC2 Scroll till the end of the page and click "All Operators"-------------------------------
            D.scroll("0,1800");
            Thread.Sleep(900);
            D.scroll("1800,2000");
            Thread.Sleep(900);
            D.clickelement(RBMP.AllOperators);
            Thread.Sleep(1000);
            //----------------------------------------------------------------------------------------------------------
            //---------------AC3 Click the operator directories with the alphabet I then R and then back to A-----------
            D.GoToTab(0);
            driver.Close();
            D.GoToTab(0);
            Thread.Sleep(1000);
            //D.Alph("i");
            D.clickelement(OPD.ALI);
            Thread.Sleep(1000);
            D.clickelement(OPD.ALR);
            Thread.Sleep(1000);
            D.clickelement(OPD.ALA);
            Thread.Sleep(1000);
            D.scroll("0,1800");
            Thread.Sleep(900);
            //----------------------------------------------------------------------------------------------------------
            //---------------Scroll till the end and click "3" from the pagination--------------------------------------
            D.scroll("1800,2000");
            Thread.Sleep(600);
            D.clickelement(OPD.PG3);
            Thread.Sleep(500);
            D.scroll("0,1800");
            Thread.Sleep(900);
            D.scroll("1800,100");
            //-----------------------------------------------------------------------------------------------------------
            //------------------------------Print all the operators listed in an output file.----------------------------
            D.FindandPrintFile();
            //-----------------------------------------------------------------------------------------------------------






        }
    }
}