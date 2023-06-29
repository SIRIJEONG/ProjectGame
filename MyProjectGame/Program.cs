using RandomWall;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProjectGame
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Program program = new Program();
            program.start();
        }

        public void start()
        {

        first:



            Console.SetCursorPosition(18, 5);
            Console.WriteLine("무한의 계단");


            Console.SetCursorPosition(20, 15);
            Console.WriteLine("Q.게임시작");
            Console.SetCursorPosition(22, 17);

            Console.WriteLine("W.상점");
            Console.SetCursorPosition(18, 19);

            Console.WriteLine("E.클리어 조건");


            Screen map = new Screen();
            map.ScreenMap();

            Gold gold1 = new Gold();
            //gold1.moneyGold();

            System.ConsoleKeyInfo key = default;

            key = Console.ReadKey(true);

            Console.SetCursorPosition(19, 5);
            if ('q' == key.KeyChar || 'Q' == key.KeyChar)
            {
                Console.Clear();

                Stairs step = new Stairs();
                //step.StairsPosition();
                step.InfinityStairs();


            }

            if ('w' == key.KeyChar || 'W' == key.KeyChar)
            {
                Console.Clear();

                Store store = new Store();
                //step.StairsPosition();

                store.market();
                store.showStore();

            }



            if ('e' == key.KeyChar || 'E' == key.KeyChar)
            {
                Console.Clear();

                Console.WriteLine("[클리어 조건]");
                Console.WriteLine();
                Console.WriteLine("게임을 통해 코인을 얻습니다");
                Console.WriteLine("얻은 코인을 통해 상점에서 10개의 아이템을 구매합니다");
                Console.WriteLine("10개의 아이템을 모두 구매하면 유저가 원하는 히든 아이템을 얻고 게임을 클리어 할수 있습니다");
                Console.WriteLine("행운을 빕니다!");

                key = Console.ReadKey(true);


                if ('r' == key.KeyChar || 'R' == key.KeyChar)
                {
                    Console.Clear();
                    goto first;
                }
            }
        }


    }
}
