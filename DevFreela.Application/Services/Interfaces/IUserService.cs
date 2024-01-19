using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        public int Create(CreateUserInputModel userInputModel);
        public UserViewModel GetById(int id);
        public bool Login(LoginInputModel loginInputModel);


    }
}
