using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATMProjectTwo
{
    class EatmProj
    {
        private int[] cardNumbers = new int[] { 1, 2, 3 };
        private int[] pinNumbers = new int[] { 123, 234, 456 };
        private int[] balances = new int[] { 500, 200, 800 };

        private int cardInput;
        private int pinNumber;
        private int _withdrow;
        private int _trantransactionCount = 1;
        private bool _flag = true;

        public void EatmMachine()
        {
            Console.WriteLine(" *** Welcome to our EatmProj service *** ");
            Console.Write("what is your card number : ");
            cardInput = Convert.ToInt32(Console.ReadLine());

            CheckCardNumber(cardInput);
        }

        public void CheckCardNumber(int cardNo)
        {
            Console.Write("Enter your valid pin number : ");
            pinNumber = Convert.ToInt32(Console.ReadLine());
            if (cardNumbers[0] == cardNo)
            {
                CheckPinNumber(pinNumber,pinNumbers,0);
            }
            else if (cardNumbers[1] == cardNo)
            {
                CheckPinNumber(pinNumber,pinNumbers,1);
            }

            else if (cardNumbers[2] == cardNo)
            {
                CheckPinNumber(pinNumber,pinNumbers,2);
            }

            else
            {
                Console.WriteLine("Invalid card number.Please try again !");
            }
        }


        public void CheckPinNumber(int pinNum,int[] id,int index)
        {
            if (pinNum == id[index])
            {
                PrintOptions();
                MenuOptions(balances,index);
            }
            else if (pinNum == id[index])
            {
                PrintOptions();
                MenuOptions(balances, index);
            }
            else if (pinNum == id[index])
            {
                PrintOptions();
                MenuOptions(balances, index);
            }
            else
            {
                Console.WriteLine("Invalid Pin number ");
            }
        }

        public void PrintOptions()
        {
            Console.WriteLine("1.Check account balance \t 2.Cash withdrawal \t 3.Exit");
        }

        public void MenuOptions(int[] id,int index)
        {
            do
            {
                Console.Write("What you want to do ? Enter option numbre : ");
                int getOption = Convert.ToInt32(Console.ReadLine());
                if (getOption == 1)
                {
                    Console.WriteLine("Your total balance is : " + id[index]);
                }
                else if (getOption == 2)
                {
                    Console.Write("Enter Amount : ");
                    _withdrow = Convert.ToInt32(Console.ReadLine());
                    if (_withdrow < id[index])
                    {
                        if (_trantransactionCount > 3)
                        {
                            Console.WriteLine("Total transactions limit is 3 per day.");
                            Console.WriteLine("Automatically logged out.");
                            _flag = false;
                            break;
                        }
                        else
                        {
                            Transaction(id, index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.Thank You !");
                    }

                }
                else if (getOption == 3)
                {
                    _flag = false;
                }
                else
                {
                    Console.WriteLine("You enter invalid option number ! Enter valid option");
                }
            } while (_flag);

        }

        public void Transaction(int[] id,int index)
        {
            id[index] -= _withdrow;
            _trantransactionCount++;
            Console.WriteLine("Cash withdrawal successful. Your account balance is " + id[index]);
            Console.WriteLine("Do you want to quit? Press 3 for quit ... ");
            Console.WriteLine();
        }
    }
}

