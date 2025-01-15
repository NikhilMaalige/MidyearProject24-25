using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jump : MonoBehaviour
{
    public AudioClip falling;
    public AudioSource idk;

    void OnCollisionEnter()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            falling = idk.clip;             
            idk.Play();   
        }
    }

    // void Update() 
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))         
    //     {    
    //         falling = idk.clip;             
    //         idk.Play();    
    //     } 
    // }

    // public void JumpSound() {
    //     falling = idk.clip;
    //     idk.Play();
    // }
}