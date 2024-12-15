using UnityEngine;
using System.Collections;
using System.Collections.Generic; 


public class TeleportScript : MonoBehaviour
{
    public GameObject Player; 
    public GameObject TpLoc1;
    public GameObject TpLoc2;  
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

        int tpNum = Random.Range(1,3); 
        string tpStr = tpNum.ToString();

        switch(tpNum)
        {
            case 1:
            Player.transform.position = TpLoc1.transform.position; 
            Debug.Log("Teleporter 1");
            break;

            case 2:
            Debug.Log("Teleporter 2");
            Player.transform.position = TpLoc2.transform.position; 
            break;

            default:
            Player.transform.position = TeleportTo.transform.position; 
            break;
            
        }
        
    }



}
