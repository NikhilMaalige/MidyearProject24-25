using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jump : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource falling;

    // void OnCollisionEnter()
    // {
    //     audioSource.PlayOneShot(falling, 0.7F);
    // }
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))         
        {                 
            falling.Play();                 
            // hasPlayedJump = true;         
        } 
        // else hasPlayedJump = false;
    }
}