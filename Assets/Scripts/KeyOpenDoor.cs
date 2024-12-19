using UnityEngine;

public class KeyOpenDoor : MonoBehaviour
{

    public GameObject Key;
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
        GameObject oo = o.gameObject;

        if (oo == Key)
        {
            if (Door != null)
            {
                Destroy(Door, 1);
            }
            Debug.Log("success");
        }
        else
        {
            Debug.Log("other interaction");
        }
    }
}
