namespace CV.Models
{
    public class Language
    {
        public string LanguageName { get; set; }
        public string Level { get; set; }
        public Language() { }
        public Language(string language, string level)
        {
            LanguageName = language;
            Level = level;
        }
    }
}
