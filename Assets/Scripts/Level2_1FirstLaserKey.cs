using UnityEngine;

public class Level2_1FirstLaserKey : MonoBehaviour
{
    public GameObject Laser1;
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
        Destroy(Laser1);
        Debug.Log("It worked hopefully");
    }
}