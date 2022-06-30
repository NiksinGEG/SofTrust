
namespace SofTrust.Models

{
  public class User
  {
        public int Id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public int selectedTheme { get; set; }
        public string message { get; set; }
        public User() { }

        public User(string name, string mail, string phoneNumber, string message)
        {
          this.name = name;
          this.mail = mail;
          this.phoneNumber = phoneNumber;
          this.message = message;
        }
  }
}
