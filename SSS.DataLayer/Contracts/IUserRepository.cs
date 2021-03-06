﻿using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.DataLayer.Contracts
{
    public interface IUserRepository
    {
        Task<Guid> AddNewUser(User user);
        Task<bool> UpdateUserInformation(User user);
        Task<User> GetUserInformation(Guid? userId);
        Task<List<User>> GetAllUsers();
        Task<bool> GenerateMockUsers(int totalRegisters);
        Task<User> GetUserByName(string userName);
        //Task<bool> SetRoleToUser(AspNetUserRol roleUser);

        Task<UserProfileView> GetUserByEmail(string email);
    }
}
