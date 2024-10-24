using System;

namespace Main
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Commands command = new Commands();
            
            Console.WriteLine("Enter Command 1: ");
            var command1 = Console.ReadLine();
            
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