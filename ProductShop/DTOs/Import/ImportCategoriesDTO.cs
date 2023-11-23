using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("Category")]
    public class ImportCategoriessDTO
    {
        [XmlElement("name")]
        public string? Name { get; set; }

    }
}
