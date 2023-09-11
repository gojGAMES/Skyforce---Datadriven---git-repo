using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float ScreenWidth = 20;
    public static float ScreenHeight = 9;

    public GameObject GameOverScreen;

    public EventManager EventManager;

    private int Score;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void UpdateScore(int scoreDelta)
    {
        Score += scoreDelta;
        EventManager.PublishScoreChangeEvent(Score);
    }
}
