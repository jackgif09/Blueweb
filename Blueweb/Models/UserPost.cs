namespace Blueweb.Models
{
    using System;

    namespace Blueweb.Models
    {
        public class UserPost
        {
            public int ID { get; set; }

            public string Title { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

            // Foreign Key
            public int UserID { get; set; }

            // Navigation
            public User User { get; set; } = default!;
        }
    }

}
