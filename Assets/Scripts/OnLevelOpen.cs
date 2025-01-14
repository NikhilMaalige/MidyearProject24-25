using UnityEngine;

public class OnLevelOpen : MonoBehaviour
{
public PlayerController Movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Movement.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
