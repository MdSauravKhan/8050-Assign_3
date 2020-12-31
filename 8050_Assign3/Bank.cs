using System;
using System.Collections.Generic;
using System.Text;
using account;
using user;


namespace bank 
{
    class Bank : Account
    {
        //Properties
        private double currencies;
        private double amount;

       
        public Bank()
        {
        }

        public Bank(double currencies, double amount)
        {
            this.currencies = currencies;
            this.amount = amount;           

        }
        public override void Show()
        {
            double amount = 1000;
            Console.WriteLine("For Current amount : 1 , Diposit : 2 , Transfer : 3 , Withdraw : 4 , Exit : 5");
            int input = Convert.ToInt32(Console.ReadLine());                            

                
                  switch (input)
                  {

                case 1:
                    Console.WriteLine("Your Current amount is:"+ amount);                    
                    break;

                case 2:
                    Console.WriteLine("Enter your dipositable amount:");
                    double deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("Your money has been deposited successfully!!!");
                    Console.WriteLine("Now, your Current amount is:"+ amount);
                    break;
                case 3:
                    Console.WriteLine("Enter your Transferable amount:");
                    double transfer = int.Parse(Console.ReadLine());
                    amount = amount - transfer;
                    Console.WriteLine("Your money has been transfered successfully!!!");
                    Console.WriteLine("Now, your Current amount is:" + amount);
                    break;
                case 4:
                    Console.WriteLine("Enter your Withdrawable amount:");
                    double Withdraw = int.Parse(Console.ReadLine());
                    amount = amount - Withdraw;
                    Console.WriteLine("Your money has been transfered successfully!!!");
                    Console.WriteLine("Now, your Current amount is:" + amount);
                    break;
                case 5:
                    break;           

            }           


        }      

    }
}
