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

        Random random = new Random();
        List<Store> store_list = default;

        string x;
        int y;

        public void name(string itemName, int gold)
        {
            x = itemName;
            y = gold;
        }

        public void market()
        {

            Store waterbottle = new Store();
            waterbottle.name("김재현의 물병", 100);
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
            mandarin.name("신성창의 제주감귤", 200);
            Store IQOS = new Store();
            IQOS.name("이경민의 부숴진 아이코스", 5000);
            Store lighter = new Store();
            lighter.name("박정근의 세상을 멸망시킬 라이터", 200);


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


        }
    }
}
