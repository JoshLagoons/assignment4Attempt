using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Week4Assisgnment.JSON
{
    internal class Phone
    {
        [JsonPropertyName ("type")]
        public string Type;

        [JsonPropertyName("number")]
        public string Number;

        [JsonPropertyName("CanContact")]
        public string CanContact;
    }
}
