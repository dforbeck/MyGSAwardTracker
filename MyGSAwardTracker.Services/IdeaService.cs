﻿using MyGSAwardTracker.Data;
using MyGSAwardTracker.Models.Idea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGSAwardTracker.Services
{
    public class IdeaService
    {
        private readonly Guid _userId;

        public IdeaService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateIdea(IdeaCreate model)
        {
            var entity =
                new Idea()
                {
                    OwnerId = _userId,
                    IdeaId = model.IdeaId,
                    IdeaTitle = model.IdeaTitle,
                    IdeaDescription = model.IdeaDescription,
                    DateIdeaCreated = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ideas.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<IdeaListItem> GetIdeas()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Ideas
                        .Where(e => e.OwnerId == _userId)
                        .Select(e => new IdeaListItem
                            {                              
                                IdeaTitle = e.IdeaTitle,
                                IdeaDescription = e.IdeaDescription,
                                DateIdeaCreated = e.DateIdeaCreated,
                                DateIdeaModified = e.DateIdeaModified
                            }
                        );
                return query.ToArray();
            }
        }

    }
}