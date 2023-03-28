using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteShark : MonoBehaviour
{
    public GameObject Shark;

    void OnTriggerEnter(Collider other)
    
    {
        if (other.tag == "Player")
        {
            Shark.SetActive(true);
        }
    }
}
