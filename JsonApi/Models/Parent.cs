using System;
using JsonApiDotNetCore.Models;

namespace JsonApi.Models
{
    public class Parent : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }
    }
}
