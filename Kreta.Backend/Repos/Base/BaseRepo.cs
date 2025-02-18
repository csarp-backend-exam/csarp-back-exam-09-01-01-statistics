﻿using Kreta.Shared.Models.Entites;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kreta.Backend.Repos.Base
{
    public abstract class BaseRepo<TDbContext, TEntity> : IBaseRepo<TEntity>
        where TDbContext : DbContext
        where TEntity : class, IDbEntity<TEntity>, new()
    {
        private readonly DbContext? _dbContext;
        private readonly DbSet<TEntity>? _dbSet;

        public BaseRepo(TDbContext? dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext?.Set<TEntity>() ?? throw new ArgumentException($"A {nameof(TEntity)} adatbázis tábla nem elérhető!");
        }
        public IQueryable<TEntity> GetEmpty()
        {
            return _dbSet?.Take(0) ?? throw new ArgumentException($"A {nameof(TEntity)} adatbázis tábla nem elérhető!");
        }
        public IQueryable<TEntity> FindAll()
        {
            if (_dbSet is null)
            {
                return Enumerable.Empty<TEntity>().AsQueryable().AsNoTracking();
            }
            return _dbSet.AsNoTracking();
        }
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            if (_dbSet is null)
            {
                return Enumerable.Empty<TEntity>().AsQueryable().AsNoTracking();
            }
            return _dbSet.Where(expression).AsNoTracking();
        }
        public async Task<Response> UpdateAsync(TEntity entity)
        {
            Response response = new();
            try
            {
                if (_dbContext is not null)
                {
                    _dbContext.ChangeTracker.Clear();
                    _dbContext.Entry(entity).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    response.Id = entity.Id;
                    return response;
                }
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(UpdateAsync)} metódusban hiba keletkezett");
            response.AppendNewError($"{entity} frissítése nem sikerült!");
            return response;
        }
        public async Task<Response> DeleteAsync(Guid id)
        {
            Response response = new();

            TEntity? entityToDelete = FindByCondition(e => e.Id == id).FirstOrDefault();

            if (entityToDelete is null || entityToDelete is not null && !entityToDelete.HasId)
            {
                if (entityToDelete is not null)
                    response.AppendNewError($"{entityToDelete.Id} idével rendelkező entitás nem található!");
                response.AppendNewError("Az entitás törlése nem sikerült!");
            }
            else
            {
                try
                {
                    if (entityToDelete is not null && _dbContext is not null)
                    {
                        _dbContext.ChangeTracker.Clear();
                        _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
                        await _dbContext.SaveChangesAsync();
                        response.Id = entityToDelete.Id;
                        return response;
                    }
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                }
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(DeleteAsync)} metódusban hiba keletkezett");
            if (entityToDelete is not null)
                response.AppendNewError($"Az entitás id:{entityToDelete.Id}");
            response.AppendNewError($"Az entitás törlése nem sikerült!");
            return response;
        }
        public async Task<Response> CreateAsync(TEntity entity)
        {
            Response response = new();
            if (_dbSet is null)
            {
                response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
            }
            else
            {
                try
                {
                    if (_dbContext is not null)
                    {
                        _dbSet.Add(entity);
                        await _dbContext.SaveChangesAsync();
                        response.Id = entity.Id;
                        return response;
                    }
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                }
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(CreateAsync)} metódusban hiba keletkezett");
            response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
            return response;
        }


    }
}
