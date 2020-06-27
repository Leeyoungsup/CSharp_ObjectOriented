using System;

namespace ObjectOrientedStart
{
    //객체
    //속성
    //기능
    class Knight
    {
        public int hp;
        public int attack;
        public void Move()
        {
            Console.WriteLine("Knight Move") ;
        }
        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.attack = 10;
            knight.hp = 100;
            knight.Move();
            knight.Attack();
        }
    }
}
