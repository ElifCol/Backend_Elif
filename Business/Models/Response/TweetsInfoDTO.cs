using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TweetsInfoDTO
    {
        public int Id { get; set; } = default!;
        public string tweet { get; set; } = default!;

        public int user_id { get; set; }

        public bool liked { get; set; }


        public User? User { get; set; }
    }
}
