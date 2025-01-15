
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2.0f;
    private float jumpHeight = 5.0f;
    private bool isOnGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed); 
    }
    public void JumpBall(){
        if (isOnGround){
            sphereRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isOnGround = false;
        }
        else
            return;
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        }
    }
}
