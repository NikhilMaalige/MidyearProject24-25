using UnityEngine;

public class Key33_2 : MonoBehaviour
{
    public GameObject RedWall;
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
        Debug.Log("It worked hopefully");
    }
}
