using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButtonScript : MonoBehaviour
{
    public GameObject button;
    public GameObject testingButton;

 
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (button == GetClickedObject(out RaycastHit hit))
            {
                print("Button clicked!");
                if (testingButton != null)
                {
                    Destroy(testingButton);
                }
            }
        }
    }

    GameObject GetClickedObject(out RaycastHit hit)
    {
        hit = default;

        GameObject target = null;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (!isPointerOverUIObject())
            {
                if (hit.collider.gameObject == button)
                {
                    target = hit.collider.gameObject;
                }
            }
        }
        return target;
    }

    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current)
        {
            position = new Vector2(Input.mousePosition.x, Input.mousePosition.y)
        };

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(ped, results);
        return results.Count > 0;
    }
}
