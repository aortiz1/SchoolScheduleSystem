using ShoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoolSchedule.DataLayer.Contracts
{
    public interface IUserRepository
    {
        Task<Guid> AddNewUser(User user);
        Task<bool> UpdateUserInformation(User user);
        Task<User> GetUserInformation(Guid? userId);
    }
}
