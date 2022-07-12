using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Example.Core.Entities;

namespace Example.Core.Concrete
{
    public class Repostory<Tentity>: RepoStory.IEntityRepoStory<Tentity> where Tentity : class, Ientites
    {
        protected readonly DbContext _Context;
        
        public Repostory(DbContext context)
        {
            _Context = context;
            
        }

        public Tentity Add(Tentity Item)
        {
            _Context.Set<Tentity>().Add(Item);
            return Item;
        }

        public Tentity Get(Expression<Func<Tentity, bool>> Filter)
        {
           

            return _Context.Set<Tentity>().FirstOrDefault(Filter);
        }

        public List<Tentity> GetAll()
        {
            return _Context.Set<Tentity>().ToList();

        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> Filter)
        {
            return _Context.Set<Tentity>().Where(Filter).ToList();
        }

        public void Remove(Tentity Item)
        {
             _Context.Remove(Item);
        }

     

        public void Remove(List<Tentity> Items)
        {
            foreach (Tentity Item in Items)
            {

                var Entry = _Context.Entry(Item);
                Entry.State = EntityState.Deleted;
               

            }
        }

      

        public void Remove(Expression<Func<Tentity, bool>> Filter)
        {
            _Context.Set<Tentity>().RemoveRange(_Context.Set<Tentity>().Where(Filter));
        }

        public Tentity Update(Tentity Item)
        {
            var Entry = _Context.Entry(Item);
            Entry.State = EntityState.Modified;
            return Item;
        }

        public List<Tentity> Update(List<Tentity> Items)
        {
            List<Tentity> ReturnsItem = new List<Tentity>();

            foreach (Tentity Item in Items)
            {

                var Entry = _Context.Entry(Item);
                Entry.State = EntityState.Modified;
                ReturnsItem.Add(Item);

            }
            return ReturnsItem;
                 
        }
    }
}
