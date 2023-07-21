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
        StartCoroutine(CircleLoop());
    }

    private IEnumerator CircleLoop()
    {
        foreach (var t in circles)
        {
            LeanTween.scale(t, Vector3.one * scale, time).setLoopPingPong();
            yield return new WaitForSeconds(.1f);
        }
    }
}
