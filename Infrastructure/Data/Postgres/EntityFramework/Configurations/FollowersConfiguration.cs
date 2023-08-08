using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FollowersConfiguration : IEntityTypeConfiguration<Followers>
    {
        public void Configure(EntityTypeBuilder<Followers> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
}
