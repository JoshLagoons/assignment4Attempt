using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Week4Assisgnment.JSON
{
    class Student
    {
        [JsonPropertyName("firstName")]
        public string FirstName;

        [JsonPropertyName("lastName")]
        public string LastName;

        [JsonPropertyName("isEnrolled")]
        public string IsEnrolled;

        [JsonPropertyName("yearsEnrolled")]
        public string YearsEnrolled;

        [JsonPropertyName("address1")]
        public string Address1;

        [JsonPropertyName("address2")]
        public string Address2;

        [JsonPropertyName("phoneNumbers")]
        public string PhoneNumbers;

    }
}
