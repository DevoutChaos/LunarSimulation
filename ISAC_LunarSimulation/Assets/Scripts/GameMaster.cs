﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMaster : MonoBehaviour
{

    //Declarations
    
    
    [Header("Explicitly gained and used")]
    [Header("Resources")]
    public float food;
    
    [Header("Gain and use both passive and explicit")]
    public float water;
    
    [Header("Passviely gained and used")]
    public float oxygen;

    [Header("Passviely gained and used")]
    public float electricity;

    [Header("UI TextBoxes")]
    public Text foodText;
    public Text waterText;
    public Text electricityText;
    public Text oxygenText;

    // Use this for initialization
    void Start()
    {
        food = 20;
        water = 47;
        electricity = 01;
        oxygen = 3;
    }

    // Update is called once per frame
    void Update()
    {
        foodText.text = Mathf.Floor(food).ToString();
        waterText.text = Mathf.Floor(water).ToString();
        electricityText.text = Mathf.Floor(electricity).ToString();
        oxygenText.text = Mathf.Floor(oxygen).ToString();
    }

    void incrementFood(float number)
    {
        food += number;
    }

    void incrementElectricity()
    {
        electricity++;
    }

    void incrementOxygen()
    {
        oxygen++;
    }

    void incrementWater()
    {
        water++;
    }

    void decrementFood()
    {
        food--;
    }

    void decrementElectricity()
    {
        electricity--;
    }

    void decrementOxygen()
    {
        oxygen--;
    }

    void decrementWater()
    {
        water--;
    }
}
