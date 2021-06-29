using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public IEnumerable<User> GetAll();
    }
}
