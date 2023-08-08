using Business.Models.Request;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class TweetsController : BaseCRUDController<Tweets, int, TweetsCreateDTO, TweetsUpdatDTO, TweetsInfoDTO>
    {
        public TweetsController(ITweetService service) : base(service)
        {
        }
    }
}
