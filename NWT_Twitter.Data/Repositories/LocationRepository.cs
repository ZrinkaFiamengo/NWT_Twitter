﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT_Twitter.Data.Repositories
{
    class LocationRepository
    {
        public void Create(Location location)
        {
            using (var context = new TwitterEntities())
            {
                context.Locations.Add(location);
                context.SaveChanges();
            }
        }

        public Location Get(int id)
        {
            using (var context = new TwitterEntities())
            {
                return context.Locations.SingleOrDefault(x => x.ID == id);
            }
        }

        public IList<Location> GetAll()
        {
            using (var context = new TwitterEntities())
            {
                return context.Locations.ToList();
            }
        }
    }
}
