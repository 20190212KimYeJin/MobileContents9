using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock2 : MonoBehaviour
{
    // 게임 오브젝트
    [SerializeField]
    private int hp; //바위 체력

    [SerializeField]
    private float destroyTime; //파편 삭제 시간

    [SerializeField]
    private SphereCollider col; // 콜라이더 비활성화용

    [SerializeField]
    private GameObject go_rock; //바위

    [SerializeField]
    private GameObject go_debris; //깨진 바위

    [SerializeField]
    private GameObject go_effect_prefab; //바위 이펙트

    [SerializeField]
    private GameObject go_rock_item; //깨지면 나오는 아이템

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip effect_sound;

    [SerializeField]
    private AudioClip effect_sound2;




    public void Mining()
    {
        audioSource.clip = effect_sound;
        audioSource.Play();

        var clone = Instantiate(go_effect_prefab, col.bounds.center, Quaternion.identity);
        //바위 이펙트가, 콜라이더 정가운데에서, 회전값은 기본으로
        Destroy(clone, destroyTime);

        hp--;

        if (hp <= 0)
            Destruction();
    }

    private void Destruction()
    {
        audioSource.clip = effect_sound2;
        audioSource.Play();

        col.enabled = false; // 콜라이더 삭제
        Instantiate(go_rock_item, go_rock.transform.position, Quaternion.identity);
        Destroy(go_rock); // 일반 바위 삭제

        go_debris.SetActive(true); // 깨진 바위 활성화 및 중력으로 인한 파편 튀김
        Destroy(go_debris, destroyTime);
    }
}
