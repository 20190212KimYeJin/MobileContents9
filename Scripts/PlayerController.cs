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
    private float crouchSpeed;
    [SerializeField]
    private float swimSpeed;
    [SerializeField]
    private float swimFastSpeed;
    [SerializeField]
    private float upSwimSpeed;

    private float applySpeed;

    [SerializeField]
    private float jumpForce;

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
    }


    // Update is called once per frame
    void Update()
    {
        if (isActivated && GameManager.canPlayerMove)
        {
            //WaterCheck();
            IsGround();
            TryJump();
            TryRun();
            Move();
            CameraRotation();
            CharacterRotation();

            /*
            if (!GameManager.isWater)
            {
                TryRun();
            }
            */
        }

    }

    /*
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
    */

    // 지면 체크.
    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, capsuleCollider.bounds.extents.y + 0.1f);
    }

    private void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround )//&& !GameManager.isWater)
            Jump();
        else if (Input.GetKeyDown(KeyCode.Space)) // && GameManager.isWater)
            UpSwim();
    }

    private void Jump()
    {
        myRigid.velocity = transform.up * jumpForce;
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

        float _moveDirX = Input.GetAxisRaw("Horizontal"); // 왼쪽 방향키를 누르면 -1, 오른쪽 방향키를 누르면 1, 안 누르면 0이 리턴됨.
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;
        // 오른쪽, 왼쪽, 위, 아래를 구현.

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * walkSpeed;
        // normalized는 1초에 얼마나 이동시킬 건지 계산이 편해짐.

        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
        // 타임델타 함수: 한 번 움직일 때 1초 동안 조금씩 움직임.
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