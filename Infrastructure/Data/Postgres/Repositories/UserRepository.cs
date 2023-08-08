using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories;

public class UserRepository : Repository<User, int>, IUserRepository
{
    private PostgresContext _context;

    public UserRepository(PostgresContext postgresContext) : base(postgresContext)
    {
        _context = postgresContext;
    }

    public virtual async Task<IList<User>> GetAllAsync(Expression<Func<User, bool>>? filter = null)
    {
        var user = PostgresContext.Set<User>()
            .Include(user => user.Followers)
            .Include(user => user.Tweets);


        return filter == null
            ? await PostgresContext.Set<User>().ToListAsync()
            : await PostgresContext.Set<User>().Where(filter).ToListAsync();
    }

    private async Task<List<User>> GetUsersByFilterAsync(Expression<Func<User, bool>> filter)
    {
        var user = PostgresContext.Set<User>()
           .Include(user => user.Followers)
           .Include(user => user.Tweets);

        return await _context.User.Where(filter).ToListAsync(); 
    }
}