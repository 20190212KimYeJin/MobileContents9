using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeController : CloseWeaponController
{
    public static bool isActivate = true;

    void Start()
    {
        WeaponManager.currentWeapon = currentHand.GetComponent<Transform>();
        WeaponManager.currentWeaponAnim = currentHand.animator;
    }

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
                if (hitinfo.transform.tag == "Rock")
                {
                    hitinfo.transform.GetComponent<Rock>().Mining();
                }

                else if (hitinfo.transform.tag == "WeekAnimal")
                    hitinfo.transform.GetComponent<WeekAnimal>().Damage(1, transform.position); //상속

                isSwing = false; //한번 적중하면 실행되지 않도록
                Debug.Log(hitinfo.transform.name);
            }

            yield return null;

        }
    }

    public override void HandChange(Hand _hand)
    {
        base.HandChange(_hand);
        isActivate = true;
    }
}
