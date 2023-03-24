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
            throw new NotImplementedException();
        }

        private void AddPhoto()
        {
            throw new NotImplementedException();
        }

        private void AddMesage()
        {
            
        }
    }
}
