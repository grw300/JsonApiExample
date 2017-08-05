using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonApiClient.Models
{
    public class Person 
    {
        public string Type { get; set; } = "people"; //This was the problem line.
        public string name { get; set; }
        public int? Id { get; set; }
    }
}
