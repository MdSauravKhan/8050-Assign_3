using System;
using account;
using goods;
using bank;
using shares;
using iconnection;

namespace user
{
    class User
    {
        private string username;
        private string password;
        private string name;

        public User()
        {
        }

        public User(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;

        }

        public static object Public { get; private set; }

        static void Main()
        {
           string name="Saurav";
           string username = "sau3551";
           string password = "khan123";

            

          //Verifying Login!!!!
           Console.WriteLine("Please Enter your Name:");
           String nm = Console.ReadLine();
           Console.WriteLine("Please Enter your User Name:");
           String unm = Console.ReadLine();
           Console.WriteLine("Please Enter your Password:");
           String pw = Console.ReadLine();



            if (nm == name && unm == username && pw == password)
            {
                Console.WriteLine("You logged in successfully!!!");
                Options();
            }
            else
            {
                Console.WriteLine("Your Inputs are wrong. Please try again!!!");

            }

            //Accounts options
            void Options()
            {
                Console.WriteLine("For Bank Account : 1, Share Account : 2, Goods Account : 3 , List of user accounts : 4 , Exit : 5 ");
                int cn = Convert.ToInt32(Console.ReadLine());

                switch (cn)
                {
                    case 1:
                        Account obj = new Bank();
                        obj.showAccount();
                        obj.Show();
                        break;
                    case 2:
                        Account obj1 = new Shares();
                        obj1.showAccount();
                        obj1.Show();
                        break;

                    case 3:
                        Account obj2 = new Goods();
                        obj2.showAccount();
                        obj2.Show();
                        break;

                    case 4:
                        Account obj3 = new Bank();
                        obj3.AllAccounts();
                        break;
                    case 5:                        
                        break;

                }
            }          

            

        }
       
    }
}
