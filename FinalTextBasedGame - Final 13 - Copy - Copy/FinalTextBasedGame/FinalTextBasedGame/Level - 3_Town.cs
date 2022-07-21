using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG
{
    internal class Level_Town
    {
        public static void startOfLevel()
        {
            Console.Clear();
            Console.WriteLine("As you stumble around streets of the town you notice there is not a soul to be seen outside.");
            Console.WriteLine("Walking past the windows of the townhouses and shops you see that there are indeed people inside.");
            Console.WriteLine("What would be keeping them indoors?");
            Console.WriteLine("You hear a piercing shriek coming from the sky, such that you are forced to remove your helm. Falling to the ground, you struggle to steady yourself");
            Console.WriteLine("The earth shakes, stones and dust rasied into the air. You look up and see a knight dismounting a fell beast");
            Encounters.firstBossBattle();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The champion takes a knee, his beast slain. As the champion looks you in the eyes you sence  dark dread overcome you" +
                "Blood now pouring from his mouth, you barely hear him as he struggles to speak. 'Worthy' he says.");
            Console.WriteLine("You cleave his head in two");
            Console.WriteLine("The village elders come out of the house first");
            Program.currentPlayer.health += 10;
            Program.currentPlayer.weaponValue += 1;
            Program.currentPlayer.armour += 1;
            Program.currentPlayer.potions += 3;
            Program.currentPlayer.gold += 200;




        }
}
