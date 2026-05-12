using System;
using Dekel_Riess_2;

// Represents an enemy that attacks the player using his bare hands.
// Inherits shared behavior from the abstract Enemy class.
public class MeleeEnemy : Enemy
{
    /* Constructor sets the bomb enemy's damage (20)
    and hit chance (20%) using the base class constructor.

    Performs the "melee" attack on the player.
    Overrides the abstract Attack method from Enemy. */
    public MeleeEnemy() : base(20, 20) { }

    public override void Attack(Player player)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Try to Melee Attack ☴🤜");

        
        // Melee attack has a chance to miss since it is 20%,
        if (AttackHits())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Melee Attack Succeed ☴🤜✅ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            player.TakeDamage(damage);  // Apply damage to the player
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Melee Attack Missed ☴🤜❌ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Player Health is on ❤️" + player.GetHealth()); //Returns the current health of the player
        Console.WriteLine("--------------------");
        Console.ResetColor();
    }
}