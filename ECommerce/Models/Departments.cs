using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Departments
    {
        [Key]
        [Display(Name = "Departamento")]
        public int DepartmentsId { get; set; }

        [Required(ErrorMessage="O campo Nome é obrigatório!")]
        [Display(Name = "Departamento")]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}