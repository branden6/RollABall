using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;  //if w is pressed, go up
       }
       if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;    //if S is pressed, go down
       }
       if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;    //if A is pressed, go left
       }
       if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;   //if D is pressed, go right
       }

        OnMove?.Invoke(inputVector);
    }
}
