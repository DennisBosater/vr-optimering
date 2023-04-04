using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTriggers : MonoBehaviour
{
    public GameObject Tutorial;

    void OnTriggerEnter(Collider other)
    
    {
        if (other.tag == "Player")
        {
            Tutorial.SetActive(true);
        }
    }
}
