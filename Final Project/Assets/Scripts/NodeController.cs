using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{

    public GameObject lane01;
    public GameObject lane02;
    public GameObject lane03;

    public GameObject[] Lane01;
    public GameObject[] Lane02;
    public GameObject[] Lane03;

    // Start is called before the first frame update
    void Start()
    {
        //make the lanes
        Lane01 = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Lane01[i] = transform.GetChild(i).gameObject;
        }

        Lane02 = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Lane02[i] = transform.GetChild(i).gameObject;
        }

        Lane03 = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Lane03[i] = transform.GetChild(i).gameObject;
        }

    }

}
