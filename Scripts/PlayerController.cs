using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public bool isActivated = true;

    //스피드 조정 변수
    [SerializeField] // inspector창에서 수정 가능하게 해줌.
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float rotSpeed;
    [SerializeField]
    private float swimSpeed;
    [SerializeField]
    private float swimFastSpeed;
    [SerializeField]
    private float upSwimSpeed;

    private float applySpeed;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private StatusController theStatusController;

    // 상태 변수
    private bool isRun = false;

    private bool isGround = true;

    [SerializeField]
    private float lookSensitivity; // 카메라의 민감도

    // 땅 착지 여부
    private CapsuleCollider capsuleCollider;

    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0; // 0도는 정면을 바라본다.


    [SerializeField]
    private Camera theCamera;

    private Rigidbody myRigid;


    // Use this for initialization
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        myRigid = GetComponent<Rigidbody>();
        applySpeed = walkSpeed;
        theStatusController = FindObjectOfType<StatusController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (isActivated && GameManager.canPlayerMove)
        {
            WaterCheck();
            IsGround();
            TryJump();
            TryRun();
            Move();
            CameraRotation();
            CharacterRotation();

            if (!GameManager.isWater)
            {
                TryRun();
            }
           
        }

    }

    
    private void WaterCheck()
    {
        if (GameManager.isWater)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                applySpeed = swimFastSpeed;
            else
                applySpeed = swimSpeed;
        }
    }
    

    // 지면 체크.
    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, capsuleCollider.bounds.extents.y + 0.1f);
    }

    private void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && !GameManager.isWater && theStatusController.GetCurrentSP() > 0)
            Jump();
        else if (Input.GetKeyDown(KeyCode.Space) && GameManager.isWater)
            UpSwim();

    
        theStatusController.GetCurrentSP();
    }
     

    private void Jump()
    {
        myRigid.velocity = transform.up * jumpForce;
        theStatusController.DecreaseStamina(100);
    }

    // 달리기 시도
    private void TryRun()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Running();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            RunningCancel();
        }
    }

    // 달리기 실행
    private void Running()
    {


        isRun = true;
        applySpeed = runSpeed;
    }


    // 달리기 취소
    private void RunningCancel()
    {
        isRun = false;
        applySpeed = walkSpeed;
    }

    private void UpSwim()
    {
        myRigid.velocity = transform.up * upSwimSpeed;
    }

    private void Move()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * walkSpeed * Time.deltaTime;

        Vector3 rotation = Vector3.up * h;
        Quaternion angleRot = Quaternion.Euler(rotation);

        GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * v);
        GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * angleRot);


        if (Input.GetKey(KeyCode.LeftShift) && theStatusController.GetCurrentSP() > 0) //달리기
        {
            theStatusController.DecreaseStamina(2);
            float Rv = Input.GetAxis("Vertical");
            Rv = Rv * runSpeed * Time.deltaTime;
            GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * Rv);
            v = v * walkSpeed * Time.deltaTime;
        }
    }


    private void CharacterRotation()
    {
        // 좌우 캐릭터 회전
        float _yRotation = Input.GetAxisRaw("Mouse X"); // 마우스는 좌우로 움직이고 캐릭터 회전은 y값이다.
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY)); // euler 값에 quaternion 값으로 변형시킨 값을 곱하면 플레이어가 회전함.

    }

    private void CameraRotation()
    {
        // 상하 카메라 회전
        float _xRotation = Input.GetAxisRaw("Mouse Y"); // 위아래로 고개를 든다.
        float _cameraRotationX = _xRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX; // 이 값이 증가하면 빼주고, 감소하면 더해준다.
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
        // 최솟값은 -45로, 최댓값은 45에 고정되게 한다.

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }

}