using account;
using System;
using System.Collections.Generic;
using System.Text;


namespace goods
{
    class Goods : Account
    {
        //Properties
        private string goods;
        private double amounts;
        private string tradingUnit;

        public Goods()
        {
        }

        public Goods(string goods, double amounts, string tradingUnit)
        {
            this.goods = goods;
            this.amounts = amounts;
            this.tradingUnit = tradingUnit;
        }

        public override void Show()
        {
            string [] goods  = { "Rice" , " Tomatoes", " Potatoes" , "Apples" };
            double amounts = 50000;
            string[] tradingUnit = { "grams", "kilos", "uncas" };


            Console.WriteLine("For Current Goods : 1 , Buy_Goods : 2 , Sell_Goods : 3 , Exit : 4");
            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {

                case 1:
                    for(int i=0;i<goods.Length; i++)
                    {
                        Console.WriteLine("Your Current goods are:");
                        Console.WriteLine(goods[i]);
                    }
                    
                    Console.WriteLine("Your Current amount is:" + amounts);

                    for (int j = 0; j < tradingUnit.Length; j++)
                    {
                        Console.WriteLine("Your Current trading units are:");
                        Console.WriteLine(goods[j]);
                    }
                    break;

                case 2:
                    Console.WriteLine("Buy new goods:");
                    string buy = Convert.ToString(Console.ReadLine());                
                    Console.WriteLine("Your Good has been added successfully!!!");
                    Console.WriteLine("Now, your new good is:" + buy);                                           
                    break;
                case 3:
                    Console.WriteLine("Sell  goods:");
                    string sell = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Your Good has been added successfully!!!");
                    Console.WriteLine("Now, your sold good is:" + sell);
                    break;
                case 4:
                    break;


            }

        }

    }
}
