
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

public class MainClass {
    public static void Main() {
       XmlDocument doc = new XmlDocument();
        doc.Load("names.xml");
//selects top N nodes
        XmlNodeList xnList = doc.SelectNodes("/Names/Name[position() <= 5]");
foreach (XmlNode xn in xnList)
{
  Console.WriteLine(xn.InnerText);
}


    }

}
