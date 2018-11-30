using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ASPTermProject.Business_Objects;
using Microsoft.Extensions.Options;

namespace ASPTermProject.Repositories
{
    public class DogRepository : IDogRepository
    {
        Settings _Settings;
        public  DogRepository(IOptions<Settings> settings)
        {
            _Settings = settings.Value;
        }
        public List<string> GetDogTypes()
        {
            throw new NotImplementedException();
        }
        public List<Dog> GetAllDogs()
        {
            List<Dog> doglist = new List<Dog>();
            using (SqlConnection connection = new SqlConnection(_Settings.ConnectionStrings["aspContextConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Dog_GetList", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Dog dog = new Dog();
                            dog.Name = reader["Name"].ToString();
                            dog.Age = (int) reader["Age"];
                            dog.DogType = reader["DogType"].ToString();
                            dog.Sex = reader["Sex"].ToString();
                            doglist.Add(dog);
                        }
                    }
                }
            }
            return doglist;
        }

        public List<Dog> GetAllDogsByType(string type)
        {
            List<Dog> doglist = new List<Dog>();
            using (SqlConnection connection = new SqlConnection(_Settings.ConnectionStrings["aspContextConnection"]))
            {
                using (SqlCommand command = new SqlCommand("DOG_GetListType", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Type", type);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dog dog = new Dog();
                            dog.Name = reader["Name"].ToString();
                            dog.Age = (int)reader["Age"];
                            dog.DogType = reader["DogType"].ToString();
                            dog.Sex = reader["Sex"].ToString();
                            dog.ImagePath = reader["ImagePath"].ToString();
                            doglist.Add(dog);
                        }
                    }
                }
            }
            return doglist;
        }

        public List<Dog> GetAllDogsBySex(string dogType, string sex)
        {
            List<Dog> doglist = new List<Dog>();
            using (SqlConnection connection = new SqlConnection(_Settings.ConnectionStrings["aspContextConnection"]))
            {
                using (SqlCommand command = new SqlCommand("Dog_GetListTypeSex", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Type", dogType);
                    command.Parameters.AddWithValue("@Sex", sex);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dog dog = new Dog();
                            dog.Name = reader["Name"].ToString();
                            dog.Age = (int)reader["Age"];
                            dog.DogType = reader["DogType"].ToString();
                            dog.Sex = reader["Sex"].ToString();
                            dog.ImagePath = reader["ImagePath"].ToString();
                            doglist.Add(dog);
                        }
                    }
                }
            }
            return doglist;
        }


    }
}
