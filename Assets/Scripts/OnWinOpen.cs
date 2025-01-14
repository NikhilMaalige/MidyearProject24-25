using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class OnWinOpen : MonoBehaviour
{

    public Canvas Canvas;
    [SerializeField] public TMP_Text display;
    public Stopwatch timer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer.dontDestroy();
        timer.pauseTimer(); 
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
