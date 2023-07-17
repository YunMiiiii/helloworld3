using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 자료형 int float string bool
   연산자
 * 산술연산자 
 * 비교연산자
 * 논리연산자
 * 할당연산자 = 
 * 증감연산자
 * if else if 잘..해보시길
 * 컨트롤 쉬프트 스페이스바= 설명
 * 함수는 괄호 ...정보를 뽑을떄 동사 읽는다 쓴다 가져온다 찾는다 식으로 동사임
 * 반복하는건 포문
 * 1부터는 횟수 0부터는 그 외..? (int)
 * 띄어쓰기는 탭키로
 * 2차원 배열, 3차원 배열
 * char가 모이면 string??
 *  현재 위치 xy 조건 두개 같으면 and 연산자
 *  그 다음에 해야할게 뭐냐면 한칸씩그릴때 제일 마지막에 그릴걸 그려서 ?
 *  배경그리는거면 얘보다 먼저 해야됨. 
 *  구조적으로 만드는건 함수로..? 
 *  우리가 쓰는건 1ㄷ1함수로 매칭이 돼야함 두개로 쪼개지면 안됨
 *  2D 게임엔진 제작하기 최종목표는 캐릭터 애니메이션
 *  유니티로 배우는 게임 수학 하고싶음하세요
 *   static 자료형 함수이름 (인자1, 인자2,..)
 *   반환형이 void라 그러면 ㅎ반환할게 없다는거? 
 *   ->ex)Clear? 뭘 하긴 하는데 계산할건 없는..느낌인가 ㅋ
 *   ConsoleKeyInfo ->키
 *   함수는 동작하는 단위 함루라고하면 입력이 있으면 출력이 있어야됨 입력은 string 출력은 void
 *   static?은 나중에
 *   Main은 주로하는작업
 *   void Main()함수라고하면 프로그램 단위 하나
 *   등록해서 쓸 수 있음 
 *   함수니까 입력과 출력이 있을 거고 
 *   static 출력은 받을게 뭔지  없으면 void 있으면 int,등 
 *   Add 동사 ~한다
 *   Debuging ????
 *   
 */

namespace _0712
{
    internal class Program
    {
        


        static void Main(string[] args)
        {



            int[,] map = {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            int playerX = 1;
            int playerY = 1;

            while (true)
            {

                //Input();
                ConsoleKeyInfo info = Console.ReadKey(true); //입력에서 키만 받아올거고

                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        
                        if (map[playerY, playerX - 1] != 1)
                        {
                            playerX--;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (map[playerY, playerX + 1] != 1)
                        {
                            playerX++;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (map[playerY-1, playerX ] != 1)
                        {
                            playerY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[playerY+1, playerX ] != 1)
                        {
                            playerY++;
                        }
                        break;

                }

                Console.Clear();


                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {

                        if (playerX == x && playerY == y)       //현재 그린 위치에 플레이어가 있으면 그린다는 뜻?
                        {
                            Console.Write("P" + " ");
                        }
                        else if (map[y, x] == 1)                //맵을 그린다
                        {
                            Console.Write("*" + " ");
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(" " + " ");
                        }
                        else
                        {

                        }


                    }
                    Console.WriteLine();
                }

            }
        }
    }
}