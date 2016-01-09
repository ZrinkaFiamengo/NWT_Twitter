using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT_Twitter.Data.Repositories
{
    class CommentRepository
    {
        //dohvaća komentare za t
        public void Create(Comment comment)
        {
            using (var context = new TwitterEntities())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
    }
}
