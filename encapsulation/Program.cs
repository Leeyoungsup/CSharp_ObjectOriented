using System;

namespace encapsulation
{
    //OOP(은닉성)
    //자동차
    //핸들 페달 차문
    //전기장치 엔진 기름
    class Knight
    {
        //접근 한정자 
        //public 모든권한
        //protected 자식클래스와 본인만 사용가능
        //아무것도 없을 경우 private
        //private 본인만 사용 가능
        protected int hp;
        
    }
    class SuperKnight:Knight
    {
        void Test()
        {
            hp = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
        }
    }
}
