using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace StaticIdebtity
{
    class Knight
    {
        static public int counter=1;//오로지 한개만 존재
        public int id;
        public int hp;
        public int attack;
        static public void Test()
        {
            counter++;
        }
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            return knight;
        }
        public Knight()
        {
            id = counter;
            counter++;
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
    class mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight=Knight.CreateKnight();
            knight.Move();
            
        }
    }
}
