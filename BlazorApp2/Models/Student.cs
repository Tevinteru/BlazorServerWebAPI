using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string Group { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public double AverageScore { get; set; }
        public int Scholarship { get; set; }
    }
}
