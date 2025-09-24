using UnityEngine;

public class Cow : Animal
{
    private int milk;
    public int Milk { get { return milk; } set { milk = value; } }
    
    public override void MakeSound()
    {
        Debug.Log("Moo Mooo !!");
        AdjustHappiness(10);
        GetStatus();
    }
    
    public override void GetStatus()
    {
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}, Milk : {Milk}");
    }
    
}
