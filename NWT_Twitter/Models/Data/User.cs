using System;
using System.Collections.Generic;

namespace NWT_Twitter.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Picture_URL { get; set; }

        //public Location Location      { get; set; }
        public IList<Tweet> Tweets    { get; set; }
    }
}