# MobileContents9
문화테크노학과 20190133 김혜원  
문화테크노학과 20190212 김예진  

# 게임 이름🎮
### MONDE STONÉE (몬 스토니) : 돌로 이루어진 세계

# 제작 의도🎮
포스트 아포칼립스 세계관을 통해 자연에 대한 경고와 더불어 현대를 살아가는 우리에게 없는 시대를 체험함으로써 신선함을 맛볼 수 있다. 마지막에는 석화된 인간들을 구출하고 문명을 재건설함으로써 성취감을 느끼게 한다.

# 주요 타깃🎮
- **최근 유행하고 있는 스팀게임과 인디게임의 유저를 겨냥**
- **스토리 위주의 신박한 게임을 좋아하는 사람들을 주요 타깃으로 함**
- (+) 기존의 FPS 게임에서 지루함을 느낀 게임 마니아층. 신선한 주제로 처음 게임을 접하는 사람들도 재미있게 즐길 수 있게 함.

# 스토리 모티브🎮
![L_1252094](https://user-images.githubusercontent.com/84370027/121769429-739ef280-cb9e-11eb-8f05-3b97a2095f46.jpg)
- 스토리 모티브 : Dr.Stone
- 일본 연재 만화

# 게임 스토리(시나리오)🎮
![12](https://user-images.githubusercontent.com/84370027/120946357-27efe180-c777-11eb-8921-33fdca5acad5.JPG)
**(석화된 인간 : 인간 Asset에 Material을 입혀 구현)**  
여느 날과 다르지 않던 지구의 운명을 바꿀 초록빛이 우주에서 떨어졌다. 그 초록빛으로 인해 인간들은 모두 석화되고 만다. 인간이 모두 석화되자 지구의 모든 건물들은 부식되고, 숲이 울창해지면서 점점 동물들의 터전으로 변하게 된다. 약 1000년 뒤, 동물의 왕국이 된 현재, 1000년 전에 석화되었던 당신이 깨어나게 된다. 몸을 감싸고 있던 암석을 뚫고 나와 눈을 뜨게 된 당신은 1000년 사이에 지구가 변한 것을 깨닫게 된다. 단, 유일하게 인간의 흔적이 남아있는 스톤월드에서 당신은 혼자서 지구의 문명을 다시 불러일으키려고 한다. 그러기 위해서는 집을 짓고, 고기를 먹고, 주변의 천적들과도 싸우면서 하루하루를 살아가야 한다. 그리고 당신은 문명을 일으키기 위해 텅 빈 도시 속에 석화된 인간들을 풀어낼 방법을 궁리한다.  과연 당신은 석화된 인간들을 해방시키고, 1000년 전의 문명을 다시 이룩할 수 있을까?

# 사용 에셋
![그림1](https://user-images.githubusercontent.com/84370027/121770073-30468300-cba2-11eb-838c-dbe4effd71d2.png)
- Unity Asset Store에서 다운로드

# 순서도📃
![그림16](https://user-images.githubusercontent.com/84370027/121769346-0f7c2e80-cb9e-11eb-898d-c653999eea63.png)

# 코드 별 순서도
**레퍼런스 강의와 기타 수업 자료 등을 응용하여 구현한 코드 위주**
![그림17](https://user-images.githubusercontent.com/84370027/121769699-1f950d80-cba0-11eb-952b-7c834844ab1b.png)
![그림18](https://user-images.githubusercontent.com/84370027/121769701-202da400-cba0-11eb-9373-f75096a02462.png)
![그림19](https://user-images.githubusercontent.com/84370027/121769702-20c63a80-cba0-11eb-892c-e12a4df69cd9.png)
![그림20](https://user-images.githubusercontent.com/84370027/121769704-20c63a80-cba0-11eb-9099-4c30c6ea185f.png)
![그림21](https://user-images.githubusercontent.com/84370027/121769705-215ed100-cba0-11eb-9a78-c4372e3b9869.png)
![그림22](https://user-images.githubusercontent.com/84370027/121769707-215ed100-cba0-11eb-91d7-d7290bc25527.png)
![그림23](https://user-images.githubusercontent.com/84370027/121769709-21f76780-cba0-11eb-8c88-55e74fa18be1.png)

# 스크립트🔗
https://github.com/20190212KimYeJin/MobileContents9/tree/master/Scripts

# 제작 과정🎮
![11](https://user-images.githubusercontent.com/84370027/120946073-2bcf3400-c776-11eb-8717-665177c136e6.JPG)
- 상호 간 프로젝트 공유 방법 : Github 및 유니티 콜라보레이트(Collabolate) 서비스 이용

## 마을 전체🎮
![7](https://user-images.githubusercontent.com/84370027/120945710-0c83d700-c775-11eb-825b-0fac01739426.JPG)
![그림1](https://user-images.githubusercontent.com/84370027/121770346-c202c000-cba3-11eb-875a-d9ecaf5a22e8.png)
- Terrain 기능 활용
- 황폐화된 도시와 동물 및 적들이 모여 있는 숲을 펜스로 구분

## FPS Player👤
![a](https://user-images.githubusercontent.com/84370027/121770241-39841f80-cba3-11eb-9432-ddb3a6ea5105.JPG)
- 곡괭이를 들고 시작하는 Player  
- 1인칭이므로 Player안에 Main Camera를 넣고 플레이어 시점에서 클리어 할 수 있도록 구현  
- 게임 플레이 중에는 Player가 자신의 모습을 활용할 수 없어 Capsule로만 몸체 구현  
- **PlayerController.cs : 움직임 및 시야 조정 등**
```C#
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

    //private GameBehavior gameManager;

    private Animator anim;


    // Use this for initialization
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        myRigid = GetComponent<Rigidbody>();
        applySpeed = walkSpeed;
        theStatusController = FindObjectOfType<StatusController>();
        //gameManager = GameObject.Find("GameManagers").GetComponent<GameBehavior>();
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
        if (Input.GetKeyDown(KeyCode.Space) && isGround && theStatusController.GetCurrentSP() > 0 && !GameManager.isWater )
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

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "spider")
        {
            //gameManager.HP -= 1;
            Debug.Log("충돌");
        }
    }

}
```
- 할당된 키를 누르면 움직임, 달리기, 점프를 할 수 있으며, 마우스 회전으로 카메라 회전을 할 수 있는 역할을 주로 한다.  

- **StatusController.cs : 왼쪽 하단 상태 체크 담당 등**
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatusController : MonoBehaviour
{
    [SerializeField] //체력
    public int hp;
    private int currentHp;

    [SerializeField] //스태미나
    private int sp;
    private int currentSp;

    [SerializeField] //스태미나 증가
    private int spIncreseSpeed;

    [SerializeField]
    private int spDelay; //스태미나 재회복 딜레이
    private int currentSpRechargeTime;

    private bool spUsed; //스태미나 감소 여부

    [SerializeField]
    private int dp; //방어력
    private int currentDp;

    [SerializeField]
    private int hungry; //배고픔
    private int currentHungry;

    [SerializeField] //줄어드는 속도
    private int hungryDecrease; // 몇 초마다 줄지
    private int currentHungryDecrease;

    [SerializeField]
    private int thirsty; //목마름
    private int currentThirsty;

    [SerializeField] //줄어드는 속도
    private int thirstyDecrease;
    private int currentThirstyDecrease;

    [SerializeField]
    private int satisfy = 0; // 만족도

    [SerializeField] //줄어드는 속도
    private int satisfyDecrease; // 몇 초마다 줄지
    private int currentSatisfy;
    private int currentSatisfyDecrease;

    [SerializeField] //필요 이미지
    private Image[] images_Gauge;

    public const int HP = 0, DP = 1, SP = 2, HUNGRY = 3, THIRSTY = 4, SATISFY = 5; // 상수화 시킴


    void Start() //초기값 설정
    {
        currentHp = hp;
        currentDp = dp;
        currentSp = sp;
        currentHungry = hungry;
        currentThirsty = thirsty;
        currentSatisfy = satisfy;
    }

    void Update()
    {
        Hungry();
        Thirsty();
        GaugeUpdate();
        SPRechargeTime();
        SPRecover();
        SatifsyUP();
        SatifsyClear();
    }

    private void SPRechargeTime() //sp 자동 회복
    {
        if(spUsed)
        {
            if (currentSpRechargeTime < spDelay)
                currentSpRechargeTime++;

            else
                spUsed = false;
        }

    }

    private void SPRecover()
    {
        if (!spUsed && currentSp < sp)
        {
            currentSp += spIncreseSpeed;
        }
    }

    private void Hungry()
    {
        if (currentHungry > 0) // 지금 배고픔이 0보다 크면
        {
            if (currentHungryDecrease <= hungryDecrease)
                currentHungryDecrease++; //1씩 증가

            else
            {
                currentHungry--; //지금 배고픔은 1씩 감소
                currentHungryDecrease = 0;
            }
        }

        else // 0이 되었으면
        {
            Debug.Log("배고픔");
            currentHp--;

            if(currentHp <= 0)
            {
                SceneManager.LoadScene(0);

            }
        }
    }

    private void Thirsty()
    {
        if (currentThirsty > 0) // 지금 배고픔이 0보다 크면
        {
            if (currentThirstyDecrease <= thirstyDecrease)
                currentThirstyDecrease++; //1씩 증가

            else
            {
                currentThirsty--; //지금 배고픔은 1씩 감소
                currentThirstyDecrease = 0;
            }
        }

        else // 0이 되었으면
        {
            Debug.Log("목마름");
        }
    }

    private void GaugeUpdate()
    {
        images_Gauge[HP].fillAmount = (float)currentHp / hp; // 최대값1과 최소값0 사이를 왔다갔다 하도록        
        images_Gauge[DP].fillAmount = (float)currentDp / dp;
        images_Gauge[SP].fillAmount = (float)currentSp / sp;
        images_Gauge[HUNGRY].fillAmount = (float)currentHungry / hungry;
        images_Gauge[THIRSTY].fillAmount = (float)currentThirsty / thirsty;
        images_Gauge[SATISFY].fillAmount = (float)currentSatisfy / satisfy;
    }

    public void IncreaseHP(int _count) // 체력 회복
    {
        if (currentHp + _count < hp)
            currentHp += _count;

        else
            currentHp = hp;
    }

    public void DecreaseHP(int _count) // 아이템 잘못 먹거나 체력 닮
    {
        if(currentDp > 0) //체력을 깎으려는데 방어력이 있는 경우
        {
            DecreaseDP(_count);
            return;
        }

        currentHp -= _count;

            if (currentHp <= 0)
            Debug.Log("hp = 0");
    }

    public void IncreaseDP(int _count) // 방어력
    {
        if (currentDp + _count < dp)
            currentDp += _count;

        else
            currentDp = dp;
    }

    public void DecreaseDP(int _count) // 방어력 닮
    {
        currentDp -= _count;

            if (currentDp <= 0)
            Debug.Log("dp = 0");
    }

    public void IncreaseHungry(int _count) // 배고픔
    {
        if (currentHungry + _count < hungry)
            currentHungry += _count;

        else
            currentHungry = hungry;
    }

    public void DecreaseHungry(int _count) // 음식 잘못 먹은 경우 || 배고픔 닮
    {
        if (currentHungry - _count < 0)
            currentHungry = 0;
        else
            currentHungry -= _count;

    }

    public void IncreaseThirsty(int _count) // 배고픔
    {
        if (currentThirsty + _count < thirsty)
            currentThirsty += _count;

        else
            currentThirsty = hungry;
    }

    public void DecreaseThirsty(int _count) // 목마름
    {
        if (currentThirsty - _count < 0)
            currentThirsty = 0;
        else
            currentThirsty -= _count;

    }

    public void DecreaseStamina(int _count)
    {
        spUsed = true;
        currentSpRechargeTime = 0;

        if (currentSp - _count > 0)
            currentSp -= _count;
        else
            currentSp = 0;
    }

    public void IncreaseSatisfy(int _count)
    {
        if (currentSatisfy + _count < satisfy)
            currentSatisfy += _count;

        else
            currentSatisfy = satisfy;
    }

    public int GetCurrentSP()
    {
        return currentSp; //sp가 0이면 못움직이게
    }

    private void SatifsyUP()
    {
        if (currentSatisfy > 0)
        {
            if (currentSatisfyDecrease <= satisfyDecrease)
                currentSatisfyDecrease++; //1씩 증가

            else
            {
                currentSatisfy--; //지금 배고픔은 1씩 감소
                currentSatisfyDecrease = 0;
            }
        }

    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(0.4f);
        Application.LoadLevel("ClearScenes");
    }

    private void SatifsyClear()
    { 
        satisfy = 101;

        if (currentSatisfy >= 101)
        {
            StartCoroutine(NextScene());
            //SceneManager.LoadScene(2);
        }
        
    }

    
}
```
- HP, DP(게임에선 사용하지 않으나 구현), SP(스태미나), 허기, 갈증, 석화게이지 UI 담당  
- 허기, 갈증의 경우 시간이 흐를수록 1씩 감소되며 감소되는 속도는 Inspector창에서 조절 가능하도록 구현  
- 스태미나는 달리기, 점프를 할 때 감소하며, 달리거나 뛰지 않을 때 자연회복(회복 속도는 Inspector창에서 조절)  
- 석화 게이지의 경우 시작부터 빠른 속도로 감소하여 클리어 조건을 위한 빌드업으로 구현  
- NextScene() 함수와 SatifsyClear()를 통해 '석화 부활액'을 사용해 101 이상의 석화게이지를 채우면 클리어 씬으로 전환되도록 'SceneManagement' 설정  

## 맨손 구현🖐
![2](https://user-images.githubusercontent.com/84370027/120945314-83b86b80-c773-11eb-9e35-240e810977c8.JPG)
맨손 구현
- **Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등**
```C#
- public class Hand : MonoBehaviour
{
    public string handName; //(근접)무기 구분

    // 무기 유형
    public bool isHand;
    public bool isAxe;
    public bool isPickAxe;

    public float range; //공격범위
    public int damage; //공격력
    public float workSpeed; //작업속도
    public float attackDelay; //공격 딜레이
    public float attackDelay1; //공격 활성화 시점
    public float attackDelay2; //공격 비활성화 시점(주먹이 닿아도 데미지 안 닳게)

    public Animator animator;

}
```
- 근접 무기(손, 도끼, 곡괭이)를 통틀어 관리할 수 있도록 구현  
- 해당 스크립트가 적용된 무기의 Inspector창에서 무기 구분, 공격을 위한 사정거리, 속도, 딜레이 등을 판별 가능  

- HandController.cs : 근접 무기 공격 제어
```C#
public class HandController : CloseWeaponController
{
    
    public static bool isActivate = false;

    // Update is called once per frame
    void Update()
    {
        if (isActivate)
            TryAttack();
    }

    protected override IEnumerator HitCoroutine()
    {
        while (isSwing)
        {
            if (CheckObject())
            {
                isSwing = false; //한번 적중하면 실행되지 않도록
                Debug.Log(hitinfo.transform.name);
            }

            yield return null;

        }
    }

    public override void HandChange(Hand _hand)
    {
        base.HandChange(_hand);
        isActivate = true;
    }
 
}
```
- 공격 여부를 확인하고 공격하고 있지 않으면 공격이 가능하도록 TryAttack() 함수 사용  
- 주먹을 휘두르고 있을 때는 중복 실행이 되지 않도록 구현  


## 총 구현🔫
![3](https://user-images.githubusercontent.com/84370027/120945345-a21e6700-c773-11eb-8422-cedeac743802.JPG)
총 구현
- Gun.cs : 무기 구분, 사정거리, 탄피 관리 등
```C#
public class Gun : MonoBehaviour
{
    public string gunName; //총 이름
    public float range; //총 사정거리
    public float accuracy; //정확도
    public float fireRate; //연사속도
    public float reloadTime; //재장전 속도

    public int damage; //총 데미지

    public int reloadBulletCount; //총알 재장전 개수
    public int currentBulletCount; //현재 탄알집에 남아있는
    public int maxBulletCount; //최대 소유 총알 수
    public int carryBulletCount; //현재 소유 총알 수

    public float retroActionForce; //반동 세기
    public float retroActionFineSightForce; //정조준시 반동 세기

    public Vector3 fineSightOriginPos;
    public Animator animator;
    public ParticleSystem muzzleFlash; //총구 섬광
    public AudioClip fire_Sound;

}
```
- 총을 관리할 수 있도록 구현  
- 해당 스크립트가 적용된 총의 Inspector창에서 사정거리, 각종 속도, 딜레이, 탄피 등을  가능  


- GunController : 반동, 정조준, 이펙트 등 담당
```C#
public class GunController : MonoBehaviour
{

    public static bool isActivate = false;

    [SerializeField]
    private Gun currentGun; //현재 소유한 총
    private float currentFireRate; //gun.cs에 있는 연사속도
    private AudioSource audioSource; //효과음

    //상태 변수
    private bool isReload = false; //재장전 하는 동안 발사가 안 되도록, false일 때만 발사
    private bool isFineSightMode = false; //true면 정조준 상태

    [SerializeField]
    private Vector3 originPos; //원래 포지션 값

    private RaycastHit hitinfo; //충돌정보 받아옴

    [SerializeField]
    private Camera theCam; //카메라 시점을 받아옴

    [SerializeField]
    private GameObject HitEffect_Prefab;

    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private GameObject bullet;
    public float bulletspeed = 10.0f;

    private Rigidbody rigidbody;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        originPos = Vector3.zero;
        audioSource = GetComponent<AudioSource>();
        //originPos = transform.localPosition;

        WeaponManager.currentWeapon = currentGun.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentGun.animator;
    }


    // Update is called once per frame
    void Update()
    {
        if (isActivate)
        {
            GunFireRateCalc();
            TryFire();
            TryReload(); //R키 눌러 재장전
            TryFineSight();
        }

    }

    private void GunFireRateCalc() //재계산 연사속도
    {
        if (currentFireRate > 0)
            currentFireRate -= Time.deltaTime; // 60분의 1, 1초에 1 감소        
    }

    private void TryFire()//발사 시도
    {
        if (Input.GetKey(KeyCode.X) && currentFireRate <= 0 && !isReload)
        {
            Fire();
        }
    }

    private void Fire() //방아쇠 당긴 뒤 이벤트(발사 전 계산)
    {
        if (!isReload) //재장전이 계속 이루어지면 안 됨
        {
            if (currentGun.currentBulletCount > 0)
                Shoot();

            else
            {
                StartCoroutine(ReloadCoroutine()); //중복 실행 방지
            }

        }

    }

    private void Shoot() //발사하는 과정
    {
        currentGun.currentBulletCount--; //현재 총알 하나씩 줄어듦
        currentFireRate = currentGun.fireRate; //0.2초가 되면서 발사를 하지 못하게 함
        PlaySound(currentGun.fire_Sound);
        currentGun.muzzleFlash.Play();
        Hit();

        //총기 반동 코루틴
        StopAllCoroutines(); //while문 간 충돌 막기 위함
        StartCoroutine(RetroActionCoroutine());
    }

    private void Hit()
    {
        if (Physics.Raycast(theCam.transform.position, theCam.transform.forward, out hitinfo, currentGun.range, layerMask))
        {
            var clone = Instantiate(HitEffect_Prefab, hitinfo.point, Quaternion.LookRotation(hitinfo.normal));
            //hitinfo.normal : 충돌 객체의 표면 반환
            Destroy(clone, 2.0f);
        }
    }

    private void TryReload() //재장전시도
    {
        if (Input.GetKeyDown(KeyCode.R) && !isReload && currentGun.currentBulletCount < currentGun.reloadBulletCount) //재장전 개수보다 작을때
        {
            CancleFineSight();
            StartCoroutine(ReloadCoroutine());
        }
    }

    public void CancleReload()
    {
        if (isReload)
        {
            StopAllCoroutines();
            isReload = false;
        }
    }

    IEnumerator ReloadCoroutine() //대기가 있어야 함, 재장전
    {
        if (currentGun.carryBulletCount > 0)
        {
            isReload = true;
            currentGun.animator.SetTrigger("Reload");

            currentGun.carryBulletCount += currentGun.currentBulletCount;
            currentGun.currentBulletCount = 0;

            yield return new WaitForSeconds(currentGun.reloadTime); //대기 시간

            if (currentGun.carryBulletCount >= currentGun.reloadBulletCount) //현재 총알 >= 총알 재장전 개수
            {
                currentGun.currentBulletCount = currentGun.reloadBulletCount;
                currentGun.carryBulletCount -= currentGun.reloadBulletCount; //(주의)
            }

            else
            {
                currentGun.currentBulletCount = currentGun.carryBulletCount;
                currentGun.carryBulletCount = 0;
            }

            isReload = false;
        }

        else
        {
            Debug.Log("총알 없음");
        }
    }

    private void TryFineSight() //정조준 시도
    {
        if (Input.GetKeyDown(KeyCode.C) && !isReload)
        {
            FineSight();
        }
    }

    public void CancleFineSight() //정조준 취소
    {
        if (isFineSightMode)
            FineSight();
    }

    private void FineSight() //정조준 로직 실행
    {
        isFineSightMode = !isFineSightMode; //!isFineSightMode : true false 매번 실행될 때마다 스위치 되도록
        currentGun.animator.SetBool("FineSightMode", isFineSightMode);

        if (isFineSightMode)
        {
            StopAllCoroutines(); //기존 시행 중인 코루틴을 멈춰 중복 시행 막음
            StartCoroutine(FineSightAvtivateCoroutine());
        }

        else
        {
            StopAllCoroutines();
            StartCoroutine(FineSightDeavtivateCoroutine());
        }
    }


    //정조준 상태 모드 활성화
    IEnumerator FineSightAvtivateCoroutine()
    {
        while (currentGun.transform.localPosition != currentGun.fineSightOriginPos)//정조준 모드가 될 때까지
        {
            //자식 개체일 때 사용하는 localPosition
            currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, currentGun.fineSightOriginPos, 0.2f); //현재 위치에서 목적지까지 반복, 화면 가운데로 오게 하는 러프 실행
            yield return null;//1프레임씩 대기
        }
    }

    IEnumerator FineSightDeavtivateCoroutine() //정조준 비활성화
    {
        while (currentGun.transform.localPosition != originPos)
        {
            currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, originPos, 0.4f); //원래대로 돌아갈 때까지 계속 러프
            yield return null;//1프레임씩 대기
        }
    }

    IEnumerator RetroActionCoroutine() //반동 코루틴
    {
        Vector3 recoilBack = new Vector3(currentGun.retroActionForce, originPos.y, originPos.z); //총이 꺾여있으므로 z축이 좌우, x축이 앞뒤 + 가까이 붙으면 마이너스값
        Vector3 retroActionRecoilBack = new Vector3(currentGun.retroActionFineSightForce, currentGun.fineSightOriginPos.y, currentGun.fineSightOriginPos.z);

        if (!isFineSightMode) //정조준 상태 아닌 경우
        {
            currentGun.transform.localPosition = originPos; // 반동을 느끼기 위해 처음 위치로 되돌림

            //반동
            while (currentGun.transform.localPosition.x <= currentGun.retroActionForce - 0.51f) //lerp가 정확하지 않기 때문에 대충 일치하면 반동이 끝나도록
            {
                currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, recoilBack, 0.1f); //자기위치, 로컬포지션, 최대 반동(빨리 이뤄지기 위해 0.4 속도)
                yield return null; // 한 프레임마다 반복
            }

            //원위치
            while (currentGun.transform.localPosition != originPos)
            {
                currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, originPos, 0.1f);
                yield return null;
            }
        }

        else
        {
            currentGun.transform.localPosition = currentGun.fineSightOriginPos; //정조준 상태로 위치 되돌림

            while (currentGun.transform.localPosition.x <= currentGun.retroActionFineSightForce - 0.01f) //lerp가 정확하지 않기 때문에 대충 일치하면 반동이 끝나도록
            {
                currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, retroActionRecoilBack, 0.1f); //자기위치, 로컬포지션, 최대 반동(빨리 이뤄지기 위해 0.4 속도)
                yield return null; // 한 프레임마다 반복
            }

            //원위치
            while (currentGun.transform.localPosition != currentGun.fineSightOriginPos)
            {
                currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, currentGun.fineSightOriginPos, 0.1f);
                yield return null;
            }
        }
    }

    private void PlaySound(AudioClip _clip) //사운드 재생
    {
        audioSource.clip = _clip;
        audioSource.Play();
    }

    public Gun GetGun()
    {
        return currentGun;
    }


    public void GunChange(Gun _gun)
    {
        if (WeaponManager.currentWeapon != null)
            WeaponManager.currentWeapon.gameObject.SetActive(false);

        currentGun = _gun; //현재 무기로 바꿈
        WeaponManager.currentWeapon = currentGun.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentGun.animator;

        currentGun.transform.localPosition = Vector3.zero; //총의 위치를 정조준 0으로 초기화
        currentGun.gameObject.SetActive(true);
        isActivate = true;
    }

}
```
- 발사 전, 발사하는 과정, 재장전, 정조준 과정, 사운드를 통틀어 관리
- X를 누르고, 재장전(자동 충전, R키 입력)이 이루어지고 있는지를 판별하여 총알 발사
- 재장전 관리 : R키를 눌러 재장전 하는 동안은 재장전이 되지 않도록 구현, 코루틴을 통해 중복 실행 방지
- 충돌체 정보를 받아와 총이 맞은 곳에 이펙트가 터지도록 구현
- X를 누르면 사운드가 플레이 되도록 설정

## 도끼 구현🪓
![13](https://user-images.githubusercontent.com/84370027/120948128-78b60900-c77c-11eb-8267-1e6836913254.JPG)
- Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등
- AxeController.cs : 근접 무기 공격 제어(위의 HandController와 동일)
**cs 이름은 hand로 설정되어 있으나, 근접무기 전체를 통칭함**

## 곡괭이 구현⛏
![캡처](https://user-images.githubusercontent.com/84370027/120945204-1efd1100-c773-11eb-9697-deacff62adec.JPG)
플레이 시작 화면(곡괭이로 시작)
- Hand.cs : 무기 구분, 공격 시간과 딜레이 담당 등
- PickaxeController.cs : 근접 무기 공격 제어
```C#
public class PickaxeController : CloseWeaponController
{
    public static bool isActivate = true;

    void Start()
    {
        WeaponManager.currentWeapon = currentHand.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentHand.animator;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivate)
            TryAttack();
    }

    protected override IEnumerator HitCoroutine()
    {
        while (isSwing)
        {
            if (CheckObject())
            {
                if (hitinfo.transform.tag == "Rock")
                {
                    hitinfo.transform.GetComponent<Rock>().Mining();                    
                }

                else if (hitinfo.transform.tag == "RealRock")
                    hitinfo.transform.GetComponent<RealRock>().Mining();

                else if (hitinfo.transform.tag == "HPRock")
                    hitinfo.transform.GetComponent<Rock2>().Mining();

                else if (hitinfo.transform.tag == "WeekAnimal")
                    hitinfo.transform.GetComponent<WeekAnimal>().Damage(1, transform.position); //상속

                else if (hitinfo.transform.tag == "StrongAnimal")
                    hitinfo.transform.GetComponent<StrongAnimal>().Damage(1, transform.position); //상속

                isSwing = false; //한번 적중하면 실행되지 않도록
                Debug.Log(hitinfo.transform.name);
            }

            yield return null;

        }
    }

    public override void HandChange(Hand _hand)
    {
        base.HandChange(_hand);
        isActivate = true;
    }
}
```
- 곡괭이의 공격 여부를 받아옴
- 아무것도 들어있지 않은 돌, 석화 부활액이 든 돌, 옐로 포션이 든 돌, 돼지에 태그된 WeekAnimal을 구분
- 한 번 공격이 적중하면 실행되지 않으며, hitinfo의 정보에 담긴 객체의 이름이 Console창에 출력되도록 함
- 곡괭이의 공격이 맞는 대상은 Collider가 설정되어 있어야 정상적으로 반응함

## 상태 UI
![S](https://user-images.githubusercontent.com/84370027/121771870-0a72ab80-cbad-11eb-9d4e-66f8ea0be6e4.JPG)
- HP, 스태미나, 허기, 갈증, 석화 게이지 구현
- 허기가 다 닳으면 HP가 점점 깎이고 **HP가 0이 되면 사망**
- 달리기와 점프를 하면 스태미나가 점점 닳고 시간에 따라 자연 회복
- 석화 게이지 : 시작과 동시에 0이 되고 '석화 부활액'을 얻어서 100으로 만들면 클리어

## 아이템 줍기 구현🎮
![5](https://user-images.githubusercontent.com/84370027/120945465-0f31fc80-c774-11eb-83c4-cc7b573bde7b.JPG)  
- 아이템 가까이 다가가면 문구가 뜨고 E키를 눌러 습득
- Item.cs : 아이템 이름, 설며으 유형, 인벤토리 이미지, 프리팹 설정용
```c#
[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject //게임 오브젝트에 스크립트를 붙이지 않아도 됨
{
    public string itemName; //아이템 이름
    [TextArea] //엔터치고 명령어 입력 가능해짐
    public string ItemDesc; // 아이템 설명
    public ItemType itemType; //아이템 유형
    public Sprite itemImage; //아이템 이미지, 이미지는 캔버스에서만 볼 수 있고 스프라이트는 월드상 좌표에서도 볼 수 있음
    public GameObject itemPrefab; //아이템의 프리팹

    
    public string weaponType; //무기 종류 바꿈

    public enum ItemType //열거
    {
        Equipment,
        Used,
        Ingredient,
        ETC
    }

}
```
- Create를 통해 아이템 관리창을 만들어 구현
- 아이템 이름, 인벤토리 툴팁에 뜨는 설명, 아이템 사용방법을 관리할 유형(Equipment, Used, Ingredient, etc)을 구분하도록 열거, 인벤토리에 뜰 아이템 이미지, 실제 아이템 프리팹을 설정하여 관리 가능(선택적 입력)

- ItemPickup.cs : 아이템 구분용  
- ActionController.cs : 아이템 습득 사정거리, 충돌체 정보 확인, 레이어 확인, 출력 UI 담당
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    private float range; //습득 사정거리

    private bool pickupActivated = false; //습득 가능할시 true

    private RaycastHit hitInfo; // 충돌체 정보

    [SerializeField]
    private LayerMask layerMask; //아이템에 대한 레이어에 대해 반응하도록 씌운 마스크

    [SerializeField]
    private Text actionText; //UI 필요


    // Update is called once per frame
    void Update()
    {
        CheckItem();
        TryAction();
    }

    private void TryAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {            
            CheckItem();
            CanPickUp();
        }
    }


    private void CanPickUp()
    {
        if (pickupActivated) //true이면
        {
            if (hitInfo.transform != null) //정보가 있는 경우
            {
                Debug.Log(hitInfo.transform.GetComponent<ItemPickup>().item.itemName + " 획득했습니다");
                Destroy(hitInfo.transform.gameObject);
                InfoDisappear();

            }
        }
    }

    private void CheckItem()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        {
            if (hitInfo.transform.tag == "Item")
            {
                ItemInfoAppear(); // 발견하면 텍스트가 나타나는
            }
            else
            {
                InfoDisappear();
            }
        }
    }


    private void ItemInfoAppear()
    {
        pickupActivated = true;
        actionText.gameObject.SetActive(true); // 텍스트 육안으로 확인 가능
        actionText.text = hitInfo.transform.GetComponent<ItemPickup>().item.itemName + " 획득 " + "<color=yellow>" + "(E)" + "</color>";
    }

    private void InfoDisappear()
    {
        pickupActivated = false;
        actionText.gameObject.SetActive(false); // 텍스트 육안으로 확인 불가
    }

}
```
- 가까이 다가가면 아이템 정보가 뜰 수 있도록 사정거리 설정(Inspector창에서 조절 가능)
- 습득 가능한 아이템임을 판별하면 아이템 정보와 E키를 통해 습득하라는 UI 출력
- 아이템에 레이어를 씌우고 이를 구분하여 아이템을 습득할 수 있도록 구현
- RayCast를 통해 플레이어가 바라보는 위치와 사정거리의 정보를 통해 위의 행동을 가능하게 함
- 아이템을 주웠다면 UI가 사라지도록 Activate를 true, false하며 활성화와 비활성화 판단

## 인벤토리 구현🎮
![6](https://user-images.githubusercontent.com/84370027/120945469-122ced00-c774-11eb-9d5b-4b063b1ed322.JPG) 
- 습득한 아이템은 I키를 눌러 인벤토리에서 확인 가능
- 마우스를 아이템에 갖다대면 아이템 설명팁이 뜨고, 오른쪽 마우스 버튼을 눌러 이용 가능
- Inventory.cs : 인벤토리 창 열고 닫기, 아이템 종류 구분, 습득 아이템 저장 등
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool inventoryActivated = false; //인벤토리가 열리면 인벤토리창만 이용하도록

    [SerializeField]
    private GameObject go_InventoryBase;

    [SerializeField]
    private GameObject go_SlotParent;//슬롯의 부모개체

    private Slot[] slots;

    public Slot[] GetSlots() { return slots; }

    [SerializeField]
    private Item[] items;

    public void LoadToInven(int _arrayNum, string _itemName, int _itemNum)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].itemName == _itemName) //아이템 이름과 일치하면
                slots[_arrayNum].AddItem(items[i], _itemNum); //넘겨줌
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        slots = go_SlotParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        ToOpenInventory();
    }

    private void ToOpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
                OpenInventory();

            else
                CloseInventory();

        }
    }

    private void OpenInventory()
    {
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory()
    {
        go_InventoryBase.SetActive(false);
    }

    public void AcquireItem(Item _item, int _count = 1) //아이템을 얻음
    {

        if(Item.ItemType.Equipment != _item.itemType) // 아이템 타입이 장비인지 확인
        {
            for (int i = 0; i < slots.Length; i++) //슬롯의 개수만큼 반복
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName) //아이템 이름이 일치하면(슬롯 안에 있으면)
                    {
                        slots[i].SetSlotCount(_count); //슬롯의 개수를 증가시킨다
                        return;
                    }
                }
            }
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null) //슬롯에 빈자리가 있으면
            {
                slots[i].AddItem(_item, _count); // 슬롯에 아이템을 추가한다
                return;
            }
        }        
    }
}
```
- bool을 이용해 I를 누르면 인벤토리창을 열고 닫을 수 있도록 설정
- 각종 슬롯 개수를 설정하고, 같은 아이템을 먹었다면 스택을 쌓아 한 곳에 모을 수 있도록 설정
- 단, 장비 아이템의 경우 스택을 쌓을 수 없으므로 Item.cs에서 설정한 내용을 바탕으로 무기가 아닌 것을 확인하고 적용 가능
- 슬롯에 빈자리가 있는지 확인 후, 슬롯에 추가할 수 있도록 설정
- 슬롯 드래그는 가능하나, 게임에서 획득 가능한 아이템이 많지 않다는 점을 고려하여 실제 인벤토리 속 자리 이동이 가능하도록 구현하지는 않았음

## 펜스🚫
![image](https://user-images.githubusercontent.com/84370027/121770303-8962e680-cba3-11eb-8613-5988ccfde02a.png)
- Collider를 추가하여 플레이어가 뚫고 지나가지 못하도록 설정
- 입구에는 Collider가 설정된 바위가 막고 있어 게임 최초에는 곡괭이로 부숴야만 숲으로 갈 수 있음

## 마을 외곽(숲)🎮
![8](https://user-images.githubusercontent.com/84370027/120945713-10aff480-c775-11eb-9de5-cb0e03148adc.JPG)
나가는 길
- 돌과 펜스에는 Collider가 붙어있어 그냥 지나갈 수 없다.
- 돌을 곡괭이로 세 번 내려치면 돌이 깨지고 이후 나갈 수 있다.  

## 사냥 1🐷
![그림3](https://user-images.githubusercontent.com/84370027/121768924-d9d64600-cb9b-11eb-9337-3e4c765dc036.png)
- 돼지의 눈 앞에 다가가면 반대 방향으로 도망가도록 시야각 구현
- 돼지를 근접 무기로 두 번 때리면 사망 애니메이션 진행 후 Destroy
- 돼지 소리 구현(일반 울음소리, 때리면 나는 소리, 죽으면 나는 소리)
- Pig.cs : 이중상속, 일반 상태일 때 애니메이션 재생 관리
```
public class Pig : WeekAnimal //이중 상속
{

