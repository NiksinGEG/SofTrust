
namespace SofTrust.Models

{
  public class User
  {
        public int Id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public int selectedTheme { get; set; }
        public User() { }

        public User(string name, string mail, string phoneNumber)
        {
          this.name = name;
          this.mail = mail;
          this.phoneNumber = phoneNumber;
        }
  }
}
