using System;

namespace textadventure
{
    public static class Game
    {

        public static void StartGame()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            {
                var arr = new[]

                {

                    @"  /$$$$$$        /$$                                /$$                                        /$$$$$$$            /$$                           /$$     /$$           /$$",
                    @" /$$__  $$      | $$                               | $$                                       | $$__  $$          | $$                          | $$    |__/          | $$",
                    @"| $$  \ $$  /$$$$$$$ /$$    /$$/$$$$$$  /$$$$$$$  /$$$$$$   /$$   /$$  /$$$$$$  /$$$$$$       | $$  \ $$/$$$$$$  /$$$$$$    /$$$$$$  /$$$$$$$  /$$$$$$   /$$  /$$$$$$ | $$",
                    @"| $$$$$$$$ /$$__  $$|  $$  /$$/$$__  $$| $$__  $$|_  $$_/  | $$  | $$ /$$__  $$/$$__  $$      | $$$$$$$/$$__  $$|_  $$_/   /$$__  $$| $$__  $$|_  $$_/  | $$ |____  $$| $$",
                    @"| $$__  $$| $$  | $$ \  $$/$$/ $$$$$$$$| $$  \ $$  | $$    | $$  | $$| $$  \__/ $$$$$$$$      | $$____/ $$  \ $$  | $$    | $$$$$$$$| $$  \ $$  | $$    | $$  /$$$$$$$| $$",
                    @"| $$  | $$| $$  | $$  \  $$$/| $$_____/| $$  | $$  | $$ /$$| $$  | $$| $$     | $$_____/      | $$    | $$  | $$  | $$ /$$| $$_____/| $$  | $$  | $$ /$$| $$ /$$__  $$| $$",
                    @"| $$  | $$|  $$$$$$$   \  $/ |  $$$$$$$| $$  | $$  |  $$$$/|  $$$$$$/| $$     |  $$$$$$$      | $$    |  $$$$$$/  |  $$$$/|  $$$$$$$| $$  | $$  |  $$$$/| $$|  $$$$$$$| $$",
                    @"|__/  |__/ \_______/    \_/   \_______/|__/  |__/   \___/   \______/ |__/      \_______/      |__/     \______/    \___/   \_______/|__/  |__/   \___/  |__/ \_______/|__/",
                    @"                                                                                                                                                                          ",
                };

                Console.WindowWidth = 180;
                Console.WriteLine("\n\n");
                foreach (string line in arr)
                    Console.WriteLine(line);


            }
            Console.Title = "Ad.Po Adventure Game";
            Console.WriteLine("You are now entering a nowhere space");
            Console.WriteLine("To progress the story Follow an prompts or press enter to continue the story");
          
        }
    }
    class Item { }
    class Program
    {

        static void Main()
        {
            Game.StartGame();

            string Cafefood; // Variables//
            string yesno;
            string CharacterName;

            Console.WriteLine("What is your Name");
            CharacterName = Console.ReadLine();
            Console.WriteLine("So your name is " + CharacterName);



            Console.WriteLine("You begin your Journey stood in the rain");
            Console.ReadKey(true);
            Console.WriteLine("Your character wanders into a small cafe, which never seems to be open...but today it is.");
            Console.ReadKey(true);
            Console.WriteLine("What to you want to eat?");
            Cafefood = Console.ReadLine();
            Console.WriteLine("Ok, one " + Cafefood + " coming up");
            Console.ReadKey(true);
            Console.WriteLine("A shadowy figure emerges towards you from a side door");
            Console.WriteLine("Which band do you want to see");
            Console.WriteLine("Disciples of Bounab or Sam && Hausage?");

            Console.WriteLine("Disciples of Bounab? y/n");
            yesno = Console.ReadLine();

            if (yesno == "y")
            {
                Console.WriteLine("The small crowd start to chant 'BOUNAB!!!!'");
                Console.ReadKey(true);
                Console.WriteLine("The Band appear on stage in a flash of lightining!");
                Console.ReadKey(true);
                Console.WriteLine("'this one is called Negative Turtle'");
                Console.ReadKey(true);
                Console.WriteLine("I'm cold....Blooded");
                Console.WriteLine("'My nest has been flooded'");
                Console.WriteLine("hi" + CharacterName + "what do you think of the band");




            }
            if (yesno == "n")
            {
                Console.WriteLine("Well, Sam && Hausage it is");
            }


















            Console.ReadKey();




        }

    }
}
