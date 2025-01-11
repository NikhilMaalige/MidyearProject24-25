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
        lr.SetPosition(0, startPoint.position);

        RaycastHit hit;

        if (Physics.Raycast(startPoint.position, startPoint.right, out hit)) 
        {
            lr.SetPosition(1, hit.point);

            if (hit.transform.CompareTag("Player"))
            {
                SceneManager.LoadScene("Level2.1");
            }
        }
        else
        {
            lr.SetPosition(1, startPoint.position + startPoint.right * 5000);
        }
    }
}