    protected override void ReSet()
    {
        base.ReSet(); //기존의 부모 개체에 리셋을 실행시키고
        RandomAction(); //랜덤 액션 실행
    }

    private void RandomAction()
    {
        RandomSound();

        int _random = Random.Range(0, 4); //랜덤한 행동을 하도록(대기, 먹기, 두리번, 걷기)

        if (_random == 0)
            Wait();

        else if (_random == 1)
            Eat();


        else if (_random == 2)
            Peek();


        else if (_random == 3)
            TryWalk();
    }

    private void Wait()
    {
        currentTime = waitTime;
        //Debug.Log("대기");
    }

    private void Eat()
    {
        currentTime = waitTime;
        anim.SetTrigger("Eat");
        //Debug.Log("먹기");
    }

    private void Peek()
    {
        currentTime = waitTime;
        anim.SetTrigger("Peek");
        //Debug.Log("두리번");
    }
}
```
- 돼지가 맞거나 죽지 않았을 때 랜덤으로 행동하고, 사운드를 낼 수 있도록 구현  
- WeekAnimal.cs 시야각에 따라 플레이어 반대방향으로 뛸 수 있도록 구현, 데미지를 입어 도망가는 것 구현
- Animal.cs : 동물 전체 관리, 이름, 속도, 드랍 아이템, 사운드, 네비게이션 등 담당
```
public class WeekAnimal : Animal //상속
{
    public void Run(Vector3 _targetPos) //플레이어 반대방향으로 뛰도록
    {
        //direction = Quaternion.LookRotation(transform.position - _targetPos).eulerAngles; //반대방향을 바라보도록, xz값은 설정되지 않게 해야함
        destination = new Vector3(transform.position.x - _targetPos.x, 0f, transform.position.z - _targetPos.z).normalized; //player와 반대방향(정규화)
        currentTime = runTime;
        isWalking = false;
        isRunning = true;
        nav.speed = runSpeed;
        anim.SetBool("Running", isRunning);
    }

