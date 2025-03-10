using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class GameStats : MonoBehaviour
{
    [SerializeField] private Stopwatch stopwatchScript;

    public TextMeshProUGUI starsCollectedText;
    public TextMeshProUGUI timeLapseText;

    // Update is called once per frame
    void Update()
    {


        if (stopwatchScript != null && timeLapseText != null)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(stopwatchScript.currentTime);
            TimeSpan time = timeSpan;
            timeLapseText.text = "Time: " + time.ToString(@"mm\:ss\:fff");
        }

    }
}
