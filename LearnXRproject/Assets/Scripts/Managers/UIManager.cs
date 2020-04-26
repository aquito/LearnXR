using DilmerGames.Core; 
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private TextMeshProUGUI timerText;

    public void SetScore(int scoreValue)
    {
        scoreText.text = $"SCORE: {scoreValue}";
    }

    public void UpdateTimer(string timerValue)
    {
        timerText.text = $"TIMER: {timerValue}";
    }

}
