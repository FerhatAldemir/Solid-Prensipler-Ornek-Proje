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
        T GetAll();
        T GetAll(Expression<Func<T, bool>> Filter);

        T Add(T Item);

        T Update(T Item);

        List<T> Update(List<T> Items);

        bool Remove(T Item);
        bool Remove(int Logicalref);
        bool Remove(List<T> Items);
        bool Remove(int[] LogicalRefs);
        bool Remove(Expression<Func<T, bool>> Filter);

    }
}
