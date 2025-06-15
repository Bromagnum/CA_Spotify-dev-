using System;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Abstract;    

namespace CA_Sotify_Ödev_.Repositories.Concretes
{
    public class UserRepository : IUserRepository
    {
        MyDbContext context = new MyDbContext();

        public void GetAllUsers()
        {
            foreach (User user in context.Users)
            {
                string userFormat = $"Id: {user.Id} Ad: {user.Name} Soyad: {user.Surname} Doğum Tarihi: {user.DateOfBirth}";
                Console.WriteLine(userFormat);
            }
        }

        public void CreateUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            Console.WriteLine("Kullanıcı eklendi.");
        }

        public void UpdateUser(User updated)
        {
            var user = context.Users.Find(updated.Id);
            if (user != null)
            {
                user.Name = updated.Name;
                user.Surname = updated.Surname;
                user.DateOfBirth = updated.DateOfBirth;
                // Diğer alanlar varsa ekleyin
                context.SaveChanges();
                Console.WriteLine("Kullanıcı güncellendi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı.");
            }
        }

        public void DeleteUser(int id)
        {
            var user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                Console.WriteLine("Kullanıcı silindi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı.");
            }
        }
    }
}