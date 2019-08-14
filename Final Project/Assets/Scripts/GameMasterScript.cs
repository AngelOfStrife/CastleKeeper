using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScript : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject EndCanvas;
    public GameObject MainGameCanvas;

    public int currentScore;
    public TMPro.TMP_Text displayScore;

    //make sure all other canvas are inActive
    private void Start()
    {
        StartCanvas.SetActive(true);
        EndCanvas.SetActive(false);
        MainGameCanvas.SetActive(false);
    }

    public void AddScore(int points)
    {
        currentScore += points;
        displayScore.text = currentScore.ToString();
    }

    public void EndGame() {
        EndCanvas.SetActive(true);
    }

    public void ResetGame()
    {
        currentScore = 0;
        MainGameCanvas.SetActive(false);
    }
}
