using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICollectableFish : MonoBehaviour
{
    public static UICollectableFish instance;
    public TextMeshProUGUI text;
    int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int fishValue)
    {
        score += fishValue;
        text.text = score.ToString() + "/6";
    }
}