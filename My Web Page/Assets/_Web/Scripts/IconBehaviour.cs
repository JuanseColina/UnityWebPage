using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconBehaviour : MonoBehaviour
{
    [SerializeField] private float scale ;
    public void Tweening(bool isEnter)
    {
        if (isEnter)
        {
            LeanTween.scale(gameObject, Vector3.one * scale, 0.2f); 
        }
        else
        {
            LeanTween.scale(gameObject, Vector3.one, 0.2f); 
        }
    }
}
