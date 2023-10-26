using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingMapster.DTOs;
using UsingMapster.Entities;

namespace UsingMapster.Services.Interfaces;

public interface IUserService
{
    User CreateUser(UserForCreation user);
    List<UserViewModel> GetUsers();
}
