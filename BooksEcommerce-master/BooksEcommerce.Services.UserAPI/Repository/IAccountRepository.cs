using BooksEcommerce.Services.UserAPI.Models;
using BooksEcommerce.Services.UserAPI.Models.Dto;

namespace BooksEcommerce.Services.UserAPI.Repository
{
    public interface IAccountRepository
    {
        Task<AccountDto> CreateAccount(AccountDto accountDto);
        Task<AccountDto> GetAccountByEmail(string email);

        
        Task<bool> CheckAccountPassword (int Id,string password);
    }
}
