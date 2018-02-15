using ShoolSchedule.DataLayer.Contracts;
using ShoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoolSchedule.DataLayer.Repository
{
    public class UserRepository: IUserRepository
    {
        private  SchoolScheduleDBEntities _context;
        public UserRepository()
        {
            _context = new SchoolScheduleDBEntities();
        }
        public async Task<Guid> AddNewUser(User user)
        {
            try
            {
                user.Id = Guid.NewGuid();
                _context.Users.Add(user);
                var operation = await _context.SaveChangesAsync();
                return user.Id;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
        public async Task<bool> UpdateUserInformation(User user)
        {
            try
            {
                var existingUser = await _context.Users.CountAsync(x => x.Id == user.Id);
                if(existingUser ==0)
                {
                    throw new Exception("Selected user not found on database");
                }
                _context.Entry(user).State = EntityState.Modified;
                var operation = await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }

        public async Task<User> GetUserInformation(Guid? userId)
        {
            try
            {
                var existingUser = await _context.Users.FindAsync(userId);
                if (existingUser == null)
                {
                    throw new Exception("Selected user not found on database");
                }
                return existingUser;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }

    }
}
