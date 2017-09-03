using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOfWebService
{
    class Program
    {

        /// <summary>
        /// 
        /// 4. I added a "web reference" to the project, the web reference is the URL of the web service, in this case: http://localhost:57125/MathService.asmx
        ///         Add a service reference, go to advanced, then "Add web reference", type or paste the URL, then Add Reference. 
        /// 5. Web reference name is simply the object name you give to the web service, as a shortcut, in this case: localhost1
        /// 6. Afterwards, you create a variable of the web service object, then you choose the class in that web service, and finally the method. 
        ///         In this case, the class is the WebService1, and the method is .Add within that class. There are three other classes
        ///         Subtract, Multiply, and Divide, you can change it up. 
        /// 7. Then display the results in console. 
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            localhost1.WebService1 myMathWebService = new localhost1.WebService1();
            //Change up the methods if wanted. 
            Console.Write("Add {0} & {1} = " + myMathWebService.Add(2, 4), 2, 4);
            Console.ReadLine();
        }

        //For this tutorial, checkout https://support.microsoft.com/en-us/help/308359/how-to-write-a-simple-web-service-by-using-visual-c--net
    }
}
