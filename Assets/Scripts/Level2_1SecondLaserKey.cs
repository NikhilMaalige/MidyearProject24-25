using UnityEngine;

public class Level2_1SecondLaserKey : MonoBehaviour
{
    public GameObject Laser2;
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
        Destroy(Laser2);
        Debug.Log("It worked hopefully");
    }
}
