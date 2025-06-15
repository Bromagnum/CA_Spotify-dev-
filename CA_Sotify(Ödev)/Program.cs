using CA_Sotify_Ödev_.Utils;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Concretes;
using System;

namespace CA_Ssotify_Ödev
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            ConsoleMenü consoleMenu = new ConsoleMenü();

            consoleMenu.ShowMainMenu();
        }
    }

}

