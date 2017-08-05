using JsonApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonApiClient.Services
{
    public interface IJsonApiService
    {
        Task<List<Person>> GetPeople();
        Task<Person> PostPersonAsync();
    }
}
