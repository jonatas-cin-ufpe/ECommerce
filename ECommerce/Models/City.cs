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
        public int CityId { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        public String Name { get; set; }

        public int DepartmentsId { get; set; }
    }
}