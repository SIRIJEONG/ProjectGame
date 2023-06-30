using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectGame
{
    public class Gold
    {
         public int gold = default;
        
        //public Gold()
        //{
        //    gold = 0;
        //}

        public void AddmoneyGold(int addGold )
        {
            gold += addGold;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                      보유골드 : {0}", gold);
        }

        public void showGold()
        {
            Console.WriteLine("                      보유골드 : {0}", gold);
        }

        //public void moneyGold(ref int gold_)
        //{
        //    gold =0; 
        //    Console.WriteLine();
        //    Console.WriteLine("                      보유골드 : {0}", gold);
        //}
    }
}
