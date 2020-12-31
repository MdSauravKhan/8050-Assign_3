using System;
using System.Collections.Generic;
using System.Text;
using account;
using bank;


namespace shares 
{
    class Shares : Account
    {
        //Properties
        private double shares;
        private double amounts;
        private string percentage ;

        public Shares()
        {
        }

        public Shares(double shares, double amounts, string percentage)
        {
            this.shares =shares;
            this.amounts = amounts;
            this.percentage = percentage;

        }
        public override void Show()
        {
            double share = 100;
            double amounts= 200000;
            string percentage = "50%";


        Console.WriteLine("For Current Share : 1 , BuyShare : 2 , TransferShare : 3 , SellShare : 4 , Exit : 5");
            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {

                case 1:
                    Console.WriteLine("Your Current share is:" + share);
                    Console.WriteLine("Your Current amount is:" + amounts);
                    Console.WriteLine("Stakeholder's percentage is:" + percentage);
                    break;

                case 2:
                    Console.WriteLine("Buy new Share:");
                    double buy = int.Parse(Console.ReadLine());
                    share = share + buy;
                    Console.WriteLine("Your share has been added successfully!!!");
                    Console.WriteLine("Now, your total share is:" + share);
                    break;
                case 3:
                    Console.WriteLine("Enter your Transferable share:");
                    double transfer = int.Parse(Console.ReadLine());
                    share = share - transfer;
                    Console.WriteLine("Your share has been transfered successfully!!!");
                    Console.WriteLine("Now, your total share is:" + share);
                    break;
                case 4:
                    Console.WriteLine("Sell your share:");
                    double sell = int.Parse(Console.ReadLine());
                    share = share - sell;
                    Console.WriteLine("Your share has been sold successfully!!!");
                    Console.WriteLine("Now, your total share is:" + share);
                    break;
                case 5:
                    break;

            }

        }
    }
}
