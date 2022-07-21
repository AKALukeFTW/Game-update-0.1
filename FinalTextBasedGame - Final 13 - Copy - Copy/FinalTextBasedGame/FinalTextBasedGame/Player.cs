using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG
{
    // don't really need to make any changes here yet, might decide to make some classes later
    public class Player
    {
        public string name;
        public int gold = 0;
        public int health = 10;
        //is the below variable  the damage that the player takes from enemies??
        public int damage = 1;
        public int armour = 0;
        public int potions = 3;
        public int weaponValue = 1;
    }


    public class PlayerClass
    {



        //=====what I need below=====//
        //  1) I need to create an attack mechanic that allows the enemy to either choose to attack, to defend based upon what the user choosen
        //      a) it will essentially conver the game into a turn-based rpg
        //  2) I need to find a way for the enemies to either scale, or manually create them and base them within certain levels and have those levels
        //     set to a certain difficulty
        //  3) I need to find a way to create a class system, I have found a way to increase armor value, I only need to do this to the weapon value



        public static void ChooseClass()
        {
            Console.Clear();
            Console.WriteLine(  "Choose your class"  );
            Console.WriteLine("======================");
            Console.WriteLine("|      (K)night      |");
            Console.WriteLine("|  (M)age  (R)anger  |");
            Console.WriteLine("======================");
            string input = Console.ReadLine().ToLower();
            

            if (input == "k")
            {
                //actually works!
                //knight class = more damage, more armor value
                int armourBuff = 1;
                float weaponBufff = 3f;
                int weaponBuff = (int)weaponBufff;
                Program.currentPlayer.armour += armourBuff;
                //idk if I need this line lol - 'Program.currentPlayer.weaponValue += weaponBuff;
                Console.WriteLine("You have chosen the Knight class");
               Console.ReadKey();
             
            }

            else if (input == "m")
            {
                int healthBoon = 25;
                float weaponNerff = 0.75f;
                int weaponNerf = (int)weaponNerff;
                Program.currentPlayer.health += healthBoon;
                Program.currentPlayer.weaponValue -= weaponNerf;
                Console.WriteLine("You have chosen the Mage class");
                Console.ReadKey();
                //more health but less damage

            }
            
            else if (input == "r")
            {
                int potionBoon = 2;
                float weaponBufff = 2f;
                int weaponBuff = (int)weaponBufff;
                Program.currentPlayer.potions += potionBoon;
                Program.currentPlayer.weaponValue += weaponBuff;
                Console.WriteLine("You have chosen the Ranger class");
                Console.ReadKey();
                //more damage, potions

            }

            

        }


    }


}