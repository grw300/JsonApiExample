using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonApiClient.Models
{
    public class Parent
    {
        public string Type { get; set; } = "parents"; //This was the problem line.
        public string Name { get; set; }
        public int? Id { get; set; }
    }
}
