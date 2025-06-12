namespace Blueweb.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string? description { get; set; }
        public Guid? profilepic { get; set; }
    }
}
