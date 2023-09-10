using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler : MonoBehaviour
{
    public Button MainMenuButton;
    
    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton.onClick.AddListener(OnMainMenuButton);
    }

    void OnMainMenuButton()
    {
        SceneManager.LoadScene(1);
    }
}
