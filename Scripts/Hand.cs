using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
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
