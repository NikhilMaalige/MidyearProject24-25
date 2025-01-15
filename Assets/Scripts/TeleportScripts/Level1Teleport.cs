using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Teleport : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stopwatch.currentTime = 0;
        Time.timeScale = 1;
       
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
            case 2:
                SceneManager.LoadScene("Level1.2");
                break;
            default:
                SceneManager.LoadScene("Level1.1");
                break;
        }
    }

}
