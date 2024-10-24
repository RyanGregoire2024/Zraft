using System;
using RandomMathDLL;

namespace Main
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Commands command = new Commands();
            RandomNum r = new RandomNum();

            
            
            Console.WriteLine("Enter Command 1: ");
            var command1 = Console.ReadLine();

            if (command1.Equals("/Math"))
            {
                string op = r.getOperator();
                if (op == "+")
                {
                    int num1 = r.getRandomNum(1, 10);
                    int num2 = r.getRandomNum(1, 11);
                    
                    Console.WriteLine($"What is: {num1} + {num2}");
                    int answer = int.Parse(Console.ReadLine());

                    if (answer == r.Add(num1, num2))
                    {
                        Console.WriteLine($"Correct That: {num1} + {num2} = {r.Add(num1, num2)}");
                        Console.ReadLine();
                    }
                    
                    
                }
                else if (op.Equals("-"))
                {
                    int num1 = r.getRandomNum(1, 10);
                    int num2 = r.getRandomNum(1, 11);
                    
                    Console.WriteLine($"What is: {num1} - {num2}");
                    int answer = int.Parse(Console.ReadLine());

                    if (answer == r.Sub(num1, num2))
                    {
                        Console.WriteLine($"Correct That: {num1} - {num2} = {r.Sub(num1, num2)}");
                        Console.ReadLine();
                    }   
                } else if (op.Equals("*"))
                {
                    int num1 = r.getRandomNum(1, 10);
                    int num2 = r.getRandomNum(1, 11);
                    
                    Console.WriteLine($"What is: {num1} * {num2}");
                    int answer = int.Parse(Console.ReadLine());
                    
                    if (answer == r.Mul(num1, num2))
                    {
                        Console.WriteLine($"Correct That: {num1} + {num2} = {r.Mul(num1, num2)}");
                        Console.ReadLine();
                    }
                } else if (op.Equals("/"))
                {
                    int num1 = r.getRandomNum(1, 10);
                    int num2 = r.getRandomNum(1, 11);
                    
                    Console.WriteLine($"What is: {num1} / {num2}");
                    int answer = int.Parse(Console.ReadLine());

                    if (answer == r.Div(num1, num2))
                    {
                        Console.WriteLine($"Correct That: {num1} + {num2} = {r.Div(num1, num2)}");
                        Console.ReadLine();
                    }
                }
            }
            
            if (command1.Equals("/Pom"))
            {
                Console.WriteLine("Timer of Pom Started");
                Timer a = new Timer();
                Timer.SetTimer();   
                Timer.GetTimer();
            }

            Console.WriteLine("Would You Like to Continue or Stop: ");
            var commandContinue = Console.ReadLine();
            if (commandContinue.Equals("yes"))
            {

                Timer.BreakTimer();
                Console.WriteLine("Break just Started");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Timer of Pom Started");
                Timer a = new Timer();
                Timer.SetTimer();   
                Timer.GetTimer();
            }
            
            
            if (Empty.IsEmpty(command1))
            {
                Console.WriteLine("Empty...");
            }
            else
            {
                command.Commands1(command1);
                
            }
            
            
            Empty m = new Empty();
            
            Console.WriteLine("Enter Command 2: ");
            string command2 = Console.ReadLine();

            if (Empty.IsEmpty(command2))
            {
                Console.WriteLine("Empty...");
            }
            else
            {
                command.Commands2(command2);
                
            }

            Console.WriteLine("Enter Command 3: " );
            string command3 = Console.ReadLine();

            if (Empty.IsEmpty(command3))
            {
                Console.WriteLine("Empty...");   
            }

            else
            {
                command.Commands3(command3);
                
            }
            
            Console.ReadLine();                     
        }
        
    }
    
}