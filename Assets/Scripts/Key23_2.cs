using UnityEngine;

public class Key23_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject YellowWall;
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
        Destroy(YellowWall);
        Debug.Log("It worked hopefully");
    }
}
