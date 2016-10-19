using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FirstServises
{
    /// <summary>
    /// Summary description for Webf
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Webf : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string Math(String num1, String num2, String op)
        {
            //int ret=0;
            //switch (op)
            //{
            //    case "+": ret = num1 + num1; break;
            //    case "-": ret = num1 - num1; break;
            //    case "/": ret = num1 / num1; break;
            //    case "*": ret = num1 * num1; break;
            //}
            return "10";
        }
    }
}
