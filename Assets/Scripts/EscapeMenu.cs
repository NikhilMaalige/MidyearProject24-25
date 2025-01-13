using UnityEngine;
using System.Collections;


public class EscapeMenu : MonoBehaviour
{

    public PlayerController Movement; 

    public Canvas Canvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas.enabled = !Canvas.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("escape")){
                switchScreen();                
        }


    }
    void switchScreen(){
        Canvas.enabled = !Canvas.enabled;
        if (Canvas.enabled){
            Movement.enabled = false; 
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }
        else {
            Movement.enabled = true;
            Cursor.visible = false;
        }
    }
}
