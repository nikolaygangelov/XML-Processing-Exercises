﻿using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("Product")]
    public class ExportSoldProductsNestedDTO
    {
        //public ExportSoldProductsDTO()
        //{
        //    this.ProductsSold = new List<Product>();
        //}

        [XmlElement("name")]
        public string Name { get; set; } = null!;

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}