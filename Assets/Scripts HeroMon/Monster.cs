using UnityEngine;


public abstract class Monster : Character
{
    public abstract int LootReward { get; }

    public abstract void Roar();

    public void DropReward(Hero hero)
    {
        hero.EarnGold(LootReward);
    }

    public void ShowStats()
    {
        Debug.Log($"Monster {Name} Is Alive : {IsAlive()},HP : {Health},ATK : {AttackPower},Loot : {LootReward}");
    }


}
