using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject PawnOne;
    public GameObject PawnTwo;
    public GameObject PawnThree;
    public GameObject PawnFour;
    public GameObject shrine;
    
    // resources to keep track of state - your code is perfect the way it is <3
    public int bone = 0;
    public int stone = 0;
    public int iron = 0;
    public int thaumite = 0;
    public int food = 100;
    public int water = 100;

    public Text boneText;
    public Text stoneText;
    public Text ironText;
    public Text thauText;
    public Text timeText;

    public void incrementBone()
    {
        bone++;
        boneText.text = "Bone: " + bone;
    }
    
    public void incrementStone()
    {
        stone++;
        stoneText.text = "Stone: " + stone;
    }
    
    public void incrementIron()
    {
        iron++;
        ironText.text = "Iron: " + iron;
    }
    
    public void incrementThau()
    {
        thaumite++;
        thauText.text = "Thaumite: " + thaumite;
    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shrine, new Vector3(0, -1.5f, 0), Quaternion.identity);
        Instantiate(PawnOne, new Vector3(-4, -1, 0), Quaternion.identity);
        Instantiate(PawnTwo, new Vector3(-2, -1, 0), Quaternion.identity);
        Instantiate(PawnThree, new Vector3(2, -1, 0), Quaternion.identity);
        Instantiate(PawnFour, new Vector3(4, -1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float realTime = Time.time;
        int timeOfDay = (int) ((Math.Floor(realTime) + 240) / 60) % 24; //start time at 4am (240 seconds)
        timeText.text = "Time: " + timeOfDay;
    }
}
