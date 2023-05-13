namespace CV.Models
{
    public class Experiance
    {
        public string Name { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Experiance() { }
        public Experiance(string name, string place, string location, string description, DateTime? from, DateTime? to)
        {
            Name = name;
            From = from;
            To = to;
            Place = place;
            Location = location;
            Description = description;
        }
    }
}
