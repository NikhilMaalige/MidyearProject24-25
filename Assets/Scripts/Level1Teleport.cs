using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void startRandomLevel()
    {
        int tpNum = Random.Range(1, 3);

        switch (tpNum)
        {
            case 1:
                SceneManager.LoadScene("Level1.1");
                break;
            case 2:
                SceneManager.LoadScene("Level1.1");
                break;
            default:
                SceneManager.LoadScene("Level1.1");
                break;
        }
    }

}
