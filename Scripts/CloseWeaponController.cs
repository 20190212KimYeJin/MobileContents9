using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//근접 무기가 생길 때마다 관리하기 쉽도록 만든 스크립트

public abstract class CloseWeaponController : MonoBehaviour //미완성 클래스
{
    
    //장착된 손 무기
    [SerializeField]
    protected Hand currentHand;
    // protected : 상속 받은 것들만 사용 가능

    //공격중
    protected bool isAttack = false;
    protected bool isSwing = false;

    protected RaycastHit hitinfo; //레이저에 닿은 정보를 얻어올 수 있음

    [SerializeField]
    protected LayerMask layerMask; //곡괭이질 하면 플레이어가 출력되는 버그 수정용


    protected void TryAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!isAttack)
            {
                //코루틴 실행
                StartCoroutine(AttackCoroutine());
            }
        }
    }

    protected IEnumerator AttackCoroutine()
    {
        isAttack = true; //중복실행 막음
        currentHand.animator.SetTrigger("Attack");

        yield return new WaitForSeconds(currentHand.attackDelay1);
        isSwing = true;

        StartCoroutine(HitCoroutine());

        //공격 활성화 시점

        yield return new WaitForSeconds(currentHand.attackDelay2);
        isSwing = false;

        yield return new WaitForSeconds(currentHand.attackDelay - currentHand.attackDelay1 - currentHand.attackDelay2);
        isAttack = false;
    }



    //abs 미완성으로 남김
    protected abstract IEnumerator HitCoroutine();



    protected bool CheckObject()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hitinfo, currentHand.range, layerMask))
        {
            return true;
            //Debug.DrawRay(transform.position, transform.forward * hitinfo.distance, Color.red);

        }
        return false;
    }

    //가상 함수 : 완성 함수이지만 추가 편집 가능 함수
    public virtual void HandChange(Hand _hand)
    {
        if (WeaponManager.currentWeapon != null)
            WeaponManager.currentWeapon.gameObject.SetActive(false);

        currentHand = _hand; //현재 무기로 바꿈
        WeaponManager.currentWeapon = currentHand.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentHand.animator;

        currentHand.transform.localPosition = Vector3.zero; //총의 위치를 정조준 0으로 초기화
        currentHand.gameObject.SetActive(true);
    }
}
