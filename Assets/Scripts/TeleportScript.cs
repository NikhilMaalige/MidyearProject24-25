using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class TeleportScript : MonoBehaviour
{
    public GameObject Player; 
    public GameObject TeleportTo; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider o){
        Player.transform.position = TeleportTo.transform.position; 
    }



}
