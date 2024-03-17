using AutoMapper;
using BooksEcommerce.Services.UserAPI.DBContext;
using BooksEcommerce.Services.UserAPI.Models;
using BooksEcommerce.Services.UserAPI.Models.Dto;

namespace BooksEcommerce.Services.UserAPI.Repository
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserDBContext _dbContext;
        private IMapper _mapper;
        public ApplicationUserRepository(UserDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApplicationUserDto> CreateApplicationUser(ApplicationUserDto applicationUserDto)
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = applicationUserDto.Id,
                UserName = applicationUserDto.UserName,
                LastName = applicationUserDto.LastName,
                PhoneNumber = applicationUserDto.PhoneNumber,
                JoinedAt = DateTime.Now,
                AddressUser = applicationUserDto.AddressUser,
                ImageURL = applicationUserDto.ImageURL,
            };
            await _dbContext.ApplicationUsers.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ApplicationUserDto>(user);
        }

        public async Task<bool> DeleteApplicationUser(int Id)
        {
            ApplicationUser user = await _dbContext.ApplicationUsers.FindAsync(Id);
            if (user != null)
            {
                _dbContext.ApplicationUsers.Remove(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;

        }



        public async Task<ApplicationUserDto> GetApplicationUserById(int Id)
        {
            ApplicationUser user = await _dbContext.ApplicationUsers.FindAsync(Id);
            return _mapper.Map<ApplicationUserDto>(user);
        }

        public async Task<ApplicationUserDto> UpdateApplicationUser(ApplicationUserDto applicationUserDto)
        {
            ApplicationUser user = await _dbContext.ApplicationUsers.FindAsync(applicationUserDto.Id);
            user.Id = applicationUserDto.Id;
            user.UserName = applicationUserDto.UserName;
            user.LastName = applicationUserDto.LastName;
            user.PhoneNumber = applicationUserDto.PhoneNumber;
            user.JoinedAt = DateTime.Now;
            user.AddressUser = applicationUserDto.AddressUser;
            user.ImageURL = applicationUserDto.ImageURL;
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ApplicationUserDto>(user);
        }
    }
}
