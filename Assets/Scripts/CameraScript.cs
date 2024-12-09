using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject RegularViewport;
    public GameObject OtherViewport;

    public int toggle = 1;

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (toggle == 1) 
            {
                OtherViewportToggle();
                toggle++; 
            }
            else 
            {
                RegularViewportToggle(); 
                toggle--;  
            }
            
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