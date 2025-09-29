using UnityEngine;

public class Chicken : Animal
{
    private int Eggs { get; set; }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Katak Katak!");
    }

    public override string Produce()
    {
        if (Happiness < 50) Eggs = 0;
        else if (Happiness <= 60) Eggs = 2;
        else Eggs = 3;

        return $"{Name} produced {Eggs} eggs.";
    }
}