using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PrimeNumbersCalculatorGP
{
    public class XMLResultRetriver
    {
        private CalculationResult _calculationResult = null;
        private string _fileNameWithPath = string.Empty;

        public XMLResultRetriver(string fileNameWithPath)
        {
            _fileNameWithPath = fileNameWithPath;
        }

        public CalculationResult ReadFromXML()
        {
            _calculationResult = ReadLastFromXmlFile(_fileNameWithPath);
            return _calculationResult;
        }
        private CalculationResult ReadLastFromXmlFile(string fileNameWithPath)
        {
            if (!File.Exists(fileNameWithPath))
            {
                return null;
            }

            XDocument doc = XDocument.Load(fileNameWithPath);
            XElement lastElement = doc.Root.Elements("CalculationResult").LastOrDefault();
            if (lastElement == null)
            {
                return null;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(CalculationResult));
            using (StringReader reader = new StringReader(lastElement.ToString()))
            {
                return (CalculationResult)serializer.Deserialize(reader);
            }
        }
    }
}
