namespace Dekel_Riess_2;


// This interface defines the required behavior for all enemy types.
// Any class that represents an enemy must implement the Attack method.
public interface IEnemy
{
    // Method that performs an attack on the player.
    // Each enemy has a different attacking method.
    void Attack(Player player);
}