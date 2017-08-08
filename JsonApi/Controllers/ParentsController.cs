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
    public class ParentsController : JsonApiController<Parent>
    {
        public ParentsController(
            IJsonApiContext jsonApiContext,
            IResourceService<Parent> resourceService,
            ILoggerFactory loggerFactory)
            : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
