using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.menu;
    public static GameManager instance;
    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas gameOverCanvas;
    public int collectedCoins = 0;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetButtonDown("s"))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        GameManager.instance.collectedCoins = 0;
        PlayerController.instance.StartGame();
        SetGameState(GameState.inGame);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }

    void SetGameState (GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            gameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver)
        {
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = true;
        }

        currentGameState = newGameState;
    }

    public void CollectedCoin()
    {
        collectedCoins++;
    }

}
