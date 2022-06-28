using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    private enum KeyBinding
    {
                            //default
        W,                  //W
        A,                  //A
        S,                  //S
        D,                  //D
        Run,                //LShift
        
    }

    [SerializeField] private UnityEvent RunEvent;
    //[SerializeField] private Dictionary<KeyBinding, string> keyDictionary;     //각 바인딩에 맞는 키 이름들
    [SerializeField] private Dictionary<KeyBinding, KeyCode> keyDictionary;     //각 바인딩에 맞는 키 이름들

    private void Awake()
    {
        keyDictionary = new Dictionary<KeyBinding, KeyCode>();
    }

    private void Start()
    {
        keyDictionary.Add(KeyBinding.Run, KeyCode.LeftShift);
    }

    private void Update()
    {
        InputEvent();
    }

    private void InputEvent()
    {
        Run();
    }

    private void Run()
    {
        if (Input.GetKeyDown(keyDictionary[KeyBinding.Run]))
        {
            RunEvent?.Invoke();
        }
        else if (Input.GetKeyUp(keyDictionary[KeyBinding.Run]))
        {
            RunEvent?.Invoke();
        }
    }
}
