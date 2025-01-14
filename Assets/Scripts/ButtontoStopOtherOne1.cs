using UnityEngine;

public class ButtontoStopOtherOne1 : MonoBehaviour
{

    public GameObject Waypoint1;
    public GameObject Waypoint2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider o)
    {
        Destroy(Waypoint1);
        Destroy(Waypoint2);
    }
}
