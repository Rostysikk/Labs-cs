using System;

class Player
{
    public event Action<int, int> OnDamageTaken;

    public int HP { get; private set; }

    public Player(int hp)
    {
        HP = hp;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0) HP = 0;

        Console.WriteLine($"\n[Player] Received {damage} damage");

        OnDamageTaken?.Invoke(damage, HP);
    }
}