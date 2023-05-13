namespace CV.Models
{
    public class Info
    {
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string GitHub { get; set; }
        public Info() { }
        public Info(string position, string phoneNumber, string email, string github)
        {
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            GitHub = github;
        }
    }
}
