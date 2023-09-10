using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuHandler : MonoBehaviour
{
    public Button StartGameButton;
    
    // Start is called before the first frame update
    void Start()
    {
        if (StartGameButton == null)
        {
            throw new MissingComponentException("No start button found; loading main scene");
            SceneManager.LoadScene(0);
        }
        StartGameButton.onClick.AddListener(OnStartClick);
    }

    void OnStartClick()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
