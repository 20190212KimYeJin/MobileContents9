using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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



    void Start()
    {
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
        if(Input.GetKey(KeyCode.X) && currentFireRate <= 0 && !isReload)
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
        if(Physics.Raycast(theCam.transform.position, theCam.transform.forward, out hitinfo, currentGun.range))
        {
            var clone = Instantiate(HitEffect_Prefab, hitinfo.point, Quaternion.LookRotation(hitinfo.normal));
            //hitinfo.normal : 충돌 객체의 표면 반환
            Destroy(clone, 2.0f);
        }
    }

    private void TryReload() //재장전시도
    {
        if(Input.GetKeyDown(KeyCode.R) && !isReload && currentGun.currentBulletCount < currentGun.reloadBulletCount) //재장전 개수보다 작을때
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
        if(currentGun.carryBulletCount > 0)
        {
            isReload = true;
            currentGun.animator.SetTrigger("Reload");

            currentGun.carryBulletCount += currentGun.currentBulletCount;
            currentGun.currentBulletCount = 0;

            yield return new WaitForSeconds(currentGun.reloadTime); //대기 시간

            if(currentGun.carryBulletCount >= currentGun.reloadBulletCount) //현재 총알 >= 총알 재장전 개수
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
        while(currentGun.transform.localPosition != currentGun.fineSightOriginPos)//정조준 모드가 될 때까지
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
            while(currentGun.transform.localPosition.x <= currentGun.retroActionForce  - 0.51f) //lerp가 정확하지 않기 때문에 대충 일치하면 반동이 끝나도록
            {
                currentGun.transform.localPosition = Vector3.Lerp(currentGun.transform.localPosition, recoilBack, 0.1f); //자기위치, 로컬포지션, 최대 반동(빨리 이뤄지기 위해 0.4 속도)
                yield return null; // 한 프레임마다 반복
            }

            //원위치
            while(currentGun.transform.localPosition != originPos)
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
