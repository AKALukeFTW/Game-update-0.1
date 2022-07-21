using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG
{
    internal class Dungeon_Exterior
    {

        public static void Next_Level_Dungeon_Exterior()
        {
            PlayerClass.ChooseClass();
            Console.Clear();
            Console.WriteLine("You travel along the exterior of the dungeon, the towering wall looming menecingly overhead, banners fluttering in the strong mountain winds.");
            Console.WriteLine("You can either (1) make your way towards the main gate, that you notice is only guarded by one guard. This path, however, could make you are" +
                "a target of any archers that might be waiting on the wall, or (2) make your way towards the steps, taking you to the top of the wall, providing you with a vantage over the grounds" +
                "and likely allowing you to deal with any archers that might impeed your escape.");

            string input = Console.ReadLine();

            //make you way towards the gate
            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("You make your way to the main gate slowly, taking care not to be seen by the sole guard at the gate, and any archers that might be stationed at the wall.");
                Console.WriteLine("You take cover behind what looks like a supply wagon, ");
                Encounters.mainDoorGuard();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You slay the guard and rush towards the door. You try with all your might to lift the wooden board fastening the gate shut. Your feet slip in the mud and you fall flat on your face.");
                Console.WriteLine("Perhaps there is another way out. You head into what looks like another guards quarters");
                Console.WriteLine("You see an open window. As you make your way towards the exit you hear a loud voice shout 'Hey, you there! You turn to face another twin-ogre");
                Encounters.GoThroughTheDoor();
                Level_Town.startOfLevel();
                

            }

            //make your way towards the steps - takes you to the top of the wall
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("You make your way past a supply wagon and duck up the stairs to the wall. You look over the side and see a muddy moat and slauthered soldiers on the field surrounding the castle.");
                Console.WriteLine("Hey you! You turn around and see an archer facing you, an arrow knotched and bow at the ready.");
                Encounters.wallGuardArcher();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You see a low lying rooftop just below the wall. You notice noone else around, and decide to take this chance to slip out over the dungeon walls.");
                Level_Town.startOfLevel();
            }


        }







    }
}
