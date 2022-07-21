using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG
{


    //FIXES
     // 1) when selecting any other value than 1, 2, 3 need to ensure the game doesn't stop - but rather allows you to choose again
     // 2) combat system where the opponent attacks you, and you can choose to defend.


    public class Shop
    {

        /*this is the method that returns the player back to the game. Perhaps you cannot run to the store, but rather you can go to the store at the end of each encounter
        and only once, or else the player could become too OP too soon.
        public static void playerRetrunToLevel()
        {

        }*/

        
        
        
        public static void goToShop()
        {
            int weaponBuff = 1;
            int armourBuff = 1;
            int healthBuff = 20;
            int potionbuff = 1;

            //  1) so what I need to do is to make add add the int to the player class values, so that the player class values increase
            //  2) the hard part will be the increase in player difficulty and and increase in enemy attack
            //     - - - hmmm, the above doesnt really need to occure, as the encounters and enemies are manually created for specfic levels, so there dont need to be increased.

            Console.Clear();
            Console.WriteLine("================SHOP================");
            Console.WriteLine("==Choose from the many items below==");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  (W)eapon Buff  = $75 Gold         ");
            Console.WriteLine("  (A)rmor Buff   = $75 Gold         ");
            Console.WriteLine("  (H)ealth Buff  = $50 Gold         ");
            Console.WriteLine("  (P)otions      = $25 Gold         ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Current Gold = " + Program.currentPlayer.gold);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("====================================");

            string input = Console.ReadLine().ToLower();

            //weapon buff
            if (input == "w")
            {
                if (Program.currentPlayer.gold > 75)
                {
                    Console.WriteLine("You have purpased a weapon buff, your weapon value has increased from" + Program.currentPlayer.weaponValue + "to" + Program.currentPlayer.weaponValue + 01);
                    Program.currentPlayer.gold -= 75;
                    Program.currentPlayer.weaponValue += weaponBuff;
                }
                else if (Program.currentPlayer.gold < 75)
                {
                    Console.WriteLine("You do not have enough gold to purchase this enhancement");
                }
                //need to create a mainloop that keeps the player in the shop


            }

            //armour buff
            else if (input == "a")
            {
                if (Program.currentPlayer.gold > 75)
                {
                    Console.WriteLine("You have purpased an armour buff, your armour value has increased from" + Program.currentPlayer.armour + "to" + Program.currentPlayer.armour + 01);
                    //Console.Writeline("Your armour value has increased one level) - much easier, but I want to figure out the above problem
                    Program.currentPlayer.gold -= 75;
                    Program.currentPlayer.armour += armourBuff;
                }
                else if (Program.currentPlayer.gold < 75)
                {
                    Console.WriteLine("You do not have enough gold to purchase this enhancement");
                }
            }


            //health buff
            else if (input == "h")
            {
                if (Program.currentPlayer.gold > 50)
                {
                    Console.WriteLine("You have purpased a health buff, your health has increased by 20 points");
                    Program.currentPlayer.gold -= 50;
                    Program.currentPlayer.health += healthBuff;
                }
                else if (Program.currentPlayer.gold < 50)
                {
                    Console.WriteLine("You do not have enough gold to purchase this enhancement");
                }
            }

            //buy potions
            else if (input == "p")
            {
                if (Program.currentPlayer.gold > 25)
                {
                    Console.WriteLine("You have purpased a potion buff, your potions have increased from" + Program.currentPlayer.potions + "to" + Program.currentPlayer.potions + 01);
                    Program.currentPlayer.gold -= 25;
                    Program.currentPlayer.health += potionbuff;
                }
                else if (Program.currentPlayer.gold < 25)
                {
                    Console.WriteLine("You do not have enough gold to purchase this enhancement");
                }

            }



        }


    }
}
