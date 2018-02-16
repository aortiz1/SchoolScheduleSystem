using SchoolSchedule.Service.Contracts;
using SchoolSchedule.DataLayer.Contracts;
using SchoolSchedule.DataLayer.Model;
using SchoolSchedule.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.Service.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<Guid> AddNewUser(User user)
        {
            return await _userRepository.AddNewUser(user);
        }

        public async Task<bool> UpdateUserInformation(User user)
        {
            return await _userRepository.UpdateUserInformation(user);
        }

        public async Task<User> GetUserInformation(Guid? userId)
        {
            return await _userRepository.GetUserInformation(userId);
        }
        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }
        public async Task<bool> GenerateMockUsers(int totalRegisters)
        {
            return await _userRepository.GenerateMockUsers(totalRegisters);
        }
    }
}
