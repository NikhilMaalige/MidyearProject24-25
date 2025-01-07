using UnityEngine;

public class Level2_1StartDestroy : MonoBehaviour
{
    public GameObject button;
    public GameObject blocker;

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

        if (oo == button)
        {
            if (blocker != null)
            {
                Destroy(blocker, 1);
            }
            Debug.Log("success");
        }
        else
        {
            Debug.Log("other interaction");
        }
    }
}
