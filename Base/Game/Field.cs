using System;

namespace Base.Game
{
    class Field
    {
        public Field(int x, int y)
        {
            Console.BufferHeight = x;
            Console.BufferWidth = y;

            Console.WindowHeight = x;
            Console.WindowWidth = y;

            Console.Title = "Game";
        }
    }
}
