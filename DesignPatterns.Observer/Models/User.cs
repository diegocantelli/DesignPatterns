using System;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Models
{
    // Esta classe será a interessada em ser notificada sempre que ocorrer alguma
    // mudança no blog
    public class User : IObserver
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Update(object obj)
        {
            var post = (Post)obj;
            Console.WriteLine($"User: {this.Fullname} - New Post: {post.Title}");
        }
    }
}
