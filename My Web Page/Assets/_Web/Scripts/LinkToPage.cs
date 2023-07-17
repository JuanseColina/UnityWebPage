using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class LinkToPage : MonoBehaviour
{
    public void LinkToPageMethod(string url)
    {
        Application.OpenURL(url);
        // an option to mail to me
    }

    [SerializeField] [CanBeNull] private GameObject backGroundWhite;
    
    public void BackGroundWhite(bool isEnter)
    {
        if (backGroundWhite != null) backGroundWhite.SetActive(isEnter);
    }
}
