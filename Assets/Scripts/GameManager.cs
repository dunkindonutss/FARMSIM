using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Chicken chicken_Tommy = new Chicken("Tommy", 10, 10, 5);
        Cow cow_Jeep = new Cow("Jeep", 15, 8, 2);
        
        //Tommy
        chicken_Tommy.AdjustHunger(5);
        chicken_Tommy.AdjustHappiness(10);
        chicken_Tommy.MakeSound();
        chicken_Tommy.Feed("Grain");
        chicken_Tommy.GetStatus();
        chicken_Tommy.Sleep();
        
        //Jeep
        cow_Jeep.AdjustHunger(30);
        cow_Jeep.AdjustHappiness(13);
        cow_Jeep.MakeSound();
        cow_Jeep.Feed("Hay");
        cow_Jeep.GetStatus();
        cow_Jeep.Sleep();
    }
    
}
