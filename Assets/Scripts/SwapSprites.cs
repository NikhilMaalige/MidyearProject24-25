using UnityEngine;
using UnityEngine.UI;

public class SwapSprites : MonoBehaviour
{

    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Image button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change(){
        if (button.sprite == sprites[0]){
            button.sprite = sprites[1];
            return;
        }
        button.sprite = sprites[0];
    }
}
