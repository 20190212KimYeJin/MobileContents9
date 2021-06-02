using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject //게임 오브젝트에 스크립트를 붙이지 않아도 됨
{
    public string itemName; //아이템 이름
    public ItemType itemType; //아이템 유형
    public Sprite itemImage; //아이템 이미지, 이미지는 캔버스에서만 볼 수 있고 스프라이트는 월드상 좌표에서도 볼 수 있음
    public GameObject itemPrefab; //아이템의 프리팹

    public string weaponType; //무기 종류 바꿈

    public enum ItemType //열거
    {
        Equipment,
        Used,
        Ingredient,
        ETC
    }

}
