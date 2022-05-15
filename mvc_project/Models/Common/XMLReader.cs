using System;
using System.Xml;

namespace mvc_project.Models.Common
{
    public class XMLReader
    {
        private XmlDocument document;

        public XMLReader(string fileName)
        {
            document = new XmlDocument();
            document.Load(fileName);
        }

        public string ReadNode(string nodeName)
        {
            try
            {
                return document.SelectSingleNode("//" + nodeName).InnerText.Trim();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
