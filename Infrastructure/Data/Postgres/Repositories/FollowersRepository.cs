﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class FollowersRepository : Repository<Followers, int>, IFollowersRepository
    {
        public FollowersRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
    }
}