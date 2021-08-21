using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCycleScript : MonoBehaviour
{
    
    public Animator animator;
    public float time;

    
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (time > 40f)
        {
            time = 0;}
        
        time += 0.01f;
        
        animator.SetFloat("time", time);
        
    }
}
