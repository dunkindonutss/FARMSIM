using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Animal> allAnimals = new List<Animal>();

    void Start()
    {
        Cow cow = new GameObject("Cow").AddComponent<Cow>();
        cow.Init("MissCow", FoodType.Hay);

        Chicken chicken = new GameObject("Chicken").AddComponent<Chicken>();
        chicken.Init("Kfc", FoodType.Grain);

        Horse horse = new GameObject("Horse").AddComponent<Horse>();
        horse.Init("Lubu", FoodType.Carrot);

        allAnimals.Add(cow);
        allAnimals.Add(chicken);
        allAnimals.Add(horse);
        
        //กินอาหารเน่า
        chicken.Feed(FoodType.RottenFood,10);
        //ทดสอบ encap
        cow.AdjustHappiness(150);
        

        Debug.Log("=== Farm Status ===");
        foreach (var animal in allAnimals)
        {
            animal.GetStatus();
            animal.MakeSound();
            //feed แบบ 1
            animal.Feed(5);
            //feed แบบ 2 
            animal.Feed(animal is Cow ? FoodType.Hay : FoodType.Grain, 20);
            Debug.Log(animal.Produce());
        }
    }
}