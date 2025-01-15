using UnityEngine;

public class audioManager : MonoBehaviour
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
}
