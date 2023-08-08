using Business.Models.Request;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class FollowersController : BaseCRUDController<Followers,int,FollowersCreateDTO,FollowersUpdateDTO,FollowersInfoDTO>
    {
        public FollowersController(IFollowersService service) : base(service)
        {
        }
    }
}
