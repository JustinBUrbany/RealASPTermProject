using ASPTermProject.Business_Objects;
using ASPTermProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Utilities
{
    public class Utils
    {

        public List<DogModel> ConvertToModel(List<Dog> dogs)
        {
            List<DogModel> model = new List<DogModel>();
            foreach(Dog d in dogs)
            {
                DogModel temp = new DogModel();
                temp.DogType = d.DogType;
                temp.Age = d.Age;
                temp.Name = d.Name;
                temp.Sex = d.Sex;
                temp.ImagePath = d.ImagePath;
                model.Add(temp);
            }
            return model;
        }
    }

}
