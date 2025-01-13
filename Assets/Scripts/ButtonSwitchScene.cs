using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonSwitchScene : MonoBehaviour
{

    public PlayerController Movement;
    public Canvas Canvas;

    // public GameObject switchTo; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void onClick(){
    //     SceneManager.LoadScene(switchTo.scene.name);

    // }

    public void quit(){
        Application.Quit();
    }

    public void toMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void toOptions(){
        SceneManager.LoadScene("OptionsMenu");
    }
    public void closeCanvas(){
        Canvas.enabled = !Canvas.enabled; 
        Movement.enabled = true;
        Cursor.visible = false;
    }
    

}
