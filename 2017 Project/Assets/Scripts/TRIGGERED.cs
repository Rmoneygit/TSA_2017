using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIGGERED : MonoBehaviour {

    public void OnTriggerEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnTriggerExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
