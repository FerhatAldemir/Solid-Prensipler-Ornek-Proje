using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Example.Core.Entities;

namespace Example.Core.RepoStory
{
    public interface IEntityRepoStory<T>:Core.UnitOfWork.IUnitOfWork where T : class, Ientites
    {
        T Get(Expression<Func<T, bool>> Filter);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> Filter);

        T Add(T Item);

        T Update(T Item);

        List<T> Update(List<T> Items);

        void Remove(T Item);
     
        void Remove(List<T> Items);
       
        void Remove(Expression<Func<T, bool>> Filter);

    }
}
