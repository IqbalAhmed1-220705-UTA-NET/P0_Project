
using System;




namespace ATMTRANSACTION
{
    class Program
    {
        static void main(string[] args)
        {
            int amt = 1000;
            int deposit, withdraw;
            int change, pin = 0, x =0;
            Console.WriteLine("Your pin number===>");
            pin = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("ATM SSERVICES\n");
                Console.WriteLine("---------------\n");
                Console.WriteLine("1. Check Account Balance\n");
                Console.WriteLine("2. Withdraw\n");
                Console.WriteLine("3. Deposit\n");
                Console.WriteLine("4. Exit\n\n\n\n");
                Console.WriteLine("Select an option:===>   ");
                change = int.Parse(Console.ReadLine());

                switch(change)
                {
                    case 1:
                        Console.WriteLine("\n\n Your Balance is : (0) ", amt);
                            break;
                    case 2: 
                        Console.WriteLine("Amount to be withdrawn");
                        with = int.Parse(Console.ReadLine());
                    if (with % 100 != 0)
                    {
                         Console.WriteLine("\n\nEnter amount in Multiple of 100");
                    }
                    else if (with > (amt - 200))
                    {
                         Console.WriteLine("\n Insufficient Fund");
                    }
                    else
                    {
                        amt = amt - withdraw;
                        console.WriteLine("\n Take Your Money");
                        console.WriteLine("\n Current Balance is (0)", amt);

                    }
                    break;

                    case 3:
                            Console.WriteLine("\n Enter the anount to be deposited");
                            deposit = int.Parse(console.ReadLine());
                            amt = amt + deposit;
                            console.WriteLine("\n Current Balance is (0)", amt);

                    break;

                    case: 4 
                        console.WriteLine.("\n Thank You");

                }

                
            }
        }
    }
}