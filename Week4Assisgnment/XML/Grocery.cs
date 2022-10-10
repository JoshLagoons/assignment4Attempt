using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Week4Assisgnment.XML
{
    [XmlRoot (ElementName = "menu") ]
    class Grocery
    {
        [XmlElement(ElementName ="item") ]

        public List<GroceryItem> item { get; set; }

    }
}
