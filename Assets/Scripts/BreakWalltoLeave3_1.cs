using UnityEngine;

public class BreakWalltoLeave3_1 : MonoBehaviour
{
    public GameObject Door;
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
        Destroy(Door);
        Debug.Log("You finished 3.1");
    }
}
