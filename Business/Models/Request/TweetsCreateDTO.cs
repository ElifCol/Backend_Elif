using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request
{
    public class TweetsCreateDTO
    {
        public string tweet { get; set; } = default!;

        public int user_id { get; set; }

       


        
    }
}
