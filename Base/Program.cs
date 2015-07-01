using System;

namespace Base
{
    class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;

            var moveMonster = new Game.MoveMonster();
            var showDog = new Game.MonsterDog();

            var sizeField = new Game.Field(30, 80);

            while (true)
            {
                showDog.MoveTheDog();
                if (Console.KeyAvailable == true)
                {
                    moveMonster.MoveShowToMonster();    
                }
                
            }
        }
    }
}
