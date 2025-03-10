using System.Runtime.CompilerServices;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    //Vector3 moveDir;
    public Vector3 moveDir;
    Vector3 jumpVec;
    Vector3 RotVec;
    public float Speed = 12.5f;
    public float JumpForce = 1.6f;
    public float HoriRotSpeed = 2.0f;
    public float VertRotSpeed = 2.0f;
    public Rigidbody rb;

    public float x;
    public float y;

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

        Quaternion.Euler(RotVec);
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
        jumpVec = new Vector3(0f, 1f, 0f) * JumpForce * 2;
        rb.AddForce(jumpVec, ForceMode.Impulse);
    }

    public void PlayerRotate(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
         x = input.x * HoriRotSpeed;
         y = input.y * VertRotSpeed;
        RotVec = new Vector3(y, x, 0);
    }
}
