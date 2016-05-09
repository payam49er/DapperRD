using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public interface IRepository<T> where T :class,IEntity
    {
        Task AddRedirect(T entity);
        Task RemoveRedirect(T entity);
        Task UpdateRedirect(T entity);
        Task AddArchivedRedirect(T entity); // this is unnecessary, as in the repository we can define what table to insert into. 
        Task<ReWrite> GetRedirect(string incomingUrl);
        Task<IEnumerable<ReWrite>> FindbByUserId(string userName);
        Task<T> FindByUrl(string url);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllRedirects();
    }
}
