using System;
using System.Text;
using Dekel_Riess_2;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Player player = new Player(100);

        IEnemy melee = new MeleeEnemy();
        IEnemy range = new RangedEnemy();
        IEnemy bomb = new BombEnemy();

        melee.Attack(player);
        range.Attack(player);
        bomb.Attack(player);

        Console.ReadLine();
    }
}
