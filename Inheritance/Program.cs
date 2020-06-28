using System;

namespace Inheritance
{
    //OOP(은닉성/상속성/다형성)
    public class Player//부모클래스,기반 클래스
    {
        static public int counter = 1;//오로지 한개만 존재
        public int id;
        public int hp;
        public int attack;
        public Player()
        {
            Console.WriteLine("Player 생성자호출");
        }
        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자호출");
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
    class Mage:Player
    {


    }
    class Archer:Player
    {

    }
    class Knight:Player//자식,파생
    {
        public Knight():base(100)
        {
            Console.WriteLine("Knight 생성자호층");
        }
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
            Knight knight = Knight.CreateKnight();
            knight.Move();

        }
    }
}
