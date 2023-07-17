using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class LinkToPage : MonoBehaviour
{
    public void LinkToPageMethod(string url)
    {
        Application.OpenURL(url);
    }

    [SerializeField] [CanBeNull] private GameObject backGroundWhite;
    
    public void BackGroundWhite(bool isEnter)
    {
        if (backGroundWhite != null)
        {
            backGroundWhite.SetActive(isEnter);
        }
    }
}
