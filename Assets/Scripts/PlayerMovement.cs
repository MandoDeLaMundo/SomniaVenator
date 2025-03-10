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
    Vector3 CamVec;
    public float Speed = 12.5f;
    public float JumpForce = 10f;
    //public float HoriRotSpeed = 2.0f;
    //public float VertRotSpeed = 2.0f;
    public Rigidbody rb;

    float xRot;
    float yRot;
    bool onGround = true;

    public AudioSource steps;
    public AudioSource jump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   
    void FixedUpdate()
    {

        if (moveDir != Vector3.zero) {
            moveDir.Normalize();
            transform.localPosition += transform.forward * moveDir.z * Speed * Time.deltaTime;
            transform.localPosition += transform.right * moveDir.x * Speed * Time.deltaTime;
        }
        //if (RotVec != Vector3.zero) {
        //    RotVec.Normalize();
        //    transform.Rotate(RotVec * 3.5f, Space.World);
        //    Camera.main.transform.RotateAround(CamVec,);
        //}

    }
    void Update()
    {
        
        Camera.main.transform.rotation = Quaternion.Euler(yRot, xRot, 0);
        transform.rotation = Quaternion.Euler(0, xRot, 0);

        if (transform.position.y <= -20) {
            transform.position = new Vector3(0, 10, 0);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        //steps.enabled = true;
        steps.Play();
        Vector2 input = context.ReadValue<Vector2>();

        if (context.performed) {
            moveDir.x = input.x;
            moveDir.z = input.y;
        }
        else moveDir = Vector3.zero;
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (onGround) {
            //jump.enabled = true;
            jump.Play();
            onGround = false;
            jumpVec = new Vector3(0f, 1f, 0f) * JumpForce * 2;
            rb.AddForce(jumpVec, ForceMode.Impulse);
        }
    }

    public void PlayerRotate(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        
        // float x = input.x * HoriRotSpeed;
        // //float y = input.y * VertRotSpeed;
        // RotVec = new Vector3(-0, x, 0);

        //Vector2 input2 = context.ReadValue<Vector2>();
        //float y2 = input.y * VertRotSpeed;
        //CamVec = new Vector3(-y2, 0, 0);

        xRot += input.x * 10f * Time.deltaTime;
        yRot += -input.y * 5f * Time.deltaTime;
        yRot = Mathf.Clamp(yRot, -10, 30);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground") {
            onGround = true;
        }
    }
}
