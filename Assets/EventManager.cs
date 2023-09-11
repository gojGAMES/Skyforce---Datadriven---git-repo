using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ValueChangedEvent(int value);

    public event ValueChangedEvent PlayerHealthChange;
    public event ValueChangedEvent ScoreChange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PublishHealthChange(int value)
    {
        PlayerHealthChange?.Invoke(value);
    }

    public void PublishScoreChangeEvent(int value)
    {
        ScoreChange?.Invoke(value);
    }
}
