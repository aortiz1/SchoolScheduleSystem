using SchoolSchedule.DataLayer.Contracts;
using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace SchoolSchedule.DataLayer.Repository
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

        public async Task<User> GetUserByName(string userName)
        {
            try
            {
                var result = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName);
                if(result == null)
                {
                    throw new Exception("The user does not exist");
                }
                return result;
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
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var result = await _context.Users.ToListAsync();
                
                return result;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
        public async Task<bool> SetRoleToUser(AspNetUserRole roleUser)
        {
            try
            {
                roleUser.Id = Guid.NewGuid();
                _context.AspNetUserRoles.Add(roleUser);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
         
        public async Task<bool> GenerateMockUsers(int totalRegisters)
        {
            try
            {
                for (int i = 0; i < totalRegisters; i++)
                {
                    var newUser = GenerateMockUser();
                    _context.Users.Add(newUser);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
        public User GenerateMockUser()
        {
            var semesters = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var mockUser = new Faker<User>()
                 .RuleFor(u => u.Id, f => Guid.NewGuid())
                 .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                 .RuleFor(u => u.LastName, f => f.Name.LastName())
                 .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
                 .RuleFor(u => u.Created, f => DateTime.Now)
                 .RuleFor(u => u.CurrentSemester, f => f.PickRandom(semesters))
                 .RuleFor(u => u.IsGraduated, f => false)
                 .RuleFor(u => u.IsExpelled, f => false)
                 .RuleFor(u => u.Email, (f, u) => f.Internet.UserName(u.FirstName, u.LastName)+"@"+ f.Random.Words(1)+".com")
                ;
            return mockUser.Generate();
        }

    }
}
