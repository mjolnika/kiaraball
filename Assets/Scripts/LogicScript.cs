using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
   // public BallScript ball;
    //public bool isWon;
    public GameObject gameWinScreen;
    public Rigidbody2D myRigidbody;
    public string sceneName;

    public void gameWon()
    {
        gameWinScreen.SetActive(true);
    }   
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void startRolling() => myRigidbody.WakeUp();
}
