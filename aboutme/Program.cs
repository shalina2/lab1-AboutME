using System;

namespace aboutme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what do you think my name is?");
            
            string guess=Console.ReadLine();
             name(guess);

            Console.WriteLine("how old do you thik i am?");
            string guessed= Console.ReadLine();
            //int guessed = Convert.ToInt32(input);
            age(guessed);

            Console.WriteLine("whats my favorite color");
            string input = Console.ReadLine();
           color(input);

            Console.WriteLine("whats my favorite bootcamp?");
            string answer = Console.ReadLine();
            bootcamp(answer);

        }
        static void name(string guess)
        {
            if (guess == "shalom")
            {
                Console.WriteLine("oh wow you got it");
                

            }
            else
            {
                Console.WriteLine("oh wow you dont even know my name huh?");
                Console.Write("try again: ");
                Console.ReadLine();
                name(guess);
            }
           // Console.ReadLine();
        }
        static void age(string guessed)
        {
            if (guessed == "27")
            {
                Console.WriteLine("youre amazing ");
            }
            else
            {
                Console.WriteLine("lol nice try");
            }
        }
        static void color(string input)
        {
            try
            {
                input = "0";
            }
            catch
            {
                Console.WriteLine("Error,invalid syntax");
            }
            if (input == "red")
            {
                Console.WriteLine("yay thats right");
            }
            else
            {
                Console.WriteLine("No it isnt my fav");
            }
        }
                static void bootcamp(string answer)
            {
                if(answer=="codefellows")
            {
                Console.WriteLine("ofcourse it is");
            
            }
                else
            {
                Console.WriteLine("nooo,but i dont hate it ");
            }
            Console.ReadLine();
 }
                
            }
                
        }
        
    

