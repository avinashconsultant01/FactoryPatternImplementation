using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class Contact
    {
        public int Id { get; set; }
        [JsonProperty("First_Name")]
        public string FirstName { get; set; }
        [JsonProperty("Last_Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        [JsonProperty("Street_Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [JsonProperty("Zip_Code")]
        public string ZipCode { get; set; }
        [JsonProperty("Phone_Number")]
        public string PhoneNumber { get; set; }


    }
}
