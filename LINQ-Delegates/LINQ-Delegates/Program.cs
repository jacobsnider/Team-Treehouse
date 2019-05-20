using System;

namespace FunctionalProgramming
{
    class Program
    {       
        
        static void Main(string[] args)
        {
            Action<string> sayGreeting;

            Func<string, string> conversate = delegate (string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            };

            string input = conversate("What's your name?");
             
            sayGreeting = delegate(string greeting)
            {
                Console.WriteLine(string.Format(greeting, input));
            };
            
            sayGreeting("Hello, {0}");
            conversate("Nice to see you.");
            conversate("Are you doing well?");
            sayGreeting("Later, {0}");
        }
    }
}