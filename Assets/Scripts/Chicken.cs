using UnityEngine;

public class Chicken : Animal
{
    private int egg;
    public int Egg { get { return egg; } set { egg = value; } }
    
    public override void MakeSound()
    {
        Debug.Log("Katak Katak !!");
    }
    
    public override void GetStatus()
    {
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}, Egg : {Egg}");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is Sleeping");
        AdjustHunger(10);
        AdjustHappiness(10);
        GetStatus();
    }
}
