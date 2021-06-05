using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekAnimal : Animal //상속
{
    public void Run(Vector3 _targetPos) //플레이어 반대방향으로 뛰도록
    {
        direction = Quaternion.LookRotation(transform.position - _targetPos).eulerAngles; //반대방향을 바라보도록, xz값은 설정되지 않게 해야함
        currentTime = runTime;
        isWalking = false;
        isRunning = true;
        applySpeed = runSpeed;
        anim.SetBool("Running", isRunning);
    }

    public override void Damage(int _dmg, Vector3 _targetPos)
    {
        base.Damage(_dmg, _targetPos);

        if(!isDead)
            Run(_targetPos); //죽기 전에는 도망감
    } 

}
