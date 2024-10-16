using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private UIDocument _document;

    private Button _startBtn;
    private Button _optionBtn;
    private Button _exitBtn;
    private List<Button> _buttons;
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startBtn = _document.rootVisualElement.Q<Button>("Start");
        _startBtn.RegisterCallback<NavigationSubmitEvent>(OnStartBtn);
        _optionBtn = _document.rootVisualElement.Q<Button>("Options");
        _optionBtn.RegisterCallback<NavigationSubmitEvent>(OnOptionBtn);
        _exitBtn = _document.rootVisualElement.Q<Button>("Exit");
        _exitBtn.RegisterCallback<NavigationSubmitEvent>(OnExitBtn);

        _buttons = new List<Button>
        {
            _startBtn,
            _optionBtn,
            _exitBtn
        };

        _buttons[0].Focus();
    }

    private void OnExitBtn(NavigationSubmitEvent evt)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void OnOptionBtn(NavigationSubmitEvent evt)
    {
        throw new NotImplementedException();
    }

    private void OnStartBtn(NavigationSubmitEvent evt)
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        Focusable focusable = _document.rootVisualElement.focusController.focusedElement;
        Debug.Log(focusable);
    }

    public void OnNavSubmit(InputAction.CallbackContext evt)
    {
        
        //throw new NotImplementedException();
    }

    public void OnNavMove(InputAction.CallbackContext context)
    {
        //float yVal = context.ReadValue<Vector2>().y;

        //if(yVal > 0)
        //{
        //    index--;
        //}
        //else if(yVal < 0)
        //{
        //    index++;
        //}

        //index = Mathf.Clamp(index, 0, _buttons.Count - 1);

        //_buttons[index].Focus();
    }

    private void OnNavCancel(NavigationCancelEvent evt)
    {
        //throw new NotImplementedException();
    }
}
