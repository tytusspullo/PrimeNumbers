using System;
using System.IO;
using System.Xml;

namespace PrimeNumbersCalculatorGP
{
    public class CycleConfiguration : ICycleConfiguration
    {
        private const string ConfigFilePath = "configuration.xml";
        private const string RootElement = "configuration";
        private const string NumberElement = "number";

        public int ReadDefaultCycle()
        {
            try
            {
                if (!File.Exists(ConfigFilePath))
                {
                    return 120;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(ConfigFilePath);

                XmlNode numberNode = xmlDoc.SelectSingleNode($"{RootElement}/{NumberElement}");
                if (numberNode != null)
                {
                    return int.Parse(numberNode.InnerText);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading number from {ConfigFilePath}: {ex.Message}");
                return 0; 
            }
        }

        public void SaveDefaultCycle(int number)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(ConfigFilePath))
            {
                xmlDoc.Load(ConfigFilePath);
            }
            else
            {
                XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = xmlDoc.CreateElement(RootElement);
                xmlDoc.AppendChild(xmlDeclaration);
                xmlDoc.AppendChild(root);
            }

            XmlElement numberElement = xmlDoc.SelectSingleNode($"{RootElement}/{NumberElement}") as XmlElement;
            if (numberElement == null)
            {
                numberElement = xmlDoc.CreateElement(NumberElement);
                xmlDoc.DocumentElement.AppendChild(numberElement);
            }

            numberElement.InnerText = number.ToString();

            xmlDoc.Save(ConfigFilePath);
        }
    }
}
