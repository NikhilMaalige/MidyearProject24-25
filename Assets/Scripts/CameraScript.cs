using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject RegularViewport;
    public GameObject OtherViewport;


    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            RegularViewportToggle();
        }

        if (Input.GetKeyDown("2"))
        {
            OtherViewportToggle();
        }
    }

    void RegularViewportToggle()
    {
        RegularViewport.SetActive(true);
        OtherViewport.SetActive(false);
    }

    void OtherViewportToggle()
    {
        OtherViewport.SetActive(true);
        RegularViewport.SetActive(false);  
    }
}