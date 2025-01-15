using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jump : MonoBehaviour
{
    public AudioClip falling;
    public AudioSource idk;

    // void OnCollisionEnter()
    // {
    //     audioSource.PlayOneShot(falling, 0.7F);
    // }
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))         
        {    
            falling = idk.clip;             
            idk.Play();      
            // hasPlayedJump = true;         
        } 
        // else hasPlayedJump = false;
    }
}