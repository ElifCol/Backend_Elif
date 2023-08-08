using Business.Models.Request;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();

        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();

        CreateMap<Tweets, TweetsInfoDTO>();

        CreateMap<TweetsCreateDTO, Tweets>();
        CreateMap<TweetsUpdatDTO, Tweets>();


        CreateMap<Followers, FollowersInfoDTO>();

        CreateMap<FollowersCreateDTO, Followers>();
        CreateMap<FollowersUpdateDTO, Followers>();



    }
}