using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ruta del archivo XML
            string filePath = "archivo.xml";

            // Crear un objeto XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                // Cargar el archivo XML
                xmlDoc.Load(filePath);

                // Obtener la raíz del documento
                XmlNode rootNode = xmlDoc.DocumentElement;

                // Recorrer los nodos hijos
                foreach (XmlNode node in rootNode.ChildNodes)
                {
                    // Ejemplo: Obtener el valor de un elemento específico
                    string valor = node["Elemento"].InnerText;
                    Console.WriteLine("Valor del elemento: " + valor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar el archivo XML: " + ex.Message);
            }

            Console.ReadLine();

        }
    }
}
