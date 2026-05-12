using System;
using System.Text;
using Dekel_Riess_2;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Player player = new Player(100);

        MeleeEnemy melee = new MeleeEnemy();
        RangedEnemy range = new RangedEnemy();
        BombEnemy bomb = new BombEnemy();

        melee.Attack(player);
        range.Attack(player);
        bomb.Attack(player);

        Console.ReadLine();
    }
}