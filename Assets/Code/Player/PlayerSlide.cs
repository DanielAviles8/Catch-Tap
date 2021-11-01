using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerSlide : MonoBehaviour
{
    public GameObject Player;
    public UnityEvent OnPrepare;
    public bool Active
    {
        get{ return active; }
        set{ active = value; } 
    }
    Keyboard keyboard;
    CharacterController characterController;

    private bool active;
    void Prepare()
    {
        #if UNITY_STANDALONE_WIN || UNITY_EDITOR
        keyboard = Keyboard.current;
        #endif
        characterController = GetComponent<CharacterController>();
        active = true;
        if (OnPrepare != null)
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
        if (active)
        {
            if(keyboard != null)
            {
                CheckInputKeyBoard();
            }
        } 
    }
    void CheckInputKeyBoard()
    {
        Vector3 distance = Player.transform.position;
        print(distance);
        if (keyboard.dKey.isPressed)
        {
             Player.transform.Translate(0.05f, 0, 0);
        }
        if (keyboard.aKey.isPressed)
        {
                Player.transform.Translate(-0.05f, 0, 0);
        }
    }
}
