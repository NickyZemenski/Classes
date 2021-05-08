using System;

namespace FunClasses
{

    class Barbarian
    {
        public string name;

        public string attactName;

        private int stamina;


        public void fight(string monster)
        {


            if (stamina > 0)
            {
                Console.WriteLine($"{name} uses {attactName} to attack {monster} ");
                stamina--;
            }
            else
            {
                Console.WriteLine($"{name} is to exhausted to attack maybe some REST is needed");
            }
           
        }

       


        public Barbarian(string _name, string _attackName)
        {
            name = _name;
            attactName = _attackName;
            stamina = 10;


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

     
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("what is your fight move");
            string attack = Console.ReadLine();

            Barbarian barbarian = new Barbarian(name, attack);

            string[] monsters = { "Dragon", "Goblin", "Bandit","Harpy" ,"Wolf", "Rabbit", "Wild Boar" };
            int randomMonster = rd.Next(0, 6);

            
            string monster = monsters[randomMonster];


            Console.WriteLine($"{barbarian.name} encounters a {monster}");

            barbarian.fight(monster);
           



        }
    }
}
