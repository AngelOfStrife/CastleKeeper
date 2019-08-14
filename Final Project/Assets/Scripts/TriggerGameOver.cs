using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    public GameMasterScript gameMaster;

    private void OnTriggerEnter2D()
    {
        gameMaster.EndGame();
    }
}
