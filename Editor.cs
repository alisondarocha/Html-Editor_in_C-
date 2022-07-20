using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");

            Start();

        }
        public static void Start()
        {
            var file = new StringBuilder(); 

            do 
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-=-=-==-=-=-=-=-=-");
            Console.WriteLine(" Salvar Arquivo?");
            Console.WriteLine("Sim [1]");
            Console.WriteLine("Não [2]");

            var option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: Viewer.Show(file.ToString());break;
                case 2: Environment.Exit(0);break;
                default : Menu.Show();break;
            }
        }   
    }
}