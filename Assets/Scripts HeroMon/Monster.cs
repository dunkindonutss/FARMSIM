using UnityEngine;

public enum MonsterType
{
    Dragon,
    Goblin,
    Orc
}
public class Monster : Character
{
    public int LootGold;
    private bool defeated = false;
    public MonsterType monsterType { get;private set; }

    public void DropReward(int amount)
    {
        
    }

    public void Init(MonsterType monsType)
    {
        monsterType = monsType;
        switch (monsType)
        {
            case MonsterType.Goblin:
                base.Init("Goblin",40,8);
                LootGold = 5;
                break;
            case MonsterType.Orc:
                base.Init("Orc", 60, 12);
                LootGold = 10;
                break;
            case MonsterType.Dragon:
                base.Init("Dragon", 100, 20);
                LootGold = 50;
                break;
        }
    }
    
    public override void Attack(Character target)
    {
        Attack(target);
        Debug.Log($"Monster {Name} Bite {target.Name} for {AttackPower} Dmg !");
    }
    
    public override void Attack(Character target, int bonusDamage)
    {
        int damage = AttackPower + bonusDamage;
        target.TakeDamage(damage);
        Debug.Log($"Monster {Name} SuperBite {target.Name} for {damage} Dmg !");
    }
}
