using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Week4Assisgnment.XML
{
    [XmlRoot (ElementName = "item") ]
    class GroceryItem
    {
        [XmlElement (ElementName = "name")]
        public string name { get; set; }

        [XmlElement(ElementName = "price")]
        public string price { get; set; }

        [XmlElement(ElementName = "unit")]
        public string unit { get; set; }

    }
}
