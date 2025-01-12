using UnityEngine;

public class BreakWalltoLeave2_1 : MonoBehaviour
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
        Destroy(Door, 1);
        Debug.Log("You finished 2.1");
    }
}
