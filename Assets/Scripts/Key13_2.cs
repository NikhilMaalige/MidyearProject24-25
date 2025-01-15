using UnityEngine;

public class Key13_2 : MonoBehaviour
{
    public GameObject GreenWall;
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
        Destroy(GreenWall);
        Debug.Log("It worked hopefully");
    }
}
