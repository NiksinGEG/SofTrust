namespace SofTrust.Models
{
    public class Dictionary
    {
        public int Id { get; set; }
        public string theme { get; set; }
        public Dictionary() { }

        public Dictionary(string theme)
        {
            this.theme = theme;
        }
    }
}
