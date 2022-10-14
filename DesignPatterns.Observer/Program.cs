using System;
using DesignPatterns.Observer.Models;

namespace DesignPatterns.Observer
{
    //Este padrão é muito útil nos cenários nos quais notificações precisam
    //precisam ser enviadas para vários objetos diferentes através da aplicação
    //Criando uma interface para o observador, permite-se que seja executada lógicas diferentes para cada objeto
    // que esteja recebendo a notificação de uma maneira escalável
    class Program
    {
        static void Main(string[] args)
        {
            var userOne = new User(); 
            userOne.Fullname = "User One";

            var userTwo = new User();
            userOne.Fullname = "User Two";

            var userThree = new User();
            userOne.Fullname = "User Three";

            // Blog é o subject
            var blog = new Blog();
            blog.Attach(userOne);
            blog.Attach(userTwo);
            blog.Attach(userThree);

            var post = new Post();
            post.Title = "First post";
            post.Description = "My first post";
            post.PublicationTime = DateTime.Now;

            //toda vez que é adicionado um novo post, todos os observadores
            // serão notificados
            blog.AddPost(post);

            Console.ReadLine();
          
        }
    }
}
