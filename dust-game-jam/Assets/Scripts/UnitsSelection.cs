using System.Collections.Generic;
using UnityEngine;

public class UnitsSelection : MonoBehaviour
{
    public PawnController pawnController;

    private bool _isDraggingMouseBox = false;
    private Vector3 _dragStartPosition;
    Ray _ray;
    RaycastHit _raycastHit;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isDraggingMouseBox = true;
            _dragStartPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
            _isDraggingMouseBox = false;
        
        if (_isDraggingMouseBox && _dragStartPosition != Input.mousePosition)
            _SelectUnitsInDraggingBox();
        
        if (pawnController.getSelectedCount() > 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                _DeselectAllUnits();
            if (Input.GetMouseButtonDown(0))
            {
                _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(
                    _ray,
                    out _raycastHit,
                    1000f
                ))
                {
                    if (!_raycastHit.transform.CompareTag("Unit"))
                        _DeselectAllUnits();
                }
            }
        }
    }
    
    private void _DeselectAllUnits()
    {
        GameObject[] selectableUnits = GameObject.FindGameObjectsWithTag("Unit");
        foreach (GameObject unit in selectableUnits)
        {
            iPawn unitController = unit.GetComponent<iPawn>();
            unitController.deselect();
        }
    }
    
    private void _SelectUnitsInDraggingBox()
    {
        Bounds selectionBounds = Utils.GetViewportBounds(
            Camera.main,
            _dragStartPosition,
            Input.mousePosition
        );
        GameObject[] selectableUnits = GameObject.FindGameObjectsWithTag("Unit");
        bool inBounds;
        foreach (GameObject unit in selectableUnits)
        {
            
            inBounds = selectionBounds.Contains(
                Camera.main.WorldToViewportPoint(unit.transform.position)
            );
            iPawn unitController = unit.GetComponent<iPawn>();
            if (inBounds)
                unitController.select();
            else
                unitController.deselect();
        }
    }

    void OnGUI()
    {
        if (_isDraggingMouseBox)
        {
            // Create a rect from both mouse positions
            var rect = Utils.GetScreenRect(_dragStartPosition, Input.mousePosition);
            Utils.DrawScreenRect(rect, new Color(1f, 1f, 0.4f, 0.2f));
            Utils.DrawScreenRectBorder(rect, 1, new Color(1f, 1f, 0.4f));
        }
    }

}
