using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateUserInputModel userInputModel)
        {
            var user = new User(userInputModel.FullName, userInputModel.Email, userInputModel.BirthDate);
            _dbContext.Users.Add(user);

            return user.Id;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            var userViewModel = new UserViewModel(user.FullName, user.Email, user.BirthDate);

            return userViewModel;
        }

        public bool Login(LoginInputModel loginInputModel)
        {
            throw new NotImplementedException();
        }
    }
}
