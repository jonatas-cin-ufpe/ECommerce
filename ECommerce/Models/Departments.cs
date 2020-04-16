using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Departments
    {
        [Key]
        [Display(Name = "Departamento")]
        public int DepartmentsId { get; set; }

        [MaxLength(50,ErrorMessage ="Campo nome só pode ter no máximo 50 caracteres")]
        [Required(ErrorMessage="O campo Nome é obrigatório!")]
        [Display(Name = "Departamento")]
        [Index("Department_Name_Index", IsUnique = true)]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}