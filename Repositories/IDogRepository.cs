using ASPTermProject.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Repositories
{
    public interface IDogRepository
    {
        List<string> GetDogTypes();
        List<Dog> GetAllDogs();
        List<Dog> GetAllDogsByType(string type);
        List<Dog> GetAllDogsBySex(string dogType, string sex);
    }
}
