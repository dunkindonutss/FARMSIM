using UnityEngine;

public class Dragon : Monster
{
    public override int LootReward => 50;

    public override void Roar()
    {
        Debug.Log($"DRAGON {name} ROAR SCARE ALL OF THE CREATURE AROUND");
    }

    public void InitializeDragon(string name)
    {
        base.Init(name,100,20);
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} with Fire Breath for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        int finalDamage = AttackPower += bonusDamage;
        target.TakeDamage(finalDamage);
        Debug.Log($"{Name} attacks {target.Name} with Ultra Fire Breath for {finalDamage} damage!");
    }
}
