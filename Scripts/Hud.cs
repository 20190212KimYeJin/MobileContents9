using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //필수

public class Hud : MonoBehaviour
{
    [SerializeField] //필요 컴포넌트 
    private GunController theGunController;
    private Gun currentGun;

    //허드 필요 시 호출
    [SerializeField]
    private GameObject go_BulletHud;

    [SerializeField] // 총알 개수 반영 텍스트
    private Text[] text_Bullet;


    // Update is called once per frame
    void Update()
    {
        CheckBullet();
    }

    private void CheckBullet()
    {
        currentGun = theGunController.GetGun();
        text_Bullet[0].text = currentGun.carryBulletCount.ToString();
        text_Bullet[1].text = currentGun.reloadBulletCount.ToString();
        text_Bullet[2].text = currentGun.currentBulletCount.ToString();

    }
}
