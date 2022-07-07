using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.Core.Concrete
{
    public class Repostory<Tentity>: UnitWork, RepoStory.IEntityRepoStory<Tentity> where Tentity : class, Core.Entities.Ientites
    {
        private readonly DbContext _Context;
        
        public Repostory(DbContext context):base(context)
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
            throw new NotImplementedException();
        }

        public Tentity GetAll()
        {
            throw new NotImplementedException();
        }

        public Tentity GetAll(Expression<Func<Tentity, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Tentity Item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int Logicalref)
        {
            throw new NotImplementedException();
        }

        public bool Remove(List<Tentity> Items)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int[] LogicalRefs)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Expression<Func<Tentity, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public Tentity Update(Tentity Item)
        {
            throw new NotImplementedException();
        }

        public List<Tentity> Update(List<Tentity> Items)
        {
            throw new NotImplementedException();
        }
    }
}
