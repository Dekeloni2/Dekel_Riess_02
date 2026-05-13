using System;

namespace Dekel_Riess_2;


// Abstract base class for all enemy types.
// Contains shared fields and logic that all enemies use.
public abstract class Enemy
{
    // The amount of damage the enemy will deal
    protected int damage;
    
    // The chance that the enemy's attack will hit the player
    protected int hitChance;

    // Constructor that sets the enemy's damage and hit chance.
    public Enemy(int damage, int hitChance)
    {
        this.damage = damage;
        this.hitChance = hitChance;
    }

    public abstract void Attack(Player player);
    
    
    // Determines whether the attack hits based on the enemy's hitChance.
    // Returns true if the attack succeeds.
    protected bool AttackHits()
    {
        Random random = new Random();
        int roll = random.Next(0, 100);
        return roll <= hitChance;
    }
}