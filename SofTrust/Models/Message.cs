using System.ComponentModel.DataAnnotations.Schema;

namespace SofTrust.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public int DictionaryId { get; set; }
        public Dictionary Dictionary { get; set; }

        public string message { get; set; }
        public Message() { }
        public Message(Contact Contact, Dictionary Dictionary, string message)
        {
            this.Contact = Contact;
            this.Dictionary = Dictionary;
            this.message = message;
        }
    }
}
