using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Needs : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    private float _depletionRate;
    
    public bool active;
    // Start is called before the first frame update

    private void Awake()
    {
        _depletionRate = 0.01f;
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        slider.value -= _depletionRate;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        
    }

    public void AddHealth(int health)
    {
        if (slider.value + health > 100)
        {
            slider.value = 100;}
        else
        {
            slider.value += health;
        }
    }

    public void setDepletionRate(float rate) //used for sandstorm
    {
        _depletionRate = rate;
    }
}
