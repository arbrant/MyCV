namespace CV.Models
{
    public class CV_Info
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public string Summary { get; set; }
        public Info Info { get; set; }
        public List<string> Skills { get; set; }
        public List<Experiance> Experiances { get; set; }
        public List<Education> Educations { get; set; }
        public List<Language> Languages { get; set; }
    }
}
