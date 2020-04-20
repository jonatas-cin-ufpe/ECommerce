using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();

        public static List<Departments> GetDepartments()
        {
            var dep = db.Departments.ToList();

            dep.Add(new Departments
            {
                DepartmentsId = 0,
                Name = "[Selecione um Departamento]"

            });

            return dep = dep.OrderBy(d => d.Name).ToList();

        }

        public static List<City>GetCities()
        {
            var dep = db.Cities.ToList();
              
            dep.Add(new City
            {
                DepartmentsId = 0,
                Name = "[Selecione uma Cidade]"

            });

            return dep = dep.OrderBy(d => d.Name).ToList();

        }


        public void Dispose()
        {
            db.Dispose();
        }


    }



}



