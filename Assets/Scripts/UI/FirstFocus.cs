using UnityEngine;
using UnityEngine.UIElements;

public class FirstFocus : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FocusFirstElement();
    }

    public void FocusFirstElement()
    {
        GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Start").Focus();
    }
}
