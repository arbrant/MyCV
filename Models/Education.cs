using System.Data;

namespace CV.Models
{
    public class Education
    {
        public string Field { get; set; }
        public string Degree { get; set; }
        public string EducationalInstitution { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public Education() { }
        public Education(string field, string degree, string educationalInstitution, DateTime? from, DateTime? to)
        {
            Field = field;
            Degree = degree;
            EducationalInstitution = educationalInstitution;
            From = from;
            To = to;
        }
    }
}
