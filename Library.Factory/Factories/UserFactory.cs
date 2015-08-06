using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.InteropServices;
using Library.Factory.Contexts;
using Library.Factory.Models;

namespace Library.Factory.Factories
{
    public class UsersFactory
    {
        public static List<User> GeList()
        {
            using (var db = new UserContext())
            {
                return db.Users.ToList();
            }
            
           }

        public static User AddUser(User newUser)
        {
            using (var db = new UserContext())
            {
                var user = db.Users.Add(newUser);
                db.SaveChanges();
                return user;
            }
        }

        public static User UpdateUser(User newUser)
        {
            using (var db = new UserContext())
            {
                var currentUser = db.Users.FirstOrDefault(user => user.Id == newUser.Id);
                currentUser.Name = newUser.Name;
                currentUser.SecondName = newUser.SecondName;
                currentUser.PhoneNumber = newUser.PhoneNumber;
                currentUser.Adress = newUser.Adress;
                db.SaveChanges();

                return currentUser;
            }
        }

        public static void DeleteUser(User userToDelete)
        {
            using (var db = new UserContext())
            {
                var currentUser = db.Users.FirstOrDefault(user => user.Id == userToDelete.Id);
                db.Users.Remove(currentUser);
                db.SaveChanges();
              
            }
        
        }
    }
}