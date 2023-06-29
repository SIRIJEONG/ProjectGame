using MyProjectGame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RandomWall
{
    public class Stairs
    {
        Gold gold1 = new Gold();

        Random random = new Random();
        List<Stairs> Stairs_list = default;

        char[,] stairs_ = new char[20, 10];

        int Number = 5;
        int score = 0;
        int randomChoice = default;
        int randomChoice2 = default;
        int userx = 4;
        int usery = 18;
        int change = 0;

        public int x;
        public int y;



        public void position(int ypos, int xpos)
        {


            x = xpos;
            y = ypos;
        }




        public void InfinityStairs()
        {


            System.ConsoleKeyInfo key = default;



            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 10; x++)
                {

                    stairs_[y, x] = '·';
                }
            }
            Stairs_list = new List<Stairs>();

            //stairs_[1, 6] = '■';









            ////처음 게임 화면 구현 
            int startTurn = 0;

            while (startTurn < 18)
            {



                Console.SetCursorPosition(0, 0);


                randomChoice = random.Next(1, 11);
                randomChoice2 = random.Next(1, 11);




                if (randomChoice <= 5)
                {
                    if (Number > 7)
                    {
                        continue;

                    }
                    else
                    {
                        if (randomChoice2 <= 5)
                        {
                            stairs_[0, Number] = '■';

                        }
                        else if (randomChoice2 > 5)
                        {
                            stairs_[0, Number] = '▣';

                        }
                        Number++;
                    }

                }



                else if (randomChoice > 5)
                {
                    if (Number < 2)
                    {
                        continue;

                    }
                    else
                    {

                        if (randomChoice2 > 5)
                        {
                            stairs_[0, Number] = '■';

                        }
                        else if (randomChoice2 <= 5)
                        {
                            stairs_[0, Number] = '▣';

                        }
                        Number--;

                    }

                }





                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (stairs_[y, x] == '·')
                        {

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();

                        }
                        else if (stairs_[y, x] == '★')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }
                        else if (stairs_[y, x] == '■')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }
                        else if (stairs_[y, x] == '▣')
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine();
                }










                for (int y = 0; y < 19; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (stairs_[y, x] == '■' || stairs_[y, x] == '▣')
                        {


                            Stairs StairsList = new Stairs();
                            StairsList.position(y, x);

                            Stairs_list.Add(StairsList);


                        }
                    }
                }


                for (int i = 0; i < Stairs_list.Count; i++)
                {
                    swap(ref stairs_[Stairs_list[i].y, Stairs_list[i].x], ref stairs_[Stairs_list[i].y + 1, Stairs_list[i].x]);
                    Stairs_list[i].y++;

                }

                Stairs_list.Clear();


                startTurn++;

            }





            while (true)
            {
                //Gold AllGold = new Gold();
                //AllGold.AddmoneyGold();





                Console.SetCursorPosition(0, 0);

                Console.WriteLine("                        현재 스코어 : {0}" , score);


                randomChoice = random.Next(1, 11);
                randomChoice2 = random.Next(1, 11);




                if (randomChoice <= 5)
                {
                    if (Number > 7)
                    {
                        continue;

                    }
                    else
                    {
                        if(randomChoice2 <= 5) 
                        { 
                        stairs_[0, Number] = '■';
                        
                        }
                        else
                        {
                            stairs_[0, Number] = '▣';

                        }
                        Number++;
                        score++;
                    }

                }



                else if (randomChoice > 5)
                {
                    if (Number < 2)
                    {
                        continue;

                    }
                    else
                    {

                        if (randomChoice2 > 5)
                        {
                            stairs_[0, Number] = '■';

                        }
                        else
                        {
                            stairs_[0, Number] = '▣';

                        }
                        Number--;
                        score++;

                    }

                }



                stairs_[usery, userx] = '★';


                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (stairs_[y, x] == '·')
                        {

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();

                        }
                        else if (stairs_[y, x] == '★')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }
                        else if (stairs_[y, x] == '■')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }
                        else if (stairs_[y, x] == '▣')
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("{0} ", stairs_[y, x]);
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine();
                }




                key = Console.ReadKey(true);



                //마지막 줄에서는 계단이 사라진다.
                for (int x = 0; x < 10; x++)
                {
                    if (stairs_[19, x] == '■' || stairs_[19, x] == '▣')
                    {
                        stairs_[19, x] = '·';



                    }
                }
               

                if ('l' == key.KeyChar || 'L' == key.KeyChar)
                {
                    if (1 < userx && userx < 9)
                    {


                        if (change == 0)
                        {
                            if(stairs_[usery, userx + 1] == '▣')
                            {
                                gold1.AddmoneyGold(100);

                            }
                            swap(ref stairs_[usery, userx], ref stairs_[usery, userx + 1]);

                            userx += 1;
                            if ((stairs_[usery, userx + 1] == '·' && stairs_[usery, userx - 1] == '·') || userx == 0 || userx == 9)
                            {

                                Console.WriteLine("잘 못하시나봐요 ^^");
                                Console.WriteLine("현재 스코어 : {0}", score);
                                Thread.Sleep(1000);
                                key = Console.ReadKey(true);

                                if ('r' == key.KeyChar || 'R' == key.KeyChar)
                                {
                                    Console.Clear();
                                    Program program = new Program();
                                program.start();

                                }


                           }
                            stairs_[usery, userx] = '·';
                            stairs_[usery, userx -1] = '·';


                        }

                        else if (change == 1)
                        {
                            if (stairs_[usery, userx - 1] == '▣')
                            {
                                gold1.AddmoneyGold(100);
                                //gold += 100;

                            }
                            swap(ref stairs_[usery, userx], ref stairs_[usery, userx - 1]);
                            userx -= 1;
                            if ((stairs_[usery, userx + 1] == '·' && stairs_[usery, userx - 1] == '·') || userx == 0 || userx == 9)
                            {

                                Console.WriteLine("잘 못하시나봐요 ^^");
                                Console.WriteLine("최종 스코어 : {0}", score);
                                Thread.Sleep(1000);
                                key = Console.ReadKey(true);

                                if ('r' == key.KeyChar || 'R' == key.KeyChar)
                                {
                                    Console.Clear();
                                    Program program = new Program();
                                    program.start();

                                }


                            }
                            stairs_[usery, userx] = '·';
                            stairs_[usery, userx + 1] = '·';


                        }
                    }

                    randomStairs();
                }

                if ('a' == key.KeyChar || 'A' == key.KeyChar)
                {
                    if (change == 0)
                    {
                        change++;
                        if (stairs_[usery, userx - 1] == '▣')
                        {
                            gold1.AddmoneyGold(100);

                        }
                        swap(ref stairs_[usery, userx], ref stairs_[usery, userx - 1]);


                        userx -= 1;
                        if ((stairs_[usery, userx + 1] == '·' && stairs_[usery, userx - 1] == '·') || userx == 0 || userx == 9)
                        {

                            Console.WriteLine("잘 못하시나봐요 ^^");
                            Console.WriteLine("최종 스코어 : {0}", score);
                            Thread.Sleep(1000);
                            key = Console.ReadKey(true);

                            if ('r' == key.KeyChar || 'R' == key.KeyChar)
                            {
                                Console.Clear();
                                Program program = new Program();
                                program.start();

                            }
                        }
                        stairs_[usery, userx] = '·';
                        stairs_[usery, userx + 1] = '·';

                    }
                    else if (change == 1)
                    {


                        change--;
                        if (stairs_[usery, userx + 1] == '▣')
                        {
                            gold1.AddmoneyGold(100);
                            //gold += 100;

                        }
                        swap(ref stairs_[usery, userx], ref stairs_[usery, userx + 1]);


                        userx += 1;
                        if ((stairs_[usery, userx + 1] == '·' && stairs_[usery, userx - 1] == '·') || userx == 0 || userx == 9)
                        {
                            Console.WriteLine("잘 못하시나봐요 ^^");
                            Console.WriteLine("최종 스코어 : {0}", score);
                            Thread.Sleep(1000);
                            key = Console.ReadKey(true);

                            if ('r' == key.KeyChar || 'R' == key.KeyChar)
                            {
                                Console.Clear();
                                Program program = new Program();
                                program.start();

                            }

                        }
                        stairs_[usery, userx] = '·';
                        stairs_[usery, userx - 1] = '·';

                    }
                    randomStairs();
                }


            }

        }
        public void swap(ref char firstChar, ref char secondChar)
        {
            char temp = '0';
            temp = (firstChar);
            (firstChar) = (secondChar);
            (secondChar) = temp;
        }

        public void randomStairs()
        {
            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (stairs_[y, x] == '■' ||  stairs_[y, x] == '▣')
                    {


                        Stairs StairsList = new Stairs();
                        StairsList.position(y, x);

                        Stairs_list.Add(StairsList);


                    }
                }
            }


            for (int i = 0; i < Stairs_list.Count; i++)
            {
                swap(ref stairs_[Stairs_list[i].y, Stairs_list[i].x], ref stairs_[Stairs_list[i].y + 1, Stairs_list[i].x]);
                Stairs_list[i].y++;

            }

            Stairs_list.Clear();

        }





    }
}

