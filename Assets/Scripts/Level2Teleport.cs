using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // if (other.tag == "Player")
        // {
            SceneManager.LoadScene("Level2.1");
        // }
    }
}
