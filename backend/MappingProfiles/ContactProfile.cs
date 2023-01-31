using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ReadContactDto>().ReverseMap();
            // Generate a Guid for the conversion of CreateContactDto to Contact class
            CreateMap<CreateContactDto, Contact>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateContactDto, Contact>();
        }
    }
}
