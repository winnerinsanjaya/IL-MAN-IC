using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            winScreen.SetActive(true);
        }
    }
}
