using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Cow missCow;
    [SerializeField] private Chicken kfc;
    [SerializeField] private Horse lubu;
    private string gameName = "FARM SIM";
    [SerializeField] private List<Animal> allAnimalInFarm = new List<Animal>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //init
        missCow = FindFirstObjectByType<Cow>();
        missCow.Init("MissCow",20,15);
        kfc = FindFirstObjectByType<Chicken>();
        kfc.Init("Kfc",25,18);
        lubu = FindFirstObjectByType<Horse>();
        lubu.Init("Lubu",30,12);
        
        AddAnimalInFarmToList();
        Debug.Log($"WELCOME TO {gameName}, Now You has : {GetNumberOfAnimalsInFarm()} Animals.");
        ShowAllAnimalStatInFarm();
        
        foreach (var animal in allAnimalInFarm)
        {
            animal.MakeSound();
            animal.Feed(15);
        }
        
    }

    public void AddAnimalInFarmToList()
    {
        Animal[] animalsInScene = FindObjectsOfType<Animal>();

        for (int i = 0; i < animalsInScene.Length; i++)
        {
            allAnimalInFarm.Add(animalsInScene[i]);
        }
    }

    public void ShowAllAnimalStatInFarm()
    {
        foreach (var animal in allAnimalInFarm)
        {
            animal.GetStatus();
        }
    }

    public int GetNumberOfAnimalsInFarm()
    {
        return allAnimalInFarm.Count;
    }
    
}
