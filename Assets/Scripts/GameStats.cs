using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class GameStats : MonoBehaviour
{
    [SerializeField] private Stopwatch stopwatchScript;

    public int starsCollected;
    public TextMeshProUGUI starsCollectedText;
    public TextMeshProUGUI timeLapseText;

    // Update is called once per frame
    void Update()
    {
        starsCollectedText.text = "Stars collected: " + starsCollected.ToString();

        TimeSpan timeSpan = TimeSpan.FromSeconds(stopwatchScript.currentTime);
        TimeSpan time = timeSpan;
        timeLapseText.text = "Time: " + time.ToString(@"mm\:ss\:fff");
    }
}
