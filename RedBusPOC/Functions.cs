using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Threading;

namespace RedBusPOC
{
    public class SeleniumDriverFunction
    {
        public IWebDriver driver;

        public SeleniumDriverFunction(IWebDriver driver)
        {
            this.driver = driver;

        }
        //-----------------------------------------------------------------------------------------------
        public void scroll(String coordinates)
        {

            IJavaScriptExecutor scrd = (IJavaScriptExecutor)(this.driver);  //------Scroll function
            scrd.ExecuteScript("window.scrollBy(" + coordinates + ");");
            Thread.Sleep(2000);
        }
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public void clickelement(string Xpath)//String Xpath)
        {

            driver.FindElement(By.XPath(Xpath)).Click();  //find and click function

        }
        //-----------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void GoToTab(int Tab)
        {
            driver.SwitchTo().Window(driver.WindowHandles[Tab]);//Goto tab with given index


        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        public void FindandPrintFile()   /////All xpaths contain all the Xpaths of operator names 
        {

            IList<IWebElement> AllXpath = driver.FindElements(By.XPath("//div[@class='D113_links_main']//ul[@class='D113_ul']//li"));

                     String[] OptNams = new String[AllXpath.Count];
                     int i = 0;

            foreach (IWebElement element in AllXpath)
            {

                OptNams[i++] = element.Text;
                Console.WriteLine(element.Text);
                
                FileStream fs = new FileStream(@"C:\Users\al3203\source\repos\RedBusPOC\RedBusPOC\OperatorNames.txt", FileMode.Append,FileAccess.Write);
                StreamWriter s = new StreamWriter(fs);
                s.WriteLine(element.Text);
                s.Close();
                fs.Close();
            }
        }

    }
}
