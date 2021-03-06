﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiSerializer.JsonApi;

namespace JsonApiClient.Models
{
    public class Person
    {
        public string Type { get; set; } = "people"; //This was the problem line.
        public string Name { get; set; }
        public int? Id { get; set; }
        public Relationship<Parent> Parent { get; set; }
    }
}
