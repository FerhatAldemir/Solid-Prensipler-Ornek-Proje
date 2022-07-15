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
        protected readonly Core.DataAccess.DataBaseContext _Context;
        
        public Repostory(Core.DataAccess.DataBaseContext context)
        {
            _Context = context;
            
        }

        public Tentity Add(Tentity Item)
        {
            _Context.Add(Item);
            return Item;
        }

        public bool Any(Expression<Func<Tentity, bool>> filter)
        {
            return _Context.Set<Tentity>().Any(filter);
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


                _Context.Update(Item);

            }
        }

      

        public void Remove(Expression<Func<Tentity, bool>> Filter)
        {
            _Context.RemoveRange(_Context.Set<Tentity>().Where(Filter));
        }

        public Tentity Update(Tentity Item)
        {

            _Context.Update(Item);
            return Item;
        }

        public List<Tentity> Update(List<Tentity> Items)
        {
            List<Tentity> ReturnsItem = new List<Tentity>();

            foreach (Tentity Item in Items)
            {

              
                ReturnsItem.Add(Item);

            }
            return ReturnsItem;
                 
        }
    }
}
