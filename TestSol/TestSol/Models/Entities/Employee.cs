using System.ComponentModel.DataAnnotations;

namespace TestSol.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Nombre del empleado.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Apellido Paterno del empleado")]
        public string FirstSurname { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Apellido Materno del empleado")]
        public string SecondSurname { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Area del empleado")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la Fecha de Nacimiento del empleado")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        [RegularExpression("([1-9.][0-9.]*)", ErrorMessage = "El campo salario solo se aceptan numeros")]
        [Required(ErrorMessage = "Por favor ingrese el Salario del empleado")]
        public double Salary { get; set; }
    }
}
