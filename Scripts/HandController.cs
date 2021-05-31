using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    //장착된 손 무기
    [SerializeField]
    private Hand currentHand;

    //공격중
    private bool isAttack = false;
    private bool isSwing = false;

    private RaycastHit hitinfo; //레이저에 닿은 정보를 얻어올 수 있음


    // Update is called once per frame
    void Update()
    {
        TryAttack();
    }

    private void TryAttack()
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

    IEnumerator AttackCoroutine()
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

    IEnumerator HitCoroutine()
    {
        while (isSwing)
        {
            if (CheckObject())
            {
                isSwing = false; //한번 적중하면 실행되지 않도록
                //충돌함
                Debug.Log(hitinfo.transform.name);
            }

            yield return null;

        }
    }

    private bool CheckObject()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hitinfo, currentHand.range)){
            return true;
        }
        return false;
    }

}
