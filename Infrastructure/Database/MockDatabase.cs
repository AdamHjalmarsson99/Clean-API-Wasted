using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List <Dog> allDogs
        {
            get { return allDogsFromMockDatabase;}
            set { allDogsFromMockDatabase = value;}
        }

        private static List<Dog> allDogsFromMockDatabase = new()
        {
            new Dog{Animalid = Guid.NewGuid(), Name = "Morris"},
            new Dog{Animalid = Guid.NewGuid(), Name = "Zonya"},
            new Dog{Animalid = Guid.NewGuid(), Name = "Buster"}
            
            /*new Dog
            {
                Animalid = Guid.NewGuid(), Name = "Morris"
            }*/
        };

    }
}
