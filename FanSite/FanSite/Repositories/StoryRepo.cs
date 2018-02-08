﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repositories
{
    public class StoryRepo : IStoryRepo
    {
        static List<StoryModel> storys = new List<StoryModel>();
        /*public StoryRepo()
        {
            StoryModel story = new StoryModel { Title = "Me and She", Date = DateTime.Parse("01/18/2018") , Story = "We did a thing" };
            storys.Add(story);

            story = new StoryModel { Title = "Time to Shine", Date = DateTime.Parse("01/28/2018"), Story = "Casted Lumos" };
            storys.Add(story);

            story = new StoryModel { Title = "Quitage", Date = DateTime.Parse("01/04/2018"), Story = "We have the snich" };
            storys.Add(story);

        }*/
        public List<StoryModel> GetAllStorys()
        {
            
            return storys;
        }
        public void Add(StoryModel s)
        {
            storys.Add(s);
        }
    }
}