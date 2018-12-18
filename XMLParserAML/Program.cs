// Keith Russell

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace XMLParserABM
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            // load the document - to note the xml document was missing a declaration end tag
            doc.Load(@"C:\users\keith\desktop\inputdocument.xml");

            //XmlElement root = doc.DocumentElement;
            // define the values that will pick out the XML values
            XmlNodeList xnListMWB = doc.SelectNodes("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='MWB']");
            XmlNodeList xnListTRV = doc.SelectNodes("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='TRV']");
            XmlNodeList xnListCAR = doc.SelectNodes("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='CAR']");

            //MWB selectors in XML file 

            foreach (XmlNode xnMWB in xnListMWB)
            {
                Console.WriteLine("MWV: " + xnMWB.InnerText);
            }
            //TRV selectors in XML file
            foreach (XmlNode xnTRV in xnListTRV)
            {
                Console.WriteLine("TRV: " + xnTRV.InnerText);
            }
            // CAR selectors in XML file
            foreach (XmlNode xnCAR in xnListCAR)
            {
                Console.WriteLine("CAR: " + xnCAR.InnerText);
            }
            //halt the screen to stop the console closing automatically
            Console.Write("Press any key to continue");
            Console.ReadLine();
            

            

        }
    }
}
