using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//keep track of which phase the player is in
public enum GameState {  PlayerSelectNode, PlayerSelectAction, PlayerMoveUnit, PlayerAttackUnit, EnemyTurn, EnemyAttackUnit, GameOver };

public class GameMasterScript : MonoBehaviour
{
    public static GameMasterScript instance; //looks important

    public GameState currentState;

    public Material[] unitColours; //change colour of unit e.g. when selected by the cursor

    public GameObject cursor;

    public GameObject StartCanvas;
    public GameObject EndCanvas;
    public GameObject MainGameCanvas;

    public NodeController HoverNode = null;
    public NodeController SelectedNode = null;

    public int currentScore;
    public int currentTurn;
    public Text displayScoreText;
    public TMP_Text displayScore;
    public Text displayTurn;

    //make sure all other canvas are inActive
    private void Start()
    {
        StartCanvas.SetActive(true);
        EndCanvas.SetActive(false);
        MainGameCanvas.SetActive(false);

        // enemy starts first
        //if(GameState.EnemyTurn != null)
        currentState = GameState.EnemyTurn;

        /* // player starts first if enemy state returns null
         * else {
         *      currentState = GameState.PlayerSelectNode;
         * }
         */
    }

    //wait for the enemy to finish their turn before giving control the the player
    void EnemyTurnInProgress()
    {
        // code here
    }

    //keeps track of current turn and updates every turn
    public void AddTurn()
    {
        currentScore ++;
        displayTurn.text = currentScore.ToString();
    }

    //increase points method for destorying enemy units, new player turn, special points
    public void AddScore(int points)
    {
        currentScore += points;
        displayScoreText.text = currentScore.ToString();
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

    void Update()
    {
        switch (currentState)
        {
            case GameState.PlayerSelectNode:
                Debug.Log("case GameState.PlayerSelectNode");
                break;

            case GameState.PlayerSelectAction:
                Debug.Log("case GameState.PlayerSelectAction");
                break;

            case GameState.PlayerMoveUnit:
                Debug.Log("case GameState.PlayerMoveUnit");
                break;

            case GameState.PlayerAttackUnit:
                Debug.Log("case GameState.PlayerAttackUnit");
                break;

            case GameState.EnemyAttackUnit:
                Debug.Log("case GameState.EnemyAttackUnit");
                break;

            case GameState.EnemyTurn:
                Debug.Log("case GameState.EnemyTurn");
                break;

            case GameState.GameOver:
                Debug.Log("case GameState.GameOver");
                break;

            default:
                Debug.Log("default");
                break;
        }
    }
}
