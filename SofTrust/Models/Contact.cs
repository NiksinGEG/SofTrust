namespace SofTrust.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public Contact() { }
        public Contact(string name, string email, string phoneNumber)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
