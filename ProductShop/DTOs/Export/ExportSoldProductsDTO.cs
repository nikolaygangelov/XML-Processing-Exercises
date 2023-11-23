using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("User")]
    public class ExportSoldProductsDTO
    {

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        //[XmlElement("soldProducts")]
        [XmlArray("soldProducts")]
        public ExportSoldProductsNestedDTO [] ProductsSold { get; set; }
    }
}
