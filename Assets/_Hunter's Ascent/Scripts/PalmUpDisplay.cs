using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;

public class PalmUpDisplay : MonoBehaviour
{
    [SerializeField] private GameObject hud;
    private Grabber _grabber;

    void Start()
    {
        _grabber = GetComponentInChildren<Grabber>();
    }

    void Update()
    {
        var rotation = transform.rotation.eulerAngles;

        var xrange = rotation.x > -10f && rotation.x < 10f;
        var zrange = rotation.z > 80f && rotation.z < 100f;

        if (xrange && zrange && !_grabber.HoldingItem)
        {
            hud.SetActive(true);
        }
        else
        {
            hud.SetActive(false);
        }
    }
}