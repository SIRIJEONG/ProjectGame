using RandomWall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectGame
{
    public class Store
    {
        int gold = 100000;


        Random random = new Random();
        List<Store> store_list = default;
        List<string> Invrntory_list = default;
        System.ConsoleKeyInfo key = default;

        int itemNumber1 = 1;
        int itemNumber2 = 2;
        int itemNumber3 = 3;
        int itemNumber4 = 4;
        int itemNumber5 = 5;
        int itemNumber6 = 6;
        int itemNumber7 = 7;
        int itemNumber8 = 8;
        int itemNumber9 = 9;
        int itemNumber10 = 10;
        string userchoice = default;

        public string name1;
        public int money;

        public void name(string itemName, int gold)
        {
            name1 = itemName;
            money = gold;
        }

        public void market()
        {

            Store waterbottle = new Store();
            waterbottle.name("김재현의 물병", 10000);
            Store glasses = new Store();
            glasses.name("박시연의 알없는 안경", 15000);
            Store macbook = new Store();
            macbook.name("배경택의 맥북", 39800);
            Store pouch = new Store();
            pouch.name("이미정의 곰돌이 파우치", 100000);
            Store pin = new Store();
            pin.name("박준오의 머리핀", 8000);
            Store pants = new Store();
            pants.name("유준호의 찢어진바지", 80000);
            Store coffee = new Store();
            coffee.name("교수님의 아이스아메리카노", 3000);
            Store mandarin = new Store();
            mandarin.name("신성창의 제주감귤", 2000);
            Store IQOS = new Store();
            IQOS.name("이경민의 부숴진 아이코스", 5000);
            Store lighter = new Store();
            lighter.name("박정근의 세상을 멸망시킬 라이터", 4444);


            store_list = new List<Store>();

            store_list.Add(waterbottle);
            store_list.Add(glasses);
            store_list.Add(macbook);
            store_list.Add(pouch);
            store_list.Add(pin);
            store_list.Add(pants);
            store_list.Add(coffee);
            store_list.Add(mandarin);
            store_list.Add(IQOS);
            store_list.Add(lighter);



            Invrntory_list = new List<string>();

        }

        public void showStore()
        {
            while (true)
            {

                Console.SetCursorPosition(0, 0);

                Console.WriteLine();
                Console.WriteLine("[상점]");
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber1, store_list[0].name1, store_list[0].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber2, store_list[1].name1, store_list[1].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber3, store_list[2].name1, store_list[2].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber4, store_list[3].name1, store_list[3].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber5, store_list[4].name1, store_list[4].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber6, store_list[5].name1, store_list[5].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber7, store_list[6].name1, store_list[6].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber8, store_list[7].name1, store_list[7].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber9, store_list[8].name1, store_list[8].money);
                Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber10, store_list[9].name1, store_list[9].money);


                userchoice = Console.ReadLine();



                if (userchoice == "1")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[0].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[0].name1, gold);
                    Invrntory_list.Add(store_list[0].name1);
                    continue;

                }



                else if (userchoice == "2")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[1].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[1].name1, gold);
                    Invrntory_list.Add(store_list[1].name1);

                    continue;


                }





                else if (userchoice == "3")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[2].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[2].name1, gold);
                    Invrntory_list.Add(store_list[2].name1);

                    continue;


                }



                else if (userchoice == "4")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[3].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[3].name1, gold);
                    Invrntory_list.Add(store_list[3].name1);

                    continue;


                }





                else if (userchoice == "5")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[4].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[4].name1, gold);
                    Invrntory_list.Add(store_list[4].name1);

                    continue;


                }



                else if (userchoice == "6")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[5].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[5].name1, gold);
                    Invrntory_list.Add(store_list[5].name1);

                    continue;


                }





                else if (userchoice == "7")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[6].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[6].name1, gold);
                    Invrntory_list.Add(store_list[6].name1);

                    continue;


                }




                else if (userchoice == "8")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[7].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[7].name1, gold);
                    Invrntory_list.Add(store_list[7].name1);

                    continue;


                }





                else if (userchoice == "9")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[8].money;
                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[8].name1, gold);
                    Invrntory_list.Add(store_list[8].name1);

                    continue;


                }



                else if (userchoice == "10")
                {
                    if (gold <= 0)
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        continue;
                    }
                    gold -= store_list[9].money;

                    Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", store_list[9].name1, gold);
                    Invrntory_list.Add(store_list[9].name1);

                    continue;


                }

                else if (userchoice == "N" || userchoice == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("[인벤토리]");
                    //Invrntory_list = new List<string>();
                    for (int i = 0; i < Invrntory_list.Count; i++)
                    {
                        Console.WriteLine("{0}", Invrntory_list[i]);

                    }
                    Console.WriteLine();
                }


                else if (userchoice == "r" || userchoice == "R")
                {
                    Console.Clear();
                    Program program = new Program();
                    program.start();

                }
            }
        }
    }
}
