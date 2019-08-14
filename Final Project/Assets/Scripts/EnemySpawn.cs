using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnObject;
    public bool spawnable; //check if spawn area is avaliable, do not stack spawnObjects

    private void Awake()
    {
        spawnable = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnable)
        {
            Instantiate(spawnObject, spawnPos.position, spawnPos.rotation);
        }
    }
}
