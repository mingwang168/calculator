using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            var operationChoice = Console.ReadLine();
            if (operationChoice != "1" && operationChoice != "2" && operationChoice != "3" && operationChoice != "4" && operationChoice != "5" && operationChoice != "6")
            {
                ShowMenu();
                operationChoice = Console.ReadLine();
            }
            else
            {
                while (operationChoice != "6")
                {
                    decimal a = GetOperatorA();
                    decimal b = GetOperatorB();
                    Console.WriteLine("the result is : " + Docalculation(a, b, operationChoice));
                    ShowMenu();
                    operationChoice = Console.ReadLine();
                }
            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine("***********Calculator Menu*******************");
            Console.WriteLine("1: Addition (+)");
            Console.WriteLine("2: Subtraction (-)");
            Console.WriteLine("3: Multiplication (X)");
            Console.WriteLine("4: Division (/)");
            Console.WriteLine("5: Remainder (%)");
            Console.WriteLine("6: EXIT");
        }

        public static decimal GetOperatorA()
        {
            Console.WriteLine("Input operator A :");
            decimal cleanNum1 = 0;
            var opa = Console.ReadLine();
            while (!decimal.TryParse(opa, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an decimal value: ");
                opa = Console.ReadLine();
            }
            return Convert.ToDecimal(opa);
        }

        public static decimal GetOperatorB()
        {
            Console.WriteLine("Input operator B :");
            decimal cleanNum2 = 0;
            var opb = Console.ReadLine();
            while (!decimal.TryParse(opb, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter an decimal value: ");
                opb = Console.ReadLine();
            }
            return Convert.ToDecimal(opb);
        }

        public static decimal Docalculation(decimal a, decimal b, string operationChoice)
        {
            var oa = a;
            var ob = b;
            var op = operationChoice;
            decimal result = 0;
            if (op == "1")
            {
                result = oa + ob;

            }
            else if (op == "2")
            {
                result = oa - ob;

            }
            else if (op == "3")
            {
                result = oa * ob;

            }
            else if (op == "4" && ob != 0)
            {
                result = oa / ob;

            }
            else if (op == "4" && ob == 0)
            {
                while (ob == 0)
                {
                    Console.WriteLine("Enter a non-zero divisor: ");
                    ob = Convert.ToDecimal(Console.ReadLine());
                }
                result = oa / ob;
            }
            else if (op == "5")
            {
                result = oa % ob;

            }
            return result;
        }
    }
}
