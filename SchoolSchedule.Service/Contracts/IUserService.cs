using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.Service.Contracts
{
    public interface IUserService
    {
        Task<Guid> AddNewUser(User user);
        Task<bool> UpdateUserInformation(User user);
        Task<User> GetUserInformation(Guid? userId);
        Task<List<User>> GetAllUsers();
        Task<bool> GenerateMockUsers(int totalRegisters);
    }
}
