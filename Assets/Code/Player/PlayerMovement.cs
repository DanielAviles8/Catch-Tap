using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public UnityEvent OnPrepare;
    public bool Active
    {
        get{return active;}
        set{active = value;}
    }

    Keyboard keyboard;
    CharacterController characterController;

    private bool active;
    public Vector3 rotationDirection;


    void Prepare()
    {
        #if UNITY_STANDALONE_WIN || UNITY_EDITOR
        keyboard = Keyboard.current;
        #endif
        characterController = GetComponent<CharacterController>();
            active = true;
            if(OnPrepare != null)
            {
                OnPrepare.Invoke();
            }
    }

    public void Start()
    {
        Prepare();
    }

    void Update()
    {
        if(active)
        {
            if(keyboard != null)
            {
                CheckInputKeyBoard();
            }
        }
    }

    void CheckInputKeyBoard()
    {
        if(keyboard.dKey.wasPressedThisFrame)
        {
            Player.transform.rotation = Player.transform.rotation * Quaternion.AngleAxis(90f, rotationDirection);
            print("derecha");
        }
        if(keyboard.aKey.wasPressedThisFrame)
        {
            Player.transform.rotation = Player.transform.rotation * Quaternion.AngleAxis(90f, rotationDirection);
            print("izquierda");
        }
    }
}