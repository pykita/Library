using System.Collections.Generic;
using System.Linq;
using Library.Factory.Contexts;
using Library.Factory.Models;

namespace Library.Factory.Factories
{
    public class UsersFactory
    {
        public static List<User> GeList()
        {
            using (var db = new LibraryContext())
            {
                return db.Users.ToList();
            }
            
           }

        public static User AddUser(User newUser)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.Add(newUser);
                db.SaveChanges();
                return user;
            }
        }
        public static User GetUserById(int id)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.FirstOrDefault(b => b.Id == id);
                if (user != null)
                {
                    user.BookList = db.Books.Where(b => b.UserId == id).ToList();
                }

                return user;
            }
        }

        public static User UpdateUser(User newUser)
        {
            using (var db = new LibraryContext())
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
            using (var db = new LibraryContext())
            {
                var currentUser = db.Users.FirstOrDefault(user => user.Id == userToDelete.Id);
                db.Users.Remove(currentUser);
                db.SaveChanges();
              
            }
        
        }
    }
}