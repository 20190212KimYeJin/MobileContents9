using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEffect
{
    public string itemName; // 아이템의 이름. (키값)
    [Tooltip("HP, DP, HUNGRY, THIRSTY , SATISFY만 가능합니다")]
    public string[] part; // 부위.
    public int[] num; // 수치.
}

public class ItemEffectDatabase : MonoBehaviour
{

    [SerializeField] //인스펙터창에서 수정할 수 있도록
    private ItemEffect[] itemEffects;

    [SerializeField]
    private StatusController thePlayerStatus;  // 필요한 컴포넌트 불러오기

    [SerializeField]
    private WeaponManager theWeaponManager;

    [SerializeField]
    private SlotTooltip theSlotToolTip;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip effect_sound;

    private const string HP = "HP", DP = "DP", HUNGRY = "HUNGRY", THIRSTY = "THIRSTY", SATISFY = "SATISFY";

    public void ShowTooltip(Item _item, Vector3 _pos)
    {
        theSlotToolTip.ShowTooltip(_item, _pos); //Slot에서 Itemdatabase로 넘겨주고, 거기서 또 Tooltip으로 넘겨줌
    }

    public void HideTooltip(Item _item)
    {
        theSlotToolTip.HideTooltip();
    }

    public void UseItem(Item _item)
    {

        if (_item.itemType == Item.ItemType.Equipment) //장비 아이템이라면
        {
            StartCoroutine(theWeaponManager.ChangeWeaponCoroutine(_item.weaponType, _item.itemName));
        }
        else if (_item.itemType == Item.ItemType.Used) //소모품이라면
        {

            for (int x = 0; x < itemEffects.Length; x++)
            {

                if (itemEffects[x].itemName == _item.itemName) //회복할 부위 이름 비교
                {

                    for (int y = 0; y < itemEffects[x].part.Length; y++)
                    {

                        switch (itemEffects[x].part[y])
                        {
                            case HP:
                                thePlayerStatus.IncreaseHP(itemEffects[x].num[y]);
                                break;
                            case DP:
                                thePlayerStatus.IncreaseDP(itemEffects[x].num[y]);
                                break;
                            case THIRSTY:
                                thePlayerStatus.IncreaseThirsty(itemEffects[x].num[y]);
                                break;
                            case HUNGRY:
                                thePlayerStatus.IncreaseHungry(itemEffects[x].num[y]);
                                break;
                            case SATISFY:
                                thePlayerStatus.IncreaseSatisfy(itemEffects[x].num[y]);
                                audioSource.clip = effect_sound;
                                audioSource.Play();
                                break; //일치하는 내용 없으면
                            default:
                                Debug.Log("잘못된 Status 부위. HP, DP, HUNGRY, THIRSTY , SATISFY만 가능합니다");
                                break;
                        }

                    }
                    return;
                }


            }
            Debug.Log("ItemEffectDatabase에 일치하는 itemName 없습니다");
        }

    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //인스펙터창에서 수정할 수 있도록

public class ItemEffect
{
    public string itemName; //아이템 이름(키값)
    public string part; //회복 부위
    public int[] num; //아이템별 회복 수치
}

public class ItemEffectDatabase : MonoBehaviour
{

    [SerializeField]
    private ItemEffect[] itemEffects;

    [SerializeField]
    private StatusController thePlayerStatus; // 필요한 컴포넌트 불러오기

    [SerializeField]
    private WeaponManager theWeaponManager;

    private const string HP = "HP", SP = "SP", DP = "DP", HUNGRY = "HUNGRY", THIRSTY = "THIRSTY", SATISFY = "SATISFY"; //상수로 이용

    public void UseItem(Item _item)
    {

        if (_item.itemType == Item.ItemType.Equipment) //장비 아이템이라면
        {
            StartCoroutine(theWeaponManager.ChangeWeaponCoroutine(_item.weaponType, _item.itemName));
        }

        else if (_item.itemType == Item.ItemType.Used) //소모품이라면
        {
            for (int x = 0; x < itemEffects.Length; x++)
            {
                if(itemEffects[x].itemName == _item.itemName) //회복할 부위 이름 비교
                {
                    for (int y = 0; y < itemEffects[x].part.Length; y++)
                    {
                        switch (itemEffects[x].part[y])
                        {
                            case HP:
                                thePlayerStatus.IncreaseHP(itemEffects[x].num[y]);
                                break;

                            case SP:
                                //thePlayerStatus.IncreaseSP(itemEffects[x].num[y]);
                                break;

                            case DP:
                                thePlayerStatus.IncreaseDP(itemEffects[x].num[y]);
                                break;

                            case HUNGRY:
                                thePlayerStatus.IncreaseHungry(itemEffects[x].num[y]);
                                break;

                            case THIRSTY:
                                thePlayerStatus.IncreaseThirsty(itemEffects[x].num[y]);
                                break;

                            case SATISFY:                              
                                break;

                            default: //일치하는 내용 없으면
                                Debug.Log("잘못된 Status 부위 : HP, SP, DP, HUNGRY, THIRSTY, SATISFY만 가능");
                                break;
                        }

                    }
                    return; //아이템 한 번 찾으면 반복문 끝냄
                }
            }            
            //Debug,Log("일치하는 아이템 없음");
        }
    }
}
*/