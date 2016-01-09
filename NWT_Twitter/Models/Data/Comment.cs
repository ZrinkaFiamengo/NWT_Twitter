using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Twitter.Models.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int TweetId { get; set; }
        public int UserId { get; set; }
    }
}