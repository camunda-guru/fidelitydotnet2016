using System.Xml; 
using System;
class xmlfile
{
public static void Main()
{


XmlDocument xmldoc = new XmlDocument();
XmlNode xmlRoot, xmlNode;
xmlRoot = xmldoc.CreateElement("Employee");

xmldoc.AppendChild(xmlRoot);
xmlNode = xmldoc.CreateElement("sapid");
xmlRoot.AppendChild(xmlNode);
Console.WriteLine("Enter SapId");
xmlNode.InnerText = Console.ReadLine();
 // you can also take a textbox instead of the text like this;
 // xmlNode.InnerText = TextBox1.Text;

xmlNode = xmldoc.CreateElement("Name");
xmlRoot.AppendChild(xmlNode);
Console.WriteLine("Enter Name");
xmlNode.InnerText = Console.ReadLine();


xmlNode = xmldoc.CreateElement("Designation");
xmlRoot.AppendChild(xmlNode);
Console.WriteLine("Enter Designation");
xmlNode.InnerText = Console.ReadLine();
XmlAttribute desigAttribute = xmldoc.CreateAttribute("id");
    desigAttribute.Value = "1001";
  xmlNode.Attributes.Append(desigAttribute);
        
 // you can make as many childs as you want 
string filename =  DateTime.Now.Day +"_"+ DateTime.Now.Month +" _"+ DateTime.Now.Year + ".xml";
//Console.WriteLine(DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + ".xml");
 // i wanted the date as the filename, so i can see when it was created
 // of course you can change it to: 
 // string filename = @"c:\NewXML" + ".xml" or @"c:\whatever" + ".xml"

xmldoc.Save(filename);

}
}