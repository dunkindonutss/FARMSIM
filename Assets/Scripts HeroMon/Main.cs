using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monsterPrefabs;

    public Monster currentMonster;
    public List<Monster> monsters = new List<Monster>();
    
    void Start()
    {
        hero.Init("The Hulk",20,10);
        hero.ShowStat();
        
        SpawnMonster(MonsterType.Dragon);
        SpawnMonster(MonsterType.Goblin);
        SpawnMonster(MonsterType.Orc);
        
        Debug.Log("---- Battle ----");
        foreach (Monster monster in monsterPrefabs)
        {
            hero.Attack(monster);
            hero.Attack(monster,10);
            monster.Attack(hero);
        }
    }

    public void SpawnMonster(MonsterType monType)
    {
        Monster monsterPrefab = monsterPrefabs[(int)monType];
        Monster monsterObj = Instantiate(monsterPrefab);
        
        monsterObj.Init(monType);
        monsters.Add(monsterObj);
    }
}
