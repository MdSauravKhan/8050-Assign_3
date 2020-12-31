//using goods;
using iconnection;
using System;
using user;
namespace account
{
    abstract class Account: IConnection
    {
        //Properties
        private string user;
        private string type;
        private int number;

        public Account()
        {
        }

        public Account(string user, string type, int number)
        {
            this.user = user;
            this.type = type;
            this.number = number;

    }
        public abstract void Show();
        public void showAccount()
        {
            Console.WriteLine("Name: Md Saurav Khan");
            Console.WriteLine("Personal Account.");
            Console.WriteLine("Your Account number: 4515-6654-4785");
        }


        //List of all accounts
        public void AllAccounts()
        {
            //Account 1
            Console.WriteLine("Name: Md Saurav Khan");
            Console.WriteLine("Personal Account.");
            Console.WriteLine("Your Account number: 4515-6654-4785");
            Console.WriteLine("--------------------------------------------");

            //Account 2
            Console.WriteLine("Name: Mohan");
            Console.WriteLine("Personal Account.");
            Console.WriteLine("Your Account number: 1100-6600-0085");
            Console.WriteLine("--------------------------------------------");

            //Account 3
            Console.WriteLine("Name: Anisha");
            Console.WriteLine("Share Account.");
            Console.WriteLine("Your Account number: 4515-6654-4785");
            Console.WriteLine("--------------------------------------------");

            //Account 4
            Console.WriteLine("Name: Anali");
            Console.WriteLine("Personal Account.");
            Console.WriteLine("Your Account number: 5684-8778-2652");
            Console.WriteLine("--------------------------------------------");

            //Account 5
            Console.WriteLine("Name: Monica");
            Console.WriteLine("Share Account.");
            Console.WriteLine("Your Account number: 4554-5432-8996");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
