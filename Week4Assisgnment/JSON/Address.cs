using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Week4Assisgnment.JSON
{
    class Address
    {
        [JsonPropertyName("streetAddress")]
        public string streetAddress;

        [JsonPropertyName("city")]
        public string City;

        [JsonPropertyName("state")]
        public string State;

        [JsonPropertyName("postalCode")]
        public string PostalCode;
    }
}
