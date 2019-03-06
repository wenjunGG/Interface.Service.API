using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service.IServices.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Save(Guid? id, T entity);
        void Delete(Guid id);
        void Delete(T item);
        void Remove(T item);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(Guid id);
        IQueryable<T> GetAllEnt();
        IQueryable<T> GetAllEnt(bool deleted);
        IQueryable<T> GetAllEnts();
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(bool deleted);
        IQueryable<T> GetAll(Expression<Func<T, bool>> where);
        IQueryable<T> GetAllWithProject();
        IQueryable<T> GetAllWithProject(bool deleted);
        IQueryable<T> GetAllWithProject(Expression<Func<T, bool>> where);
        bool HasItem(string fieldname, string value, Guid? Id, bool withinProject = true, bool deleted = false);
        int Commit();
        Task<int> CommitAsync();

        IQueryable<T> GetAll_All();
    }
}
