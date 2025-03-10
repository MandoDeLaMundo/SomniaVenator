using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    //Vector3 moveDir;
    public Vector3 moveDir;
    Vector3 jumpVec;
    public float Speed;
    public float JumpForce;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveDir.Normalize();
        rb.MovePosition(transform.position + moveDir * Speed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();

        if (context.performed) {
            moveDir.x = input.x;
            moveDir.z = input.y;
        }
        else moveDir = Vector3.zero;
    }
    public void Jump(InputAction.CallbackContext context)
    {
        jumpVec = new Vector3(0f, 1f, 0f);
        rb.AddForce(jumpVec, ForceMode.Impulse);
    }
}
