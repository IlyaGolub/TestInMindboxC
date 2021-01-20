﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeometricFigure.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> All();
        Task<T> Add(T entity);
        Task<T> Update(T prev, T current);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entitys);
        void AddRange(IEnumerable<T> entitys);
        Task SaveAsync();
       
    }
}