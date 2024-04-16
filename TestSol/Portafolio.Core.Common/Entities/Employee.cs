using System.ComponentModel.DataAnnotations;

namespace Portafolio.Core.Common.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstSurname { get; set; }

        public string SecondSurname { get; set; }

        public string Area { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        public double Salary { get; set; }
    }
}
