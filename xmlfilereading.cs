using System;
using System.Xml;

namespace ReadXMLfromFile
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
           // XmlTextReader reader = new XmlTextReader ("books2.xml");
XmlTextReader reader = new XmlTextReader ("29_11 _2016.xml");
            while (reader.Read()) 
            {
                switch (reader.NodeType) 
                {
                 
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
		if (reader.HasAttributes)     
		   {          
		  for (int i = 0; i < reader.AttributeCount; i++)   
		         {                reader.MoveToAttribute(i);      
			          Console.WriteLine("Attribute is {0} with Value {1}: ", reader.Name, reader.Value);   
		         }      
		  }
                        break;


                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine (reader.Value);
                        break;
                 
 	case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
