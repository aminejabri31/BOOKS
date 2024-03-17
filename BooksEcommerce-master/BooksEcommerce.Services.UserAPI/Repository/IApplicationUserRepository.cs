
using BooksEcommerce.Services.UserAPI.Models;
using BooksEcommerce.Services.UserAPI.Models.Dto;

namespace BooksEcommerce.Services.UserAPI.Repository
{
    public interface IApplicationUserRepository { 
        
        Task<ApplicationUserDto> GetApplicationUserById(int Id);
        
        Task<ApplicationUserDto> UpdateApplicationUser(ApplicationUserDto applicationUserDto);
        Task<ApplicationUserDto> CreateApplicationUser(ApplicationUserDto applicationUserDto);
        Task<bool> DeleteApplicationUser(int Id);
    
    }
}
