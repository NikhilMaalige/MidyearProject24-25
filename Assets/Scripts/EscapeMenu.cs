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
        Movement.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("escape")){
                SwitchScreen();                
        }


    }
    void SwitchScreen(){
        Canvas.enabled = !Canvas.enabled;
        if (Canvas.enabled){
            Movement.enabled = false; 
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;


        }
        else {
            Movement.enabled = true;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }
}
