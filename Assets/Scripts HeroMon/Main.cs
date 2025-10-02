using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monsterPrefabs;
    public List<Monster> monsters = new List<Monster>();
    public List<Weapon> weaponPrefabs;
    
    
    void Start()
    {
        Weapon heroWeapon = Instantiate(weaponPrefabs[0], new Vector3(-3, -1, 0), Quaternion.identity);
        hero.Init("The Hulk",20,10);
        hero.ShowStat();
        
        //Instantiate weapons
        Weapon sword = Instantiate(weaponPrefabs[0], new Vector3(-3, -1, 0), Quaternion.identity);
        Weapon claws = Instantiate(weaponPrefabs[1], new Vector3(-1, -1, 0), Quaternion.identity);
        Weapon dagger = Instantiate(weaponPrefabs[2], new Vector3(1, -1, 0), Quaternion.identity);
        Weapon axe = Instantiate(weaponPrefabs[3], new Vector3(3, -1, 0), Quaternion.identity);

        //Initialize weapons
        sword.InitWeapon("Sword", 10);
        claws.InitWeapon("Claws", 30);
        dagger.InitWeapon("dagger", 5);
        axe.InitWeapon("axe", 10);
        
        //Spawn Mon from prefab
        Monster dragonObj = Instantiate(monsterPrefabs[0]);
        Dragon dragon1 = dragonObj.GetComponent<Dragon>();
        if (dragon1 != null)
        {
            dragon1.InitializeDragon("Gorash Dragon");
        }
        monsters.Add(dragon1);
        
        Monster goblinObj = Instantiate(monsterPrefabs[1]);
        Goblin goblin1 = goblinObj.GetComponent<Goblin>();
        if (goblin1 != null)
        {
            goblin1.InitializeGoblin("Smolderfang Goblin");
        }
        monsters.Add(goblin1);

        Monster orcObj = Instantiate(monsterPrefabs[2]);
        Orc orc1 = orcObj.GetComponent<Orc>();
        if (orc1 != null)
        {
            orc1.InitializeOrc("Grubnak Orc");
        }
        monsters.Add(orc1);

        foreach (var monster in monsters)
        {
            monster.ShowStats();
            monster.Roar();
        }

        foreach (var monster in monsters)
        {
            monster.Attack(hero);
        }
        
        //attack with weapons
        //all characters equip weapons
        Debug.Log("** Attack with Weapons -> bonus damage **");
        hero.EquipWeapon(sword);
        dragon1.EquipWeapon(claws);
        goblin1.EquipWeapon(dagger);
        orc1.EquipWeapon(axe);

        hero.Attack(dragon1, sword);
        dragon1.Attack(hero, claws);
        goblin1.Attack(hero, dagger);
        orc1.Attack(hero, axe);
        
        /*Debug.Log("---- Battle ----");
        foreach (Monster monster in monsterPrefabs)
        {
            hero.Attack(monster);
            hero.Attack(monster,10);
            monster.Attack(hero);
        }*/
    }

   
}
