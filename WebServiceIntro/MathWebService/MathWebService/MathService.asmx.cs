using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]


        ///1. I created a completely empty Active Server Page .NET (ASP.NET) application. 
        ///2. I then created a new item within this project, thus I created a web service, hence this form you're currently viewing. 
        ///3. Every Method (The ones you see below) that the developer wants to be used as a web service must be denoted with a [WebMethod] tag before
        ///     the method. Otherwise the method will not be able to be used or viewed when page is running. 
        ///     For example, if we take away the WebMethod tag from the System.Single Subtract method, that method will not be able to be used nor
        ///     will it be able to be viewed when the page is running. 
        ///After all of this, I created a client code application which consumes the web service in a console command window. 

    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int a, int b)
        {
            return (a+b);
        }

        [WebMethod]
        public System.Single Substract(System.Single A, System.Single B)
        {
            return (A - B);
        }

        [WebMethod]
        public System.Single Multiply(System.Single A, System.Single B)
        {
            return (A * B);
        }

        [WebMethod]
        public System.Single Divide(System.Single A, System.Single B)
        {
            if (B == 0)
                return 0;
            return Convert.ToSingle(A / B);
        }

        //For this tutorial, checkout: https://support.microsoft.com/en-us/help/308359/how-to-write-a-simple-web-service-by-using-visual-c--net
    }
}
