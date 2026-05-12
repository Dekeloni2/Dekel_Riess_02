using System;

namespace Dekel_Riess_2;


// Represents an enemy that attacks the player using a bomb.
// Inherits shared behavior from the abstract Enemy class.
public class BombEnemy() : Enemy(50, 100)
{
    
    /* Constructor sets the bomb enemy's damage (50)
    and hit chance (100%) using the base class constructor.

    Performs the bomb attack on the player.
    Overrides the abstract Attack method from Enemy. */
    public override void Attack(Player player)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Try to Bomb Attack 💣 ");

        
        // Bomb attack always hits because hitChance = 100,
        // but we still use the shared AttackHits() method.
        if (AttackHits())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bomba Attack Succeed 💥 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            player.TakeDamage(damage); // Apply damage to the player
        }
        else
        {
            // Technically not possible with 100% hit chance,
            // but included for consistency.
            Console.WriteLine("Bomba Attack Missed");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------"); 
        }

        // Display updated player health
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Player Health is on ❤️" + player.GetHealth()); //Returns the current health of the player
        Console.WriteLine("--------------------");
        Console.ResetColor();
    }
}