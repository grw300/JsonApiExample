using System;
using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace JsonApi.Models
{
    public class Parent : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [HasMany("people")]
        public IEnumerable<Person> People { get; set; }
    }
}
