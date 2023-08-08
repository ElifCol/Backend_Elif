using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FollowersInfoDTO
    {
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string SurName { get; set; } = default!;
        public string Gsm { get; set; }

        public int user_id { get; set; }

        public User? User { get; set; }
    }
}
