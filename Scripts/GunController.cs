using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    private Gun currentGun; //현재 소유한 총
    private float currentFireRate; //gun.cs에 있는 연사속도
    private AudioSource audioSource;

    private bool isReload = false; //재장전  하는 동안 발사가 안 되도록, false일 때만 발사

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        GunFireRateCalc();
        TryFire();
        TryReload(); //R키 눌러 재장전
    }

    private void GunFireRateCalc()
    {
        if (currentFireRate > 0)
            currentFireRate -= Time.deltaTime; // 60분의 1, 1초에 1 감소        
    }

    private void TryFire()
    {
        if(Input.GetKeyDown(KeyCode.X) && currentFireRate <= 0 && !isReload)
        {
            Fire();
        }
    }

    private void Fire() //방아쇠 당긴 뒤 이벤트(발사 전)
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
        currentGun.currentBulletCount--;
        currentFireRate = currentGun.fireRate; //0.2초가 되면서 발사를 하지 못하게 함
        PlaySound(currentGun.fire_Sound);
        currentGun.muzzleFlash.Play();
        //Debug.Log("발사");
    }

    private void TryReload()
    {
        if(Input.GetKeyDown(KeyCode.R) && !isReload && currentGun.currentBulletCount < currentGun.reloadBulletCount) //재장전 개수보다 작을때
        {
            StartCoroutine(ReloadCoroutine());
        }
    }

    IEnumerator ReloadCoroutine() //대기가 있어야 함
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



    private void PlaySound(AudioClip _clip)
    {
        audioSource.clip = _clip;
        audioSource.Play();
    }
}