    public override void Damage(int _dmg, Vector3 _targetPos)
    {
        base.Damage(_dmg, _targetPos);

        if(!isDead)
            Run(_targetPos); //죽기 전에는 도망감
    } 
}
```
- 돼지가 곡괭이에 맞으면 걷던 것을 false시키고 뛰는 것을 true시킴(애니메이션도 뛰는 애니메이션으로 구현)
- Vector3를 통해 돼지가 달릴 방향이 플레이어의 반대 방향이 되도록 설정
- 죽은 상태가 아니라면 계속 달림

## 플레이어를 따라오는 적🕷
![그림11](https://user-images.githubusercontent.com/84370027/121768954-f2466080-cb9b-11eb-98cd-d8c515caec29.png)
- 정해진 루트를 자유롭게 돌아다니는 거미
- 거미에게 설정된 Collider안에 플레이어가 들어오면 플레이어를 목적지로 함
- SpiderMove.cs : PatrolRoute를 따라 걷도록 설정, 플레이어와 닿으면 플레이어 돌진 구현
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderMove : MonoBehaviour
{
    public List<Transform> locations;
    public Transform patrolRoute;
    public Transform player; //목적지를 플레이어로

    private int locationIndex = 0;
    private NavMeshAgent agent;

    private int _lives = 3;
    public int EnemyLives
    {
        get { return _lives; }
        set
        {
            _lives = value;

            if (_lives <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        InitializePatrolRoute();
        MoveToNextPatrolPoint();
    }

    void Update() //네개 지점 순찰하도록
    {
        if(agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolPoint();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Player")
        {
            agent.destination = player.position; //플레이어에게 오도록
            Debug.Log("공격");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Player")
        {
            Debug.Log("공격 범위 이상");
        }
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    void MoveToNextPatrolPoint()
    {
        agent.destination = locations[locationIndex].position; //GUI

        locationIndex = (locationIndex + 1) % locations.Count;
        //locations.Count : location.list의 원소 개수(4개)
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pickaxe")
        {
            EnemyLives -= 1;
        }
    }
}
```
- AI 기능을 통해 거미가 자동으로 움직일 수 있도록 설정함
- Create Empty를 통해 실제 숲 안에서 네 개의 랜덤한 지점을 설정하고 그 지점을 순회하도록 구현(Patrol Route)
- 순회하다가 거미의 Collider에 Player의 Collider가 충돌하면 Player를 목적지로 하여 돌진하는 것처럼 구현


