using System;

namespace StaticIdebtity
{
    class Knight
    {
        static public int count=1;//오로지 한개만 존재
        public int id;
        public int hp;
        public int attack;
        public Knight()
        {
            id = count;
            count++;
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }
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

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight1 = new Knight();
            Knight knight2= new Knight();
            knight2.hp = 80;
            Knight knight3 = new Knight();
            knight3.hp = 200;

        }
    }
}
