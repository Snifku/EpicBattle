using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Voldemort", "Darth Vader", "Maria Under", "Savusaar", "Ansip", "Plankton", "Gay Bavian" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero} will fight {villain}");
            
            int heroHP = GenerateHP();
            int villainHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} with " + $"{villainHP} HP");

            while(heroHP > 0 && villainHP > 0)
            {
                Random rnd = new Random();
                heroHP = heroHP - rnd.Next(0, 4);
                villainHP = villainHP - rnd.Next(0, 4);
                villainHP = villainHP - hit(villain);
                heroHP = heroHP - hit(hero);
            }
            GetWinner(heroHP, villainHP);
            if (heroHP == 0)
            {
                Console.WriteLine("Dark Side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }
        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }
        public static int  GenerateHP()
        {
            Random rnd = new Random();
            int heroHP = rnd.Next(5, 11);
            return heroHP;
        }
        public static int hit (string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if(strike == 3)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            }else if(strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");
            }
            return strike;
        }
        public static void GetWinner(int hHP, int vHP)
        {
            if(hHP == 0)
            {
                Console.WriteLine("Dark Side wins!");
            }
            else
            {
                Console.WriteLine($"Hero saves the day!");
            }
        }
        
      
        
    }
}
