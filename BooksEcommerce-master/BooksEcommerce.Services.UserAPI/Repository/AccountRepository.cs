using AutoMapper;
using BooksEcommerce.Services.UserAPI.DBContext;
using BooksEcommerce.Services.UserAPI.Models;
using BooksEcommerce.Services.UserAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BooksEcommerce.Services.UserAPI.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly UserDBContext _dbContext;
        private IMapper _mapper;
        public AccountRepository(UserDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CheckAccountPassword(int Id,string password)
        {
            Account account = await _dbContext.Accounts.FindAsync(Id);
            if (account.Password == password) return true;
            return false;


        }

        public async Task<AccountDto> CreateAccount(AccountDto accountDto)
        {
            Account account = new Account
            {
                Id = accountDto.Id,
                Email = accountDto.Email,
                Password = accountDto.Password,
                IsEmailConfirmed = accountDto.IsEmailConfirmed,
                Created = DateTime.Now,
                Role = accountDto.Role,
                User = accountDto.User,

            };
            await _dbContext.Accounts.AddAsync(account);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<AccountDto>(account);
        }

        public async Task<AccountDto> GetAccountByEmail(string email)
        {
            Account account = await _dbContext.Accounts.FirstOrDefaultAsync(a => a.Email == email);
            if (account == null)
            {
                return null;
            }

            return _mapper.Map<AccountDto>(account);
        }

      
    }
}
   
