using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLaserScript : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint;

    void Start() // Fixed capitalization
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, startPoint.position); // Set the starting position of the laser
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.right, out hit)) // Use -transform.right for leftward direction
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point); // Set the laser endpoint to the hit point
            }
            if (hit.transform.CompareTag("Player")) // Check if the hit object is tagged "Player"
            {
                SceneManager.LoadScene("Level1.1"); // Load a new scene if the player is hit
            }
        }
        else
        {
            lr.SetPosition(1, transform.position - transform.right * 5000); // Extend the laser far into the distance
        }
    }
}
