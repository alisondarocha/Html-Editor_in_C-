using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(); 
            WriteOptions();

            var option = int.Parse(Console.ReadLine());

            HandleMenuOption(option);     


        }
        
        public static void DrawScreen()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.Write("-=-");
            }

            Console.Write("\n");

            for(int lines = 0; lines <= 10; lines ++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i ++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            for(int i = 0; i <= 10; i++)
            {
                Console.Write("-=-");
            }
        }
        
        public static void WriteOptions()
        {
            Console.SetCursorPosition(2,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(2,3);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.SetCursorPosition(2,4);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(2,5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(2,6);
            Console.WriteLine("2 - Abrir")  ;
            Console.SetCursorPosition(2,7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2,8);
            Console.WriteLine("Opção: ");
            Console.SetCursorPosition(8,8);
        }

        public static void HandleMenuOption(int option)
        {
            switch(option)
            {
                case 1: Editor.Show();break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();break;
            }
        }
    }
}