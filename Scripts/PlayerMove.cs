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

    private bool isWalk = false;
    private bool isRun = false;

    private Vector3 lastPos; // 움직임 체크, 전 프레임의 위치를 기록 및 비교

    [SerializeField]
    private StatusController theStatusController;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        jump = false;
        theStatusController = FindObjectOfType<StatusController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.canPlayerMove)
        {
            Move();
            MoveCheck();
        }
        
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        Vector3 rotation = Vector3.up * h;
        Quaternion angleRot = Quaternion.Euler(rotation);

        rigidbody.MovePosition(transform.position + transform.forward * v);
        rigidbody.MoveRotation(rigidbody.rotation * angleRot);

        if (Input.GetKeyDown(KeyCode.Space) && this.rigidbody.velocity.y == 0 && theStatusController.GetCurrentSP() > 0) //점프
        {
            theStatusController.DecreaseStamina(100);
            jump = true;
        }

        if (Input.GetKey(KeyCode.LeftShift) && theStatusController.GetCurrentSP() > 0) //달리기
        {            
            theStatusController.DecreaseStamina(2);
            float Rv = Input.GetAxis("Vertical");
            Rv = Rv * runSpeed * Time.deltaTime;
            rigidbody.MovePosition(transform.position + transform.forward * Rv);
            v = v * speed * Time.deltaTime;
        }

    }

    private void MoveCheck()
    {
        if (!isRun)
        {
            if (Vector3.Distance(lastPos, transform.position) >= 0.01f)//a와 b 사이의 거리 차이를 반환
                isWalk = true;
            else
                isWalk = false;

            lastPos = transform.position;
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
