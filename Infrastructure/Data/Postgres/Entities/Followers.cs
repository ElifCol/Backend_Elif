using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Followers : Entity<int>
    {
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string SurName { get; set; } = default!;
        public string Gsm { get; set; }

        public int user_id { get; set; }


        public User? User { get; set; }
    }
}
