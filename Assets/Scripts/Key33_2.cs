using UnityEngine;

public class Key33_2 : MonoBehaviour
{
    public GameObject RedWall;
    public GameObject Floor;
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
        Destroy(RedWall);
        Destroy(Floor);
        Debug.Log("It worked hopefully");
    }
}
