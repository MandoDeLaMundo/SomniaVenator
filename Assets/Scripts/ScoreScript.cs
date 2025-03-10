using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int scoreCounter;
    public TextMeshProUGUI currentScore;
    [SerializeField] private Collectible checkStar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkStar.starDestroyed)
        {
            scoreCounter++;
        }

        currentScore.text = "Score: " + scoreCounter.ToString();
    }
}
