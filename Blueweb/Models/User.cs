namespace Blueweb.Models
{
    // Models/User.cs
    using System;
    using System.Collections.Generic;

    namespace Blueweb.Models
    {
        public class User
        {
            public int ID { get; set; }

            public string username { get; set; } = string.Empty;
            public string description { get; set; } = string.Empty;
            public string ProfileImagePath { get; set; } = "/images/propic.JPEG";
            public DateTime JoinDate { get; set; } = DateTime.UtcNow;

            // Navigation
            public ICollection<UserPost> Posts { get; set; } = new List<UserPost>();
        }
    }


}
