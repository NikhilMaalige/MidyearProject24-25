using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLaserScript : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        // Set the starting position of the laser
        lr.SetPosition(0, startPoint.position);

        RaycastHit hit;

        // Adjust raycast and laser direction to point the other way
        if (Physics.Raycast(startPoint.position, startPoint.right, out hit)) 
        {
            // Set the laser endpoint to the hit point
            lr.SetPosition(1, hit.point);

            // Check if the hit object is tagged "Player"
            if (hit.transform.CompareTag("Player"))
            {
                // Reset to Level2.1
                SceneManager.LoadScene("Level2.1");
            }
        }
        else
        {
            // Extend the laser far in the other direction
            lr.SetPosition(1, startPoint.position + startPoint.right * 5000);
        }
    }
}
