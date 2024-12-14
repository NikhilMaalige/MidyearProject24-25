using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButtonScript : MonoBehaviour
{
    public GameObject button;
    public GameObject testingButton;
    public Camera otherViewportCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsOtherViewportActive())
        {
            if (button == GetClickedObject(out RaycastHit hit))
            {
                if (testingButton != null)
                {
                    Destroy(testingButton);
                    Debug.Log("Button clicked");
                }
            }
        }
    }

    GameObject GetClickedObject(out RaycastHit hit)
    {
        hit = default;
        GameObject target = null;

        var ray = otherViewportCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == button)
            {
                target = hit.collider.gameObject;
            }
        }
        return target;
    }

    private bool IsOtherViewportActive()
    {
        return otherViewportCamera.enabled;
    }
}
