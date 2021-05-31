using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public string handName; //손 구분
    public float range; //공격범위
    public int damage; //공격력
    public float workSpeed; //작업속도
    public float attackDelay; //공격 딜레이
    public float attackDelay1; //공격 활성화 시점
    public float attackDelay2; //공격 비활성화 시점(주먹이 닿아도 데미지 안 닳게)

    public Animator animator;

}
