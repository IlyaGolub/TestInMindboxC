﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace GeometricFigure.Infrastructure
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly GeometricFigureContext context;

        public EfRepository(GeometricFigureContext context)
        {
            this.context = context;
        }

        public DbSet<T> All()
        {
            return context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            context.Set<T>().Add(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<T> Update(T prev, T current)
        {
            context.Entry<T>(prev).CurrentValues.SetValues(current);
            await SaveAsync();

            return current;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entitys)
        {
            context.Set<T>().RemoveRange(entitys);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<T> entitys)
        {
            context.Set<T>().AddRange(entitys);       
        }        
    }
}
