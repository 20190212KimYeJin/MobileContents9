﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : CloseWeaponController
{

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
}