## 물
![wa](https://user-images.githubusercontent.com/84370027/121770477-713f9700-cba4-11eb-95fc-00fba88c2c26.JPG)
- 움푹 파인 지형을 만들어 물 구현  
![ea](https://user-images.githubusercontent.com/84370027/121770479-7270c400-cba4-11eb-9104-6b4230fea47e.JPG)
- 물 안에서 헤엄치는 정어리 구현

## 낮과 밤☀🌙
![그림8](https://user-images.githubusercontent.com/84370027/121768985-186c0080-cb9c-11eb-8033-8926b8a04ef2.png)
![그림9](https://user-images.githubusercontent.com/84370027/121768986-19049700-cb9c-11eb-9479-c1f8977bb705.png)
![그림10](https://user-images.githubusercontent.com/84370027/121768987-19049700-cb9c-11eb-8d32-3a1acebd37ba.png)
- 시간이 흐를수록 해가 떨어지며 낮과 밤이 반복되는 것을 확인할 수 
- 기준 시간 : 10초
- DayAndNight.cs : 게임세계 속 시간 구분, 낮과 밤의 Fog 관리 및 계산
```c#
public class DayAndNight : MonoBehaviour
{
    [SerializeField] private float secondPerRealTimeSecond; // 게임 세계의 100초 = 현실 세계의 1초

    [SerializeField] private float fogDensityCale; // 증감량 비율

    [SerializeField] private float nightFogDensity; // 밤 상태의 Fog 밀도
    private float dayFogDensity; // 낮 상태의 fog 밀도
    private float currentFogDensity; // 계산

    // Start is called before the first frame update
    void Start()
    {
        dayFogDensity = RenderSettings.fogDensity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, 0.1f * secondPerRealTimeSecond * Time.deltaTime);

        if (transform.eulerAngles.x >= 170)
            GameManager.isNight = true;
        else if (transform.eulerAngles.x <= 340)
            GameManager.isNight = false;

        if (GameManager.isNight)
        {
            if (currentFogDensity <= nightFogDensity)
            {
                currentFogDensity += 0.1f * fogDensityCale * Time.deltaTime;
                RenderSettings.fogDensity = currentFogDensity;
            }
        }
        else
        {
            if (currentFogDensity >= nightFogDensity)
            {
                currentFogDensity -= 0.1f * fogDensityCale * Time.deltaTime;
                RenderSettings.fogDensity = currentFogDensity;
            }
        }
    }
}
```
- 현실 세계의 시간보다 게임세계의 시간이 훨씬 빠르게 설정하여 낮과 밤을 빠르게 확인할 수 있도록 구현
- 낮과 밤 구분 : 밤의 FOG 밀도를 낮보다 큰 값으로 설정하여 앞이 잘 보이지 않도록 구현(Inspector창에서 조절)

## 모닥불🔥
![그림4](https://user-images.githubusercontent.com/84370027/121769164-06d72880-cb9d-11eb-951e-a4364828d80d.jpg)
![그림5](https://user-images.githubusercontent.com/84370027/121769029-4cdfbc80-cb9c-11eb-85ab-e7b0cb586b84.png)
- Tab키를 눌러 모닥불 소환 창 불러오기 및 닫기
- 마우스 왼쪽 클릭으로 설치
- 설치불가 지역은 빨간색으로 표시
- CraftManual.cs : 이름, 프리팹, 미리보기 프리팹 관리
```
[System.Serializable]
public class Craft
{
    public string craftName; // 이름
    public GameObject go_Prefab; // 실제 설치될 프리팹.
    public GameObject go_PreviewPrefab; // 미리보기 프리팹.
}

public class CraftManual : MonoBehaviour
{
    //상태변수
    private bool isActivated = false; // 닫힌 상태로 시작함.
    private bool isPreviewActivated = false;

    [SerializeField]
    private GameObject go_BaseUI; // 기본 베이스 UI. UI를 켤수 있게 함.

    [SerializeField]
    private Craft[] craft_fire; //모닥불용 탭

    private GameObject go_Preview; // 미리보기 프리팹을 담을 변수
    private GameObject go_Prefab; // 실제 생설될 프리팹을 담을 변수

    [SerializeField]
    private Transform tf_Player;

    // Raycast 필요 변수 선언
    private RaycastHit hitInfo;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private float range;

    public void SlotClick(int _slotNumber)
    {
        go_Preview = Instantiate(craft_fire[_slotNumber].go_PreviewPrefab, tf_Player.position + tf_Player.forward, Quaternion.identity);
        go_Prefab = craft_fire[_slotNumber].go_Prefab;
        isPreviewActivated = true;
        go_BaseUI.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isPreviewActivated) // 중복 생성 안 되게 함.
            Window();

        if (isPreviewActivated)
            PreviewPositionUpdate();

        if (Input.GetButtonDown("Fire1"))
            Build();

        if (Input.GetKeyDown(KeyCode.Escape))
            Cancel();
    }

    private void Build()
    {
        if (isPreviewActivated && go_Preview.GetComponent<PreviewObject>().IsBuildable())
        {
            Instantiate(go_Prefab, hitInfo.point, Quaternion.identity);
            Destroy(go_Preview);

            isActivated = false;
            isPreviewActivated = false;
            go_Preview = null;
            go_Prefab = null;

            go_BaseUI.SetActive(false);

        }
    }

    private void PreviewPositionUpdate()
    {
        if (Physics.Raycast(tf_Player.position, tf_Player.forward, out hitInfo, range, layerMask))
            if (hitInfo.transform != null)
            {
                Vector3 _location = hitInfo.point;
                go_Preview.transform.position = _location;
            }
    }

    private void Cancel()
    {
        if (isPreviewActivated)
            Destroy(go_Preview);

        isActivated = false;
        isPreviewActivated = false;
        go_Preview = null;

        go_BaseUI.SetActive(false);
    }

    private void Window()
    {
        if (!isActivated) // isActivated가 false일 경우 윈도우를 오픈.
            OpenWindow();
        else
            CloseWindow();
    }

    private void OpenWindow()
    {
        isActivated = true;
        go_BaseUI.SetActive(true);
    }

    private void CloseWindow()
    {
        isActivated = false;
        go_BaseUI.SetActive(false);
    }
}
```
- tab 키를 눌러 모닥불을 생성할 수 있는 건축 창을 켜고 끌 수 있음
- 생성할 프리팹을 public으로 받아와 설정
- 왼쪽 마우스 버튼을 누르면 설치가 되고, ESC버튼을 누르면 설치를 취소할 수 있음

## 클리어 조건 구현🧪
![그림13](https://user-images.githubusercontent.com/84370027/121769066-77ca1080-cb9c-11eb-9efa-5eef20af40f3.png)
![그림14](https://user-images.githubusercontent.com/84370027/121769067-78fb3d80-cb9c-11eb-9c6f-70c39634c4d0.png)
- 전체 맵 곳곳에 배치되어 있는 바위 중에서 3개의 바위를 부수면 '석화 부활액' 드랍
- 인벤토리에 들어있는 석화 부활액을 3개 연달아 사용하면 클리어
- = 왼쪽 아래 게이지 중 녹색의 석화 게이지를 다 채우면 클리어
- 석화 게이지는 게임 시작과 동시에 줄어들며 이를 다시 채우는 것을 목적으로 함
- 석화 부활액 사용 시 효과음이 들리도록 설정
- RealRock.cs : 바위 체력, 파편 관리, 이펙트, **드랍 아이템 관리**
- Rock.cs : **일반 바위** 바위 체력, 파편 관리, 이펙트

## 도움말
![그림12](https://user-images.githubusercontent.com/84370027/121769130-d7282080-cb9c-11eb-8588-89e4815288e9.png)
- 원활한 게임 플레이를 위해 Q키를 누르면 언제든지 도움말 창을 활성화하고 끌 수 있음
- Guide.cs : 창 활성화 여부 판단, 창 열고 닫기 관리

## 일시정지 메뉴
![ddd](https://user-images.githubusercontent.com/84370027/121770145-8b787580-cba2-11eb-890d-d4b638fb9885.JPG)
- 플레이 중 P를 누르면 일시정지 메뉴를 언제든지 활성화하고 끌 수 있음
- Pause.cs : 창 활성화 여부 판단, 창 열고 닫기 관리

## 배경음악
![그림15](https://user-images.githubusercontent.com/84370027/121769169-0fc7fa00-cb9d-11eb-8c92-88dc87c25fed.png)
- 모티브가 된 '닥터 스톤'의 오리지널 사운드 트랙에서 사용
- 게임 타이틀, 플레이, 클리어의 분위기와 맞는 음악을 선정

## 타이틀 및 클리어 씬
![Title](https://user-images.githubusercontent.com/84370027/121769198-3ab24e00-cb9d-11eb-9729-1cc6a48e1e9a.jpg)
- 타이틀 씬
- 유저의 주 활동이 이루어지는 공간을 배경으로 석화된 사람의 모습이 메인으로 들어와 있다
- 시작, 로드, 종료 버튼 구현
- 사용된 폰트 : tower ruins 
- Title.cs : 플레이 씬으로의 이동, 버튼 클릭시 이벤트 관리
- SaveNLoad.cs : 플레이어 위치 값, 인벤토리, 세이브 폴더 값 관리


![Clear](https://user-images.githubusercontent.com/84370027/121769200-3be37b00-cb9d-11eb-9abd-2ac07195193b.jpg)
- 클리어 씬
- 물약을 사용해서 석화를 풀었음을 의미하는 장면으로 구성
- UI - Video Player 기능을 통해 비디오로 보여주도록 함
- 게임 클리어 이후 X창을 눌러 게임을 나가게 함

## 유니티 프로젝트
![캡처](https://user-images.githubusercontent.com/84370027/121769498-dabca700-cb9e-11eb-9a75-925c63bf4e4a.JPG)

# 참고 레퍼런스
- https://keidy.tistory.com/254

# 사용 폰트
- G Market Sans Bold, Medium
