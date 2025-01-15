
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 inputVector = Vector2.zero; //initializing input vector

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

       Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
       sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

       Debug.Log("Resultant Vector: " + inputVector);
       Debug.Log("Resultant 3D Vector: " + inputVector);
    }
}
