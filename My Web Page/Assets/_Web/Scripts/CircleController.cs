using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    [SerializeField] private GameObject[] circles;
    [SerializeField] private float time, scale;

    private void Start()
    {
        for (int i = 0; i < circles.Length; i++)
        {
            LeanTween.scale(circles[i], Vector3.one * scale, time).setLoopPingPong();
        }
    }
}