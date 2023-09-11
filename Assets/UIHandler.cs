using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Text ScoreText;
    public EventManager EventManager;
    public Image Vignette;

    public int VignetteDamageThreshold;
    
    // Start is called before the first frame update
    void Start()
    {
        EventManager.PlayerHealthChange += OnPlayerDamaged;
        EventManager.ScoreChange += UpdateScoreText;
    }

    public void UpdateScoreText(int newScore)
    {
        ScoreText.text = "Score: " + newScore;
    }

    void OnPlayerDamaged(int newHealth)
    {
        if (newHealth <= VignetteDamageThreshold)
        {
            if (!Vignette.gameObject.activeSelf)
            {
                Vignette.gameObject.SetActive((true));
            }
        }
    }
}
