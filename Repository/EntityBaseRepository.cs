﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly EcommerceContext _context;

        public EntityBaseRepository(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);

            EntityEntry entityEntry = _context.Entry<T>(entity);

            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IList<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);

            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
