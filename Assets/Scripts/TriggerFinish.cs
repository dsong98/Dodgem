using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{
    public GameManager gameManager;

    // Set to invisible right at the start
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerEnter() {
        gameManager.levelComplete();
    }
}
