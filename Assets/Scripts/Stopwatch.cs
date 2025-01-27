using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Stopwatch : MonoBehaviour
{

    public Canvas Canvas;
    [SerializeField] public TMP_Text display;
    [SerializeField] public static float currentTime;

    [SerializeField] public TMP_Text fastestTime;

    public bool pause = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause){
            currentTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(currentTime/60);
            int seconds = Mathf.FloorToInt(currentTime%60);
            int milliseconds = Mathf.FloorToInt((currentTime*1000f)%1000f);

            display.text = string.Format("{0:D2}:{1:D2}.{2:D3}" , minutes, seconds, milliseconds);
        }

    }

    public void pauseTimer(){
        pause = true;
    }
    public void resumeTimer(){
        pause = false;
    }

    public static Stopwatch instance;
    public void dontDestroy(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(display);
            DontDestroyOnLoad(Canvas);
        }
        else {
            Destroy(display);
            Destroy(Canvas);
        }
        
    }

     

}
