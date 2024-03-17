using BooksEcommerce.Services.UserAPI.Models.Dto;
using BooksEcommerce.Services.UserAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BooksEcommerce.Services.UserAPI.Controllers
{
    [Route("api/[[user]]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
       
            protected ReponseDto _reponse;
            private  AccountRepository _accountRepository;
            private  ApplicationUserRepository _applicationUserRepository;
            public UserAPIController(AccountRepository accountRepository, ApplicationUserRepository applicationUserRepository)
            {
                this._reponse = new ReponseDto();
                _accountRepository = accountRepository;
                _applicationUserRepository = applicationUserRepository;
                
            }
        [HttpPost("newaccount")]
        public async Task<object> CreateAccount(AccountDto accountDto)
        {//try
            {
                AccountDto account = await _accountRepository.CreateAccount(accountDto);
                _reponse.Result = account;
                return _reponse;
            }

        }
        [HttpPost("account/{id}/newapplicationuser")]
        public async Task<object> CreateApplicationUser(ApplicationUserDto applicationUserDto)
        {//try
            {
                ApplicationUserDto account = await _applicationUserRepository.CreateApplicationUser(applicationUserDto);
                _reponse.Result = account;
                return _reponse;
            }


        }
        //update
        [HttpPut("account/{id}/applicationuser/{id}")]
        public async Task<object> UpdateApplicationUser(ApplicationUserDto applicationUserDto)
        {//try
            {
                ApplicationUserDto applicationUser = await _applicationUserRepository.UpdateApplicationUser(applicationUserDto);
                _reponse.Result = applicationUser;
                return _reponse;
            }
        }
        [HttpGet("account/connect")]
        public async Task<bool> ConnectToAccount(string email, string password)
        {//try
            { AccountDto account = await _accountRepository.GetAccountByEmail(email);
            return await _accountRepository.CheckAccountPassword(account.Id, password);
            }

        }
    }
}
