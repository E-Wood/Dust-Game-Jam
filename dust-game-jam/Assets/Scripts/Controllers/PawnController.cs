using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour
{
    private HashSet<GameObject> selectedObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToSelection(GameObject newSelection)
    {
        selectedObjects.Add(newSelection);
    }

    public void removeFromSelection(GameObject oldSelection)
    {
        selectedObjects.Remove(oldSelection);
    }
}
