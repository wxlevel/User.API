﻿namespace Contact.API.Data
{
    /// <summary>
    /// 好友
    /// </summary>
    public class Contact
    {
        public Contact()
        {
            Tags = new string[] { };
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }

        public string[] Tags { get; set; }
    }
}