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
        int tpNum = Random.Range(1, 3);

        switch (tpNum)
        {
            case 3:
                SceneManager.LoadScene("Level2.1");
                break;
            case 2:
                SceneManager.LoadScene("Level2.2");
                break;
            default:
                SceneManager.LoadScene("Level2.3");
                break;
        }
    }
}
