using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICollectables : MonoBehaviour
{
    public static UICollectables instance;
    public TextMeshProUGUI text;
    int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int scoreValue)
    {
        score += scoreValue;
        text.text = score.ToString() + "/6";
    }
}