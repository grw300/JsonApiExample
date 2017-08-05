using JsonApi.Models;
using JsonApiDotNetCore.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace JsonApi.Controllers
{
    public class PeopleController : JsonApiController<Person>
    {
        public PeopleController(
            IJsonApiContext jsonApiContext,
            IResourceService<Person> resourceService,
            ILoggerFactory loggerFactory)
            : base (jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
