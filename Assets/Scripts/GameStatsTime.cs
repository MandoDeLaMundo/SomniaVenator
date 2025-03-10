using System;
using TMPro;
using UnityEngine;

public class GameStatsStarsStats : MonoBehaviour
{
    [SerializeField] private Stopwatch stopwatchScript;

    public TextMeshProUGUI totalTimeText;
    public float finalTime = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalTime = stopwatchScript.currentTime;
        TimeSpan time = TimeSpan.FromSeconds(finalTime);
        totalTimeText.text = "Time: " + time.ToString(@"mm\:ss\:fff");
    }
}
