using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweets : Entity<int>
    {
        public string tweet { get; set; } = default!;

        public int user_id { get; set; }

        public bool liked { get; set; }


        public User? User { get; set; }
    }


}
