using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelComplete : MonoBehaviour
{
    public GameObject TextLevelComplete;
        
    void OnTriggerEnter(Collider other)
    
    {
        if (other.tag == "Player")
        {
            TextLevelComplete.SetActive(true);
        }
    }
}
