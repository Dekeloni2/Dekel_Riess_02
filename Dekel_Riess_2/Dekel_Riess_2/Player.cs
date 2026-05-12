namespace Dekel_Riess_2;

public class Player
{
    
    //Player's current health value
    private int _health;
    
    // Constructor that sets the player's starting health
    public Player(int health)
    {
        this._health = health;
    }

    // A function to take damage from enemies
    // Ensures that if the player happens to fall below 0,
    // it will be 0 instead of a negative number
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
            _health = 0;
    }
    
    // Simple function to return the current player's health.
    public int GetHealth()
    {
        return _health;
    }
}