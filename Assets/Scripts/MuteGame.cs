using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MuteGame : MonoBehaviour
{

    bool volumeOn = true; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mute(){
        if (volumeOn){
            AudioListener.volume = 0; 
            volumeOn = false;
        }
        else {
            AudioListener.volume = 1;
            volumeOn = true;
        }
        
    }
}
