using AutoMapper;
using BooksEcommerce.Services.UserAPI.Models;
using BooksEcommerce.Services.UserAPI.Models.Dto;

namespace BooksEcommerce.Services.UserAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ApplicationUser, ApplicationUserDto>();
                config.CreateMap<ApplicationUserDto, ApplicationUser>();
                config.CreateMap<Account, AccountDto>();
                config.CreateMap<AccountDto, Account>();
         
            }
                );
            return mappingConfig;
        }
    }
}
