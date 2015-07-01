using System;
using System.Threading;

namespace Base.Game
{
    class MonsterDog
    {
        Random rand;
        private int x = 10;
        private int y = 10;
        private char d = '@';
        private char hideDog = ' ';

        private void ShowTheDog(char s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public void MoveTheDog()
        {
            rand = new Random();


                int step = rand.Next(1,5);
                switch(step)
                {
                    case 1:
                        x++;
                        if (x > 80 - 1)
                        {
                            x = 80 - 1;
                        }
                        ShowTheDog(d, x, y);
                        ShowTheDog(hideDog, x - 1, y);
                        break;
                    case 2:
                        x--;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        ShowTheDog(d, x, y);
                        ShowTheDog(hideDog, x + 1, y);
                        break;
                    case 3:
                        y++;
                        if (y > 30 - 1)
                        {
                            y = 30 - 1;    
                        }
                        ShowTheDog(d, x, y);
                        ShowTheDog(hideDog, x , y - 1);
                        break;
                    case 4:
                        y--;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        ShowTheDog(d, x, y);
                        ShowTheDog(hideDog, x , y + 1);
                        break;
                }
                Thread.Sleep(500);
            
        }

    }
}
