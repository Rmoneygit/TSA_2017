using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWallColor : MonoBehaviour {

    public GameObject wall;

    public void OnTriggerEnter()
    {
        wall.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnTriggerExit()
    {
        wall.GetComponent<Renderer>().material.color = Color.white;
    }

}
