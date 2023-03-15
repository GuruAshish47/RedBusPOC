using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBusPOC
{
    public class Xpaths
    {   
        //--------------------------------------------------RedbusHomepage---------------------------------------------------------------
        public class RedBusHomepage
        {
            public String AllOperators = "//footer[@id='rh_footer']//div[@class = 'more-link']//a[@href='/travels/operators-directory']"; 
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------OperatorDirPage--------------------------------------------------------------
        public class OperatorDir
        {
            public String ALA = "//div[@id='root']//a[@href='/travels/operators-directory/a']";                         
            public String ALI = "//div[@id='root']//a[@href='/travels/operators-directory/i']";
            public String ALR = "//div[@id='root']//a[@href='/travels/operators-directory/r']";
            public String PG3 = "(//div[@class='D113_pagination']//a[@class='D113_button '])[2]";

        }    
        
    }
}
