﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace GeometricFigure.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> All();
        T Add(T entity);
        T Update(T prev, T current);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entitys);
        void AddRange(IEnumerable<T> entitys);
       
    }
}