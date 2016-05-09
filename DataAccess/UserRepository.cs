using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;
using DataAccess.Models;

namespace DataAccess
{
    public class UserRepository : BaseRepository, IRepository<ReWrite>
    {
        public UserRepository(string connectionName) : base(connectionName)
        {
        }

        public async Task AddRedirect(ReWrite entity)
        {
            await WithConnection<ReWrite>(async x =>
            {
                var p = new DynamicParameters();
                p.Add("AddEntity",entity, DbType.String);
                await x.QueryAsync<ReWrite>
                    (
                        sql: "",
                        param: p,
                        commandType: CommandType.StoredProcedure
                    );
            });
         }

        public async Task RemoveRedirect(ReWrite entity)
        {
            await WithConnection<ReWrite>(async x =>
            {
                var p = new DynamicParameters();
                p.Add("RemoveEntity", entity, DbType.String);
                await x.QueryAsync<ReWrite>
                    (
                        sql: "",
                        param: p,
                        commandType: CommandType.StoredProcedure
                    );
            });
        }

        public async Task UpdateRedirect(ReWrite entity)
        {
            await WithConnection<ReWrite>(async x =>
            {
                var p = new DynamicParameters();
                p.Add("UpdateEntity", entity, DbType.String);
                await x.QueryAsync<ReWrite>
                    (
                        sql: "",
                        param: p,
                        commandType: CommandType.StoredProcedure
                    );
            });
        }

        public Task AddArchivedRedirect(ReWrite entity)
        {
            return null;
        }

        public Task<ReWrite> GetRedirect(string incomingUrl)
        {
            return null;
        }

        public async Task<IEnumerable<ReWrite>> FindbByUserId(string userName)
        {
            return await WithConnection(async x =>
            {
               var p = new DynamicParameters();
               p.Add("Username",userName,DbType.String);
                var rewrites = await x.QueryAsync<ReWrite>
                    (
                        sql: "",
                        param: p,
                        commandType: CommandType.StoredProcedure
                    );

                return rewrites;
            });
        }

        public async Task<ReWrite> FindByUrl(string url)
        {
            return await WithConnection(async x =>
            {
                var p = new DynamicParameters();
                p.Add("Url", url, DbType.String);
                var rewrites = await x.QueryAsync<ReWrite>
                    (
                        sql: "",
                        param: p,
                        commandType: CommandType.StoredProcedure
                    );
                return rewrites.FirstOrDefault();
            });
        }

        public Task<IEnumerable<ReWrite>> Find(Expression<Func<ReWrite, bool>> predicate)
        {
            return null;
        }

        public Task<IEnumerable<ReWrite>> GetAllRedirects()
        {
            return null;
        }
    }
}
