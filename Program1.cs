using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0711
{
    internal class Program
    {/* 자료형
        int
        float
        string
        bool

        연산자
        산술연산자 +-/*%
        비교연산자><>=<===!=
        배열
        자료형[] 배열명 = new 자료형 [크기];

        배열명[인덱스], 크기 -1,0 부터 시작
        반복문
        for
        array
        int[]= new int[크기]
        시작이 0부터 시작 크기 -1
         for(초기치; 조건식; 증가치)
        {
            break; (멈추는거)
        }

        if (조건식)
        {
          
        }

        else if
        {
        }
        else
        {
        }

        switch()
        {
        case:
        break;
        default:
        break;
        }


        if 든 반복문이든 break만나면 끝나용~

        

         
        절차지향 프로그래밍 쭉 말로
        객체지향 프로그래밍
        Object - 사물 객체
        switch case break
        최적화
        제어문한거임
        ...
        제2장 다 해야돼요..~
        oop?
        C#스터디->기초->
        // 형 변환
            // casting
            //int <->float
            //int <-> string
            //float<->string
            //bool<->string



            //산술연산자
            //증감연산자 ++,--
            //논리연산자
            //비교연산자
            //연산자 우선우위는 괄호로 묶어서
            //길면 쪼개서  해도됨 (보기 편한게 우선)

            //&& and
            //! not
            // or???
        while은.......

        */


        static void Main(string[] args)
        {


            int number1 = 0;
            int number2 = 0;
            string readNumber1 = "";
            string readNumber2 = "";


            //gameloop
            while (true)                               //조건이 참일 때만
            {
                //input
                readNumber1 = Console.ReadLine();
                readNumber2 = Console.ReadLine();

                //process, update
                number1 = int.Parse(readNumber1);
                number2 = int.Parse(readNumber2);

                //Print, reder
                Console.WriteLine(number1 + number2);
                Console.WriteLine(number1 - number2);
                Console.WriteLine(number1 * number2);
                Console.WriteLine(number1 / number2);
                Console.WriteLine(number1 % number2);
            }


        }
    }
}




