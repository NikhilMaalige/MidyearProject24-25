// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CameraScript : MonoBehaviour
// {

//     public GameObject RegularViewport;
//     public GameObject OtherViewport;

//     public int toggle = 1;

//     void Update()
//     {
//         if (Input.GetKeyDown("e"))
//         {
//             if (toggle == 1) 
//             {
//                 OtherViewportToggle();
//                 toggle++; 
//             }
//             else 
//             {
//                 RegularViewportToggle(); 
//                 toggle--;  
//             }
            
//         }
//     }

//     void RegularViewportToggle()
//     {
//         RegularViewport.SetActive(true);
//         OtherViewport.SetActive(false);
//     }

//     void OtherViewportToggle()
//     {

//         OtherViewport.SetActive(true);
//         RegularViewport.SetActive(false);
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject RegularViewport;
    public GameObject OtherViewport;

    public int toggle = 1;

    // A boolean to track if movement is enabled
    public bool isMovementEnabled = true;

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

        if (isMovementEnabled)
        {
            HandleMovement(); // Call a method to handle movement
        }
    }

    void RegularViewportToggle()
    {
        RegularViewport.SetActive(true);
        OtherViewport.SetActive(false);
        isMovementEnabled = true; // Re-enable movement
    }

    void OtherViewportToggle()
    {
        OtherViewport.SetActive(true);
        RegularViewport.SetActive(false);
        isMovementEnabled = false; // Disable movement
    }

    // Method to handle player movement
    void HandleMovement()
    {
        // Example movement code (replace this with your actual movement logic)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(moveX, 0, moveZ) * Time.deltaTime * 5f);
    }
}
