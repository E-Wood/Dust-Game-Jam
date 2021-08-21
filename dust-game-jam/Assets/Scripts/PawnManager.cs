using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour
{
    public Pawn _pawn;
    public Transform Idlers;
    void Start()
    {
        GameObject col1 = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, Idlers);
        GameObject col2 = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, Idlers);
        GameObject col3 = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, Idlers);
        GameObject col4 = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, Idlers);
    }
    
    private bool _hovered = false;

    private void OnMouseEnter()
    {
        _hovered = true;
    }

    private void OnMouseExit()
    {
        _hovered = false;
    }

    private void Update()
    {
        if (_hovered && Input.GetMouseButtonDown(0) && IsActive())
            Select(true);
    }

    public void Select() { Select(false); }
    public void Select(bool clearSelection)
    {
        if (Globals.SELECTED_UNITS.Contains(this)) return;
        if (clearSelection)
        {
            List<PawnManager> selectedUnits = new List<PawnManager>(Globals.SELECTED_UNITS);
            foreach (PawnManager um in selectedUnits)
                um.Deselect();
        }
        Globals.SELECTED_UNITS.Add(this);
        Debug.Log(Globals.SELECTED_UNITS.Count);
    }

    public void Deselect()
    {
        if (!Globals.SELECTED_UNITS.Contains(this)) return;
        Globals.SELECTED_UNITS.Remove(this);
    }

    protected virtual bool IsActive()
    {
        return true;
    }
}
    

