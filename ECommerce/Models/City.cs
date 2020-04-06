using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {   
        [Key]
        [Display(Name = "Id da Cidade")]
        public int CityId { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [Display(Name = "Cidade")]
        public String Name { get; set; }

        [Display(Name = "Departamento")]
        [Range(1, double.MaxValue, ErrorMessage="Selecione um Departamento")]
        public int DepartmentsId { get; set; }
        
        
        [Display(Name = "Departamento")]
        public Departments Department { get; set; }
    }
}