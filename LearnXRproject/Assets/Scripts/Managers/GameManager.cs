using DilmerGames.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : Singleton<GameManager>
{
   public enum GameMode
    {
        Normal,
        Zombie,
        GameOver,
        Menu
    }

    public GameMode gameMode = GameMode.Normal;

    private float gameTimer = 0;

    [SerializeField]
    private float normalGameTimeMode = 30.0f;

    [SerializeField]
    private float zombieTimeMode = 10.0f;

    private void Update()
    {
        if(gameMode == GameMode.GameOver || gameMode == GameMode.Menu)
        {
            return;
        }

        gameTimer += Time.deltaTime * 1.0f;
        Debug.Log("At " + gameTimer + "game mode was " + gameMode);
        UIManager.Instance.UpdateTimer(gameTimer.ToString("0"));

        

        
        
            if(gameTimer >= normalGameTimeMode && gameTimer <= (normalGameTimeMode + zombieTimeMode))
            {
                gameMode = GameMode.Zombie;
            }

            if (gameTimer > (normalGameTimeMode + zombieTimeMode))
            {
                gameMode = GameMode.Normal;
                gameTimer = 0; 
            }
        
    }
}
