﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG
{
    internal class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic Methods


        //the below is the code for the RANDOM FIGHT ENCOUNTERS - REST OF THE CODE IS AT THE BOTTOM OF THE FILE.
        /*------public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("As you make your way down the corridor, you turn and see...");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }------*/



        //BELOW IS THE GENERIC CODE FOR AN ENCOUNTER
        /*--------public static void abcdefg()
        {
            Console.WriteLine("-------");
            Combat(false, "-----", 0, 0);
            Console.WriteLine("-------");
            Console.ReadKey();
        }---------*/


        //Encounters
        public static void FirstEncounter_Wretched_Soul()
        {
            string n = "Wretched Soul";
            Console.WriteLine("You charge toward the masked figure. As you push them into the call you hear a loud crack");
            Console.WriteLine("You step back and see their shattered skull pertruding out of their hood. They slowley raise their head to look at you - they begin to charge...");
            Console.ReadKey();
            Combat(false, "Wretched Soul", 1, 3);
            Console.Clear();
        }


        //Level_1_ Interior_Dungeon 
        //---------------//
        //- escape from the dungeon encounter 1

        public static void SecondEnounter_Guard_2()
        {
            string n = "Guard";
            Console.WriteLine("The guard outside swings open the door, the stench of their rotten flesh makes your eyes water. You stand and brace yourself for the struggle to come.");
            Console.WriteLine("Sluggishly swaying to and fro, you think that the guard has not noticed you, yet as you take a step back they raise their lumbering head and look you dead in the eyes. They charge...");
            Console.ReadKey();
            Combat(false, "Guard", 1, 4);
            Console.Clear();
            Console.WriteLine("You disarm the guard, slicing their hands of with one swift strike of your blade. A key appears on the ground");
            Console.WriteLine("You open the door and hear the faint sobbing of the lost souls endomned in their cells. Their fates yet to be decided...");
            Console.ReadKey();
        }

        //encounter  - go through the door
        public static void GoThroughTheDoor()
        {
            string n = "Double Headed Ogre Guards";
            Combat(false, "Double Headed Ogre Guards", 2, 6);
            Console.WriteLine("Your mace caves in both heads, bone, brain and blood splattering all over your robes.");
            Console.ReadKey();
            
        }


        //Level_2_Dungeon_Exterior
        //---------------//

        //- escape from the dungeon encounter 2
        public static void ThirdEncounter_Jailmaster()
        {
            string n = "Jail Master";
            Console.WriteLine("You we're lucky to escape from your cell. With no weapon in hand you hastely move to grab a piece of broken brick. With what begins as a slow pace" +
                "the guard quickens their step...they are now charging towards you at full pace");
            Console.ReadKey();
            Combat(false, "Jail Master", 2, 4);
            Console.Clear();
            Console.WriteLine("You tackle the Guard. While they are stunnded you manage to get a grip of their helmet. You rip off their head and proceed to bash their brains out.");
            Console.WriteLine("You struggle to realise what you have just done. But there is no time. You grab the guard's weapon and must now choose your next path.");
            Console.ReadKey();
        }

        public static void mainDoorGuard()
        {
            string n = "Castle Guard";
            Console.ReadKey();
            Combat(false, "Castle Guard", 3, 6);
            Console.Clear();
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.ReadKey();
        }

        public static void wallGuardArcher()
        
        {
            string n = "Archer"; 
            Console.ReadKey();
            Combat(false, "Archer", 1, 4);
            Console.Clear();
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.ReadKey();
        }

        public static void Troll()
        {
            Console.Clear();
            Console.WriteLine("You now face a troll");
            Console.ReadKey();
            Combat(false, "Troll", 3, 15);
            Console.WriteLine("The Troll is now Dead");
            Console.ReadKey();
        }


        //Level_3_Town

        public static void firstBossBattle()
        {
            Console.Clear();
            Combat(false, "Fell Beast Champion", 5, 20);
        }





        /*Encounter tools
        //I dont think I want random encounters - will make a copy of the file and delete this and see if I can't make a script
        
        public static void randomEncounter()
        {
            switch (rand.Next(0, 1))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    SecondEnounter_Ogre();
                    break;
            }
        }*/

        //combat code below
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();
                p = rand.Next(1, 5);
                h = rand.Next(1, 5);

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("======================");
                Console.WriteLine("| (A)ttack  (D)efend |");
                Console.WriteLine("|   (R)un   (H)eal   |");
                Console.WriteLine("                       ");
                Console.WriteLine("Current weapon value = " + Program.currentPlayer.weaponValue);
                Console.WriteLine("Current armour value = " + Program.currentPlayer.armour);
                Console.WriteLine("Current Gold = " + Program.currentPlayer.gold);
                Console.WriteLine("======================");
                Console.WriteLine("Potions: " + Program.currentPlayer.potions + "  Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack" || input.ToLower() == "A")
                {
                    //attack
                    Console.WriteLine("You grip you sword fast and charge swiftly towards your foe! As you attack, the " + n + " manages to parry and lands a light blow at your flank.");
                    int damage = p - Program.currentPlayer.armour;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You loose " + damage + "  health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend" || input.ToLower() == "D")
                {
                    //defend
                    Console.WriteLine("The enemy storms towards you. As they draw closer you see them ready their weapon overhead.");
                    int damage = (p / 4) - Program.currentPlayer.armour;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You loose " + damage + "  health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "r" || input.ToLower() == "run" || input.ToLower() == "R")
                {
                    //run
                    if (rand.Next(0, 2) == 0)
                    {
                        //failed escape
                        Console.WriteLine("Your foe strikes you in your back with their weapon as you attempt to flea");
                        int damage = p - Program.currentPlayer.armour;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You loose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        //successfull escape
                        Console.WriteLine("You barely manage to escape the " + n + " as you brush past them");
                        Console.ReadKey();
                        Shop.goToShop();
                        //go to store
                    }

                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal" || input.ToLower() == "H")
                {
                    //heal
                    if (Program.currentPlayer.potions == 0)
                    {
                        //failed head - no potions
                        Console.WriteLine("You are not carrying any potions, you cannot heal.");
                        int damage = p - Program.currentPlayer.armour;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("As you are searching your pouch for potions, the " + n + "strikes you and you loose " + damage + "health");
                    }
                    else
                    {
                        //successfull heal
                        Console.WriteLine("You drink from the glowing flaggon you have pulled out of your pouch");
                        int potionValue = 10;
                        Console.WriteLine("You gain " + potionValue + " health");
                        Program.currentPlayer.health += potionValue;
                        Program.currentPlayer.potions -= 1;
                        Console.WriteLine("As you were occupied, the " + n + " advances, attempting to strikes you. You are able to block most of the damage");
                        int damage = (p / 2) - Program.currentPlayer.armour;
                        if (damage < 0)
                            damage = 0;
                    }
                    Console.ReadKey();
                }
                if (Program.currentPlayer.health <= 0)
                {
                    //death code
                    Console.WriteLine("As" + n + "weapon slices open your stomach you fall to your knees and see your innards spilled over the ground. A white light envolvpes you and you Die.");
                    Console.ReadKey();
                    System.Environment.Exit(0);

                }
                Console.ReadKey();
            }
            //defeated the enemy code
            int c = rand.Next(45, 100);
            Console.WriteLine("As you stand victorious over the " + n + " it's body disolves into " + c + " gold coins");
            Program.currentPlayer.gold += c;
            Console.ReadKey();

        }

        //random encounters enemy names code below
        public static string GetName()
        {
            switch (rand.Next(0, 6))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Human Rogue";
                case 2:
                    return "Gaul";
                case 3:
                    return "Cultist";
                case 4:
                    return "Fallen Knight";
                case 5:
                    return "Deamon spawn";
                case 6:
                    return "Ogre";
            }
            return "Human Rogue";
        }

    }
}