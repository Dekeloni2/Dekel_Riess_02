using System;

namespace Dekel_Riess_2;

// Represents an enemy that attacks the player using his bare hands.
// Inherits shared behavior from the abstract Enemy class.
public class RangedEnemy : Enemy
{
    /* Constructor sets the ranged enemy's damage (5)
    and hit chance (50%) using the base class constructor.

    Performs the "ranged" attack on the player.
    Overrides the abstract Attack method from Enemy. */
    public RangedEnemy() : base(5, 50)
    {
        
    }

    public override void Attack(Player player)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Try to Ranged Attack 🏹 ");

        if (AttackHits())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ranged Attack Succeed ☴🏹✅ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            player.TakeDamage(damage); // Apply damage to the player
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ranged Attack Missed ☴🏹❌ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("Player Health is on ❤️" + player.GetHealth());
        Console.WriteLine("--------------------");
        Console.ResetColor();
    }
}