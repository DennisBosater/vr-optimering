using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFish : MonoBehaviour
{
    public AudioSource eatFish;
    public int fishValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UICollectableFish.instance.ChangeScore(fishValue);
            eatFish.Play();
            Destroy(gameObject);
        }
    }

}