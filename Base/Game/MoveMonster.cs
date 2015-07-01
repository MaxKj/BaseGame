using System;

namespace Base.Game
{
    class MoveMonster
    {
        ConsoleKeyInfo cki;
        private int x = 0;
        private int y = 0;
        private char a = 'x';
        private char h = ' ';

        private void ShowAndHideMonster(char s, int x, int y)
        { 
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public void MoveShowToMonster()
        {

            ShowAndHideMonster(a, x, y);    

                cki = Console.ReadKey();

                switch (cki.Key)
                { 
                    case ConsoleKey.RightArrow:
                        x++;
                        if (x > 80 - 1)  // Исправить переменной, значения поля начинается с 0
                        {
                            x = 80 - 1;
                        }
                        ShowAndHideMonster(a, x, y);
                        ShowAndHideMonster(h, x - 1, y);
                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        ShowAndHideMonster(a, x, y);
                        ShowAndHideMonster(h, x + 1, y);
                        break;

                    case ConsoleKey.DownArrow:
                        y++;
                        if (y > 30 - 1)  // Тоже самое что с переменной x
                        {
                            y = 30 - 1;
                        }
                        ShowAndHideMonster(a, x, y);
                        ShowAndHideMonster(h, x, y - 1);
                        break;

                    case ConsoleKey.UpArrow:
                        y--;
                        if (y < 0)
                        {
                            y = 0;    
                        }
                        ShowAndHideMonster(a, x, y);
                        ShowAndHideMonster(h, x, y + 1);
                        break;
                
            }
        }


    }
}
