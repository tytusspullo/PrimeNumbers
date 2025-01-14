using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PrimeNumbersCalculatorGP
{
    public class XMLResultSaver
    {
        private CalculationResult _calculationResult = null;
        private string _fileNameWithPath = string.Empty;

        public XMLResultSaver(CalculationResult calculationResult, string fileNameWithPath)
        {
            _calculationResult = calculationResult;
            _fileNameWithPath = fileNameWithPath;
        }
        
        public void WriteToXML()
        {
            if (!File.Exists(_fileNameWithPath))
            {
                CreateNewXmlFile(_calculationResult, _fileNameWithPath);
            }
            else
            {
                AppendToExistingXml(_calculationResult, _fileNameWithPath);
            }
        }

        private void CreateNewXmlFile(CalculationResult result, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CalculationResult));
            XDocument doc = new XDocument(new XElement("CalculationResults"));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, result);
                XElement newElement = XElement.Parse(writer.ToString());
                doc.Root.Add(newElement);
            }
            doc.Save(filePath);
        }
        private void AppendToExistingXml(CalculationResult result, string filePath)
        {
            XDocument doc = XDocument.Load(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(CalculationResult));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, result);
                XElement newElement = XElement.Parse(writer.ToString());
                doc.Root.Add(newElement);
            }
            doc.Save(filePath);
        }

    }
}
