using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnJump = new UnityEvent();

    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;  //if w is pressed, go up
            Debug.Log("Up");
       }
       if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;    //if S is pressed, go down
            Debug.Log("Down");
       }
       if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;    //if A is pressed, go left
            Debug.Log("Left");
       }
       if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;   //if D is pressed, go right
            Debug.Log("Right");
       }

        OnMove?.Invoke(inputVector);

        if (Input.GetKeyDown(KeyCode.Space)){
          Debug.Log("Spacebar");
          OnJump?.Invoke();
        }
    }
}
