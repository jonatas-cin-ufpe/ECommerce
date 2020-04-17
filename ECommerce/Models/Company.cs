using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Companhia")]
        public int CompanyId { get; set; }

        [MaxLength(50, ErrorMessage = "Campo nome só pode ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [Display(Name = "Companhia")]
        //[Index("Company_Name_Index", IsUnique = true)]
        public String Name { get; set; }

        [MaxLength(50, ErrorMessage = "Campo telefone só pode ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "O campo telefone é obrigatório!")]
        [Display(Name = "Telefone")]
        //[Index("Company_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [MaxLength(100, ErrorMessage = "Campo endereço só pode ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "O campo endereço é obrigatório!")]
        [Display(Name = "Endereço")]
        public String Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public String Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { set; get; }

        [Required(ErrorMessage = "O campo cidade é obrigatório!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo Departamento é obrigatório!")]
        [Display(Name = "Departamento")]
        public int DepartmentsId { get; set; }

        [Display(Name = "Cidade")]
        public virtual City Cities { get; set; }

        [Display(Name = "Departamento")]
        public virtual Departments Departments { get; set; }

    }
}