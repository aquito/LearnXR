using DilmerGames.Core; 
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    public void SetScore(int scoreValue)
    {
        scoreText.text = $"SCORE: {scoreValue}";
    }

   
}
