using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public List<EnemyWave> Waves;
    public float TimeBeforeFirstWave;
    private int waveCounter = 1;
    private float timeForNextWave;
    // Start is called before the first frame update
    void Start()
    {
        timeForNextWave = Time.time + TimeBeforeFirstWave;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeForNextWave)
        {
            SummonWave();
        }
    }

    void SummonWave()
    {
        if (waveCounter >= Waves.Count)
        {
            this.enabled = false;
            return;
        }
        Instantiate(Waves[waveCounter-1], Vector3.zero, Quaternion.identity);
        timeForNextWave = Time.time + Waves[waveCounter].Duration;
        waveCounter++;
    }
}
