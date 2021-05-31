using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 30.0f;
    public float rotSpeed = 60.0f;
    public float jumpVelocity = 10.0f;
    public float runSpeed = 60.0f;

    private Rigidbody rigidbody;

    private bool jump;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        Vector3 rotation = Vector3.up * h;
        Quaternion angleRot = Quaternion.Euler(rotation);

        rigidbody.MovePosition(transform.position + transform.forward * v);
        rigidbody.MoveRotation(rigidbody.rotation * angleRot);

        if (Input.GetKeyDown(KeyCode.Space) && this.rigidbody.velocity.y == 0)
        {
            jump = true;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            float Rv = Input.GetAxis("Vertical");
            Rv = Rv * runSpeed * Time.deltaTime;
            rigidbody.MovePosition(transform.position + transform.forward * Rv);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            v = v * speed * Time.deltaTime;
        }

    }

    void FixedUpdate()
    {
        if (jump)
        {
           rigidbody.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
           jump = false;
        }
    }


}
