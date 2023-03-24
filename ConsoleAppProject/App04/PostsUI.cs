using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class will be the uer interface which allowd
    /// users to post messages and photos
    /// </summary>
    public class PostsUI
    {
        private NewsFeed news = new NewsFeed();

        public void Run()
        {
            ConsoleHelper.OutputHeading("App04: My Social Network");

            string[] choices =
             {
                "Add Message Post",
                "Add Photo Post",
                "Display All Posts",
                "Another Choice",
                "Quit"
            };

            bool quit = false;

            while (quit != true)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMesage(); break;
                    case 2: AddPhoto(); break;
                    case 3: DisplayAllPosts();  break;
                    case 4: break;
                    case 5: quit = true; break;
                }
            }
        }

        private void DisplayAllPosts()
        {
            news.Display();
        }

        private void AddPhoto()
        {
            throw new NotImplementedException();
        }

        private void AddMesage()
        {
            string name = GetUserName(); 

            Console.Write("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            news.AddMessagePost(post);
        }

        private string GetUserName()
        {
            Console.Write("Pleas enter your name > ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
