using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Example.Core.Entities;

namespace Example.Core.RepoStory
{
    public interface IEntityRepoStory<T> where T : class, Ientites
    {
        T Get(Expression<Func<T, bool>> Filter);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> Filter);

        T Add(T Item);

        T Update(T Item);

        bool Any(Expression<Func<T,bool>> filter);
        List<T> Update(List<T> Items);

        void Remove(T Item);
     
        void Remove(List<T> Items);
       
        void Remove(Expression<Func<T, bool>> Filter);

    }
}
