using AutoMapper;
using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.DTOs.Common;
using CleanArchitecture.Domain.BusinessEntities;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Mappings
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            CreateMap<AddStoryDTO, Story>().ForMember(dest => dest.Tags, opt => opt.Ignore());
            CreateMap<Story, GetStoryDTO>().ForMember(dest => dest.Tags, opt => opt.Ignore());
            CreateMap<Story, AddStoryDTO>().ForMember(dest => dest.Tags, opt => opt.Ignore());
            CreateMap<AddTagDTO, Tag>().ReverseMap();//Reverse is used for PATCH
            CreateMap<Tag, GetTagDTO>();
            CreateMap<Tag, GetTagWithStoriesDTO>().ForMember(dest => dest.Stories, opt => opt.Ignore()); ;
            CreateMap<AddUserDTO, User>().ReverseMap();//Reverse is used for PATCH
            CreateMap<User, GetUserDTO>();

            CreateMap<AuditInfoStruct, AuditInfoStructDTO>().ReverseMap();
        }
    }

}
