using System;

namespace CopyReference
{
    //객체
    //속성
    //기능

    //참조
    class Knight
    {
        public int hp;
        public int attack;
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }
    //복사
    class mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            
        }
    }
}
