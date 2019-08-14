using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public GameObject gameOverWall;
    //public GameMasterScript gameMaster;

    int hitPoint;

    private void Awake()
    {
        hitPoint = 1;
    }
    
    void FixedUpdate()
    {
        //check if the enemy has any hitpoints, if not destory the gameObject
        if (hitPoint <= 0)
        {
            Died();
        }
    }

    /*
     * 
    //Trigger condition
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == gameOverWall.name)
        {
            //game over, player loses
            gameMaster.EndGame();
        }
    }

    */

    void Died()
    {
        Destroy(this.gameObject);
    }
}
