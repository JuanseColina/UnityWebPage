using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CircleController : MonoBehaviour
{
    [SerializeField] private GameObject[] circles;
    [SerializeField] private float time, scale;

    private void Start()
    {
        CircleLoop();
    }

    private void CircleLoop()
    {
        foreach (var t in circles)
        {
            LeanTween.scale(t, Vector3.one * scale, Random.Range(time / 1.5f, time)).setLoopPingPong();
        }
    }
}
