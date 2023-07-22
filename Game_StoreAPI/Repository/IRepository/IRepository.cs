﻿using System.Linq.Expressions;

namespace Game_StoreAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(string? includeproperties = null);
        T Get(Expression<Func<T, bool>>? filter = null,bool tracked=true, string? includeproperties = null);
        void Create(T entity);
        void Remove(T entity);
        void Save();
    }
}
