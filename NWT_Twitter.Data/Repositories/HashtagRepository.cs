using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT_Twitter.Data.Repositories
{
    class HashtagRepository
    {
        public void Create(Hashtag hashtag)
        {
            using (var context = new TwitterEntities())
            {
                context.Hashtags.Add(hashtag);
                context.SaveChanges();
            }
        }
    }
}
