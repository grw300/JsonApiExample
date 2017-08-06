using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonApi.Models
{
    public class Person : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        public int ParentId { get; set; }

        [HasOne("parent")]
        public virtual Parent Parent { get; set; }
    }
}
