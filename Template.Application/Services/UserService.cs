using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;
        private readonly IMapper mapper; 

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public List<UserViewModel> Get() 
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();

            IEnumerable < User > _users = this.userRepository.GetAll();

            _userViewModels = mapper.Map<List<UserViewModel>>(_users);

            return _userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User _user = mapper.Map<User>(userViewModel);

            this.userRepository.Create(_user);

            return true;
        }

    }
}
