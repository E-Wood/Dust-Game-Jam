using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour
{
    public HashSet<GameObject> selectedObjects = new HashSet<GameObject>();

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
        if (selectedObjects.Contains(oldSelection))
        {
            selectedObjects.Remove(oldSelection);
        }
    }
}
